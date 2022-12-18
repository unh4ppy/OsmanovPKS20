using System;

namespace Converter2
{
    class Program
    {
        static void Main(string[] args)
        {
            Commands commands = new Commands();
            commands.Dialog();
            Console.Read();
        }
    }
}
