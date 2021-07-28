using System;
using System.Net.Http;
using System.Threading.Tasks;
using API.Models;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net;

namespace API.Services
{
    public interface ITwitterService
    {
        Task<List<TweetModel>> GetTweetsByUser(string search);

        Task<TweetStatusesModel> GetTweetsByKeyword(string keyword);

        Task<DataModel> GetUserData(string search);

        Task<TweetModel> GetRandomTweet(string user);
    }

    public class TwitterService : ITwitterService
    {
        private readonly HttpClient _client;

        public TwitterService(IApiHelper apiHelper)
        {
            _client = apiHelper.InitializeClient();
        }

        public async Task<List<TweetModel>> GetTweetsByUser(string user)
        {
            var response = await _client.GetAsync($"https://api.twitter.com/1.1/statuses/user_timeline.json?screen_name={user}&tweet_mode=extended&count=15");

            if (response.IsSuccessStatusCode)
            {
                var twitterResponse = await response.Content.ReadAsStringAsync();
                
                return JsonConvert.DeserializeObject<List<TweetModel>>(twitterResponse);
            }

            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                throw new Exception($"User '{user}' was not found. Please try again.");
            }
            throw new Exception($"Access Denied. '{user}' is not available. Please try again.");
        }

        public async Task<TweetStatusesModel> GetTweetsByKeyword(string keyword)
        {
            var response = await _client.GetAsync($"https://api.twitter.com/1.1/search/tweets.json?q={keyword}&lang=en&result_type=popular&tweet_mode=extended&count=15");

            if (response.IsSuccessStatusCode)
            {
                var twitterResponse = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<TweetStatusesModel>(twitterResponse);
            }

            throw new Exception("error in TweetProcessor");
        }

        public async Task<DataModel> GetUserData(string search)
        {
            var response = await _client.GetAsync($"https://api.twitter.com/2/users/by/username/{search}?expansions=pinned_tweet_id&user.fields=profile_image_url");

            if (response.IsSuccessStatusCode)
            {
                var twitterResponse = await response.Content.ReadAsStringAsync();

                var jsonResponse =  JsonConvert.DeserializeObject<DataModel>(twitterResponse);

                return jsonResponse;
            }

            throw new Exception("error in TweetProcessor");
        }

        public async Task<TweetModel> GetRandomTweet(string user)
        {
            var response = await _client.GetAsync($"https://api.twitter.com/1.1/search/tweets.json?q=from:{user}&lang=en&count=50&include_entities=true&tweet_mode=extended&expansions=attachments.media_keys");

            if (response.IsSuccessStatusCode)
            {
                var twitterResponse = await response.Content.ReadAsStringAsync();

                var tweets = JsonConvert.DeserializeObject<TweetStatusesModel>(twitterResponse);

                var random = new Random();

                var tweetCount = tweets.statuses.Length;

                var randomIndex = random.Next(0, tweetCount);

                TweetModel randomTweet = tweets.statuses[randomIndex];

                return randomTweet;
            }

            throw new Exception("error in TweetProcessor");
        }
    }
}
