using System;

namespace three
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Info about your computer.");
            Console.WriteLine("Your operation system is : " + Environment.OSVersion);
            Console.WriteLine("This app is in directory : " + Environment.CurrentDirectory);
            Console.WriteLine("Your version of Net. : " + Environment.Version);
            Console.WriteLine("Full way to system directory : " + Environment.SystemDirectory);
            Console.WriteLine("Your username : " + Environment.UserName);
        }
    }
}
