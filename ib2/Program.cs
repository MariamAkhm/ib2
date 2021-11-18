using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ib2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Key: ");
            if (!int.TryParse(Console.ReadLine(), out int key))
            {
                Console.WriteLine("1");
            }
            Console.Write("Text: ");
            string text = Console.ReadLine();
            text = Encode(text, key);
            Console.WriteLine("Encode Text: " + text);
            Console.WriteLine("0");
        }
        static string Encode(string text, int key)
        {
            char[] newArrCharText = new char[text.Length];
            string abc = "abcdefghijklmnopqrstuvwxyz";
            string ABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0; i < text.Length; i++)
            {
                int ind1 = abc.IndexOf(text[i]);
                int ind2 = ABC.IndexOf(text[i]);
                if (ind1 == -1 && ind2 == -1)
                {
                    newArrCharText[i] = text[i];
                }
                else if (ind1 != -1)
                {
                    newArrCharText[i] = abc[(ind1 + key) % 26];
                }
                else
                {
                    newArrCharText[i] = ABC[(ind2 + key) % 26];
                }
            }
            return new string(newArrCharText);
        }
    }
}
