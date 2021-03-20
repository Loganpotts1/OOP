using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoPost newPost = new VideoPost("Logan Potts", "First Post", "Hi! This is my first post!", "https://videos.com/some_meme");
            newPost.Display();
            newPost.Play();
        }
    }
}
