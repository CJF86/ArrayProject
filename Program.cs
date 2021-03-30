using System;

namespace ArrayProject
{
    class Program
    {

        //private bool Switch = false;
        //string User_Option;
        static void Main(string[] args)
        {

            string User_Option;
            bool Switch = false;

            Console.WriteLine("Would you like to encode a message?");

            User_Option = Console.ReadLine();

            if(User_Option.ToUpper() == "YES")
            {
                Switch = true;
            }
            else if (User_Option.ToUpper() == "NO")
            {
                Console.WriteLine("Try Again");
                Switch = false;
                
            }
            while (Switch == true)
            {
                Console.WriteLine("Please enter a message");//asks the user to enter their message

                string User_Message = Console.ReadLine();//stores input within the User_Message variable

                Console.WriteLine("Please enter a key");

                int User_Key = int.Parse(Console.ReadLine());

                Encryption Encryption_1 = new Encryption(User_Message, User_Key);

               String encryptedMessage =  Encryption_1.Encryption_Method(User_Message, User_Key);
                Decryption decryptor = new Decryption(encryptedMessage, User_Key);


                Console.WriteLine("Would you like to encode a new message");

                User_Option = Console.ReadLine();

                if (User_Option.ToUpper() == "YES")
                {
                    Switch = true;
                    Console.WriteLine("okay");
                }
                else if (User_Option.ToUpper() == "NO")
                {
                    Console.WriteLine("Try Again");
                    Switch = false;
                    break;
                }

                Console.ReadLine();
            }
        }
    }
}
