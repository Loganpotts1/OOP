using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Inheritance
{
    class VideoPost : Post
    {
        protected string Video { get; set; }
        protected static int Count { get; set; }
        protected static Timer newTimer = new Timer();

        public VideoPost (string user, string title, string body, string video) : base(user, title, body)
        {
            Video = video;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Video: {Video}");
        }

        public void Play()
        {
            newTimer.Elapsed += new ElapsedEventHandler(OnInterval);
            newTimer.Interval = 1000;
            newTimer.Start();

            Console.WriteLine("Video now playing, enter any key to stop");

            if (Console.Read() != -1)
            {
                Console.WriteLine($"Stopped at {Count} seconds");
                newTimer.Stop();
            }
        }

        private static void OnInterval(Object sender, ElapsedEventArgs e)
        {
            Count++;
        }
    }
}
