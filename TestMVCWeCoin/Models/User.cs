using System;
using System.Collections.Generic;

namespace TestMVCWeCoin.Models
{
    public class User
    {
        public User()
        {
            Posts = new List<Post>();
        }

        public String ImgURL { get; set; }

        public String Nome { get; set; }

        public String Email { get; set; }

        public List<Post> Posts { get; set; }
    }
}