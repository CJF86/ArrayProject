using System;

namespace ArrayProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a message");

            string User_Message = Console.ReadLine();

            Console.WriteLine("Please enter a key");

            int User_Key = int.Parse(Console.ReadLine());

            Encryption obj = new Encryption(User_Message, User_Key);

            Console.ReadLine();
        }
    }
}
