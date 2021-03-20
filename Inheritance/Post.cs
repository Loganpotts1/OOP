using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Post
    {
        private static int CurrPostId { get; set; }
        protected int PostId { get; set; }
        protected string User { get; set; }
        protected string Title { get; set; }
        protected string Body { get; set; }

        public Post(string user, string title, string body)
        {
            PostId = ++CurrPostId;
            User = user;
            Title = title;
            Body = body;
        }

        public virtual void Display()
        {
            Console.WriteLine($"{Title} -- {User}");
            Console.WriteLine($"{Body}");
        }

    }
}
