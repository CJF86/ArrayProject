using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProject
{
    class Encryption
    {
        private int Encrypt_Key;

        private string Plaintext_Message;

        public int User_Key { get => Encrypt_Key; set => Encrypt_Key = value; }
        //Creates character based array filled with letters of the alphabet
        char[] Alphabet_Constant = new char[] {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
    }
}
