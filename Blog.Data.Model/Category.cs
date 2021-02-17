using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Data.Model
{
    public class Category : ModelBase
    {
        public Category()
        {
            this.Articles = new List<Article>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
    }
}
