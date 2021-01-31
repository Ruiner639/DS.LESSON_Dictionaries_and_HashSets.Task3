using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DS.LESSON_Dictionaries_and_HashSets.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\1392659\Desktop\words.txt", text;
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine("This is the TEXT. Text, text, text – THIS TEXT! Is this the text?");
            };
            using (StreamReader sr = new StreamReader(path, true))
            {
                text = (sr.ReadLine()).ToLower();
            };
            text = text.Replace(".", "").Replace(",", "").Replace("–", "").Replace("?", "").Replace("!", "");
            string[] list = text.Split(" ");
            int[] count = new int[4];
            int a = 0;
            while(a < list.Length)
            {
                switch (list[a])
                {
                    case ("this"):
                        count[0]++;
                        break;
                    case ("is"):
                        count[1]++;
                        break;
                    case ("the"):
                        count[2]++;
                        break;
                    case ("text"):
                        count[3]++;
                        break;
                }
                a++;
            }
            Console.WriteLine("this -> " + count[0]);
            Console.WriteLine("is -> " + count[1]);
            Console.WriteLine("the -> " + count[2]);
            Console.WriteLine("text -> " + count[3]);
        }
    }
}
