using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProject
{
    public class Decryption : Encryption
    {
        int j;
        int k;
        int Broken_Key;
        char Decoded_Character;
        bool Decrypt_Switch = false;
        int Hidden_index;
        int Actual_Index;
        public Decryption(string Plaintext_Message, int Encrypt_Key) : base(Plaintext_Message, Encrypt_Key)//creates constructor for decryption class using encryption variables
        {
        }

        public string Decryption_Method(string EncryptedMessage)
        {
            string DecryptedMessage = "";

            char[] Alphabet_Constant = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            char[] Decryption_Array = new char[EncryptedMessage.Length];

            char[] Message_Array = EncryptedMessage.ToCharArray();//array containing the encrypted message

            char[] Plaintext_Array = User_Message.ToCharArray();
            while (Decrypt_Switch == false)
            {
                for (j = 0; j <= 25; j++)
                {
                    Broken_Key = j;
                    Console.WriteLine("Breaking key");

                    if (Broken_Key == User_Key)
                    {
                        Console.WriteLine("Key has been found");
                        Decrypt_Switch = true;
                        break;
                    }
                    else
                    {
                        //Decrypt_Switch = false;
                    }
                }
            }
            
            for (k = 0; k < EncryptedMessage.Length; k++)//does not like the word wonderful for some reason
            {
                Hidden_index = Array.IndexOf(Alphabet_Constant, Message_Array[k]);

                Actual_Index = (Hidden_index - Broken_Key) % 26;

                Decoded_Character = Alphabet_Constant[Actual_Index];

                Decryption_Array[k] = Decoded_Character;
            }

            DecryptedMessage = String.Join("", Decryption_Array);

            Console.WriteLine("The decoded message is " + DecryptedMessage);
           
            return DecryptedMessage;
        }
            
        
    }
}
