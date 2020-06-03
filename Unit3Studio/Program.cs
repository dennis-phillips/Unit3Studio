using System;
using System.Collections.Generic;

namespace Unit3Studio
{
    class Program
    {

        
        static void Main(string[] args)
        {
            string inputString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus";
            char[] charArray = inputString.ToCharArray();
            //Console.WriteLine(stringArray.Length);
            Dictionary<char, int> CharacterDictionary = new Dictionary<char, int>();
            for (int i = 0; i < charArray.Length; i++)
            {
                
                if(!CharacterDictionary.ContainsKey(charArray[i]))
                {
                    CharacterDictionary.Add(charArray[i], 1);
                }
                else
                {
                    CharacterDictionary[charArray[i]] += 1;
                }
            }
            foreach (KeyValuePair<char, int> key in CharacterDictionary)
            {
                Console.WriteLine(key.Key + ":" + key.Value);
            }
            //Console.WriteLine("Hello World!");
        }
    }
}
