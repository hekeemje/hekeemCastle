using System;

namespace Task2
{
    class Player : IPlayable, IRecodable
    {
        public string FileName { get; set; }

        public Player(string name)
        {
            FileName = name;
        }

        public void Pause()
        {
            Console.WriteLine($"{FileName} video on pause now.");
        }

        public void Play()
        {
                Console.WriteLine($"Starting play video {FileName}");
        }

        public void Record()
        {
            Console.WriteLine($"Starting record {FileName} video.");
        }

        public void Stop()
        {
            Console.WriteLine($"Video {FileName} stoped now.");
        }
    }
}
