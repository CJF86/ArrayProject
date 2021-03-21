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

            char[] Hidden_Message = Plaintext_Message.ToCharArray();

            char[] Encrypted_Message = new char[Hidden_Message.Length];

            for(int i = 0; i < Plaintext_Message.Length; i++)
            {
                int Index_Value = Array.IndexOf(Alphabet_Constant, Hidden_Message); //provides the index value of the character of the hidden message within the alphabet

                int Shifted_Index = (Index_Value += User_Key) % 26; //provides the shifted index value based on the user key

                char Encrypted_Character = Alphabet_Constant[Shifted_Index];//problem is here

                Encrypted_Message[i] = Encrypted_Character;
            }

            string CipherText = String.Join("", Encrypted_Message);
            Console.WriteLine(CipherText);
        }
    }
}
