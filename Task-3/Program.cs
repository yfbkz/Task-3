using System;
using System.Linq;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string letters = "abcdefghijklmnopqrstuvwxyz";
            string incor = "";
            for (int i = 0; i < s1.Length; i++)
            {
                if (!letters.Contains(Convert.ToString(s1[i])))
                {
                    incor += $"{s1[i]} ";
                }
            }
            if (s1 != null && incor == "")
            {
                string s4 = "";
                int a = s1.Length - 1;
                if (s1.Length % 2 == 0)
                {
                    a = a / 2;
                    string s2 = s1.Substring(0, a + 1);
                    string s3 = s1.Substring(a + 1);
                    for (int i = 0; i <= a; i++)
                    {
                        s4 = s4 + s2[a - i];
                    }
                    for (int i = 0; i <= a; i++)
                    {
                        s4 = s4 + s3[a - i];
                    }
                }
                else
                {
                    for (int i = 0; i <= a; i++)
                    {
                        s4 = s4 + s1[a - i];
                    }
                    s4 = s4 + s1;
                }
                Console.WriteLine(s4);
                char[] chars = s4.Distinct().ToArray();

                for (int i = 0; i < chars.Length; i++)
                {
                    int q = 0;
                    for (int j = 0; j < s4.Length; j++)
                    {
                        if (chars[i] == s4[j])
                        {
                            q += 1;
                        }
                    }
                    Console.WriteLine($"{chars[i]}: {q}");
                }
            }
            else if (s1 == null)
            {
                Console.WriteLine("Empty line.");
            }
            else
            {
                Console.WriteLine($"Incorrect input: {incor}");

            }
            Console.ReadLine();
        }
    }
}
