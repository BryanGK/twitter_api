import React from 'react';

function TwitterUserCard({ twitterUserData, getRandomTweet }) {

    return twitterUserData.map(item => {
        return (
            <div key={item.id}>
                <div className="card random-card">
                    <img src={item.profile_image_url} className="card-user-img" alt="profile"></img>
                    <div className="card-body random-body">
                        <p className="card-text">@{item.username}</p>
                        <button
                            className="btn btn-info ml-1"
                            data-toggle="modal"
                            data-target="#tweet-modal"
                            onClick={() => getRandomTweet(item.username)}>
                            Random Tweet
                            </button>
                    </div>
                </div>
            </div>
        )
    });
}

export default TwitterUserCard