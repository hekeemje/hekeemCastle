using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("ExampleNameVideo1");
            player1.Play();
            player1.Pause();
            player1.Stop();
            player1.Record();
        }
    }
}
