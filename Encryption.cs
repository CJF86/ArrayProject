using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProject
{
    class Encryption
    {
        private int Encrypt_Key; //creates private integer that stores the value of the key to the cipher

        private string Plaintext_Message; //creates private string that stores the plaintext message

        public int User_Key { get => Encrypt_Key; set => Encrypt_Key = value; } //allows private integer to use value from user input
        

        public string User_Message { get => Plaintext_Message; set => Plaintext_Message = value; } //allows private string to use value from user input

        public Encryption(string Plaintext_Message,int Encrypt_Key) //creates encryption method for encryption
        {
            //Creates character based array filled with letters of the alphabet
            char[] Alphabet_Constant = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'Z' };

            //creates a character based array that is populated with the plaintext message
            char[] Message_Array = Plaintext_Message.ToCharArray();

            //creates a character based array that is populated with the encrypted message
            char[] Secret_Array = new char[Message_Array.Length];

            //creates for loop that iterates through each character of the message array
            for(int i = 0; i < Message_Array.Length; i++ )
            {
                //creates a variable that obtains one character from the unencrypted secret message
                char Plaintext_letter = Message_Array[i];

                //finds the index of the matching value in the constant alphabet
                int Index = Array.IndexOf(Alphabet_Constant, Plaintext_letter);

                //creates integer that stores the value of the matching alphabet index added to the user key
                int Letter_Position = (Index += User_Key) % 26;

                char Shift_Character = Alphabet_Constant[Letter_Position];//problem is here

                Secret_Array[i] = Shift_Character;

            }

            string Encoded_Message = string.Join("", Secret_Array);
            Console.WriteLine(Encoded_Message);
            
        }
    }
}
