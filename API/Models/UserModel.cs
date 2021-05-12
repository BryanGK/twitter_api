using System;
using System.Collections.Generic;

namespace API.Models
{
    public class DataModel
    {
        public UserModel data { get; set; }
    }

    public class UserModel
    {
        public long id { get; set; }

        public string name { get; set; }

        public string username { get; set; }

        public string profile_image_url { get; set; }
    }
}
