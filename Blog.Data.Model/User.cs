﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Data.Model
{
    public class User
    {
        public User()
        {
            this.Articles = new List<Article>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
    }
}
