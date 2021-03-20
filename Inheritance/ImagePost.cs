using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class ImagePost : Post
    {
        protected string ImageURL { get; set; }
        public ImagePost(string user, string title, string body, string imageURL) : base(user, title, body) 
        {
            ImageURL = imageURL;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Image: {ImageURL}");
        }
    }
}
