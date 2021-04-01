using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProject
{
    public class Encryption
    {
        private int Entered_Key; //Change these to different variable names and then initialize them within another method

        private string Entered_Message; //Change these to different variable names and then initialize them within another method

        public Encryption(string Plaintext_Message,int Encrypt_Key)//Creates constructor for variables within Encryption class
        {
            Entered_Key = Encrypt_Key;
            Entered_Message = Plaintext_Message;
        }
        public int User_Key { get => Entered_Key; set => Entered_Key = value; } //allows private integer to use value from user input
        

        public string User_Message { get => Entered_Message; set => Entered_Message = value; } //allows private string to use value from user input

        public string Encryption_Method(string Plaintext_Message,int Encrypt_Key) //creates encryption method for encryption
        {
            //Creates character based array filled with letters of the alphabet
            char[] Alphabet_Constant = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            char[] Hidden_Message = Plaintext_Message.ToCharArray();//Create this outside of the method to allow inheritance

            char[] Encrypted_Message = new char[Hidden_Message.Length];//Create this outside of method to allow inheritance

            for(int i = 0; i < Plaintext_Message.Length; i++)
            {
                int Index_Value = Array.IndexOf(Alphabet_Constant, Hidden_Message[i]); //provides the index value of the character of the hidden message within the alphabet

                int Shifted_Index = (Index_Value + Encrypt_Key) % 26; //provides the shifted index value based on the user key

                char Encrypted_Character = Alphabet_Constant[Shifted_Index];

                Encrypted_Message[i] = Encrypted_Character;
            }

            string CipherText = String.Join("", Encrypted_Message);
            Console.WriteLine(CipherText);
            return CipherText;
        }
    }
}
