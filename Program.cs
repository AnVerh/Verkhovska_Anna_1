using System;
using System.Collections.Generic;
using System.Linq;


namespace sem_2_lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("task = ");
            string s = Console.ReadLine();
            while (s != "")
            {
                int task = Int16.Parse(s);
                if (task == 1)
                {
                    List<string> l = new List<string>();
                    string smth;
                    do
                    {
                        smth = Console.ReadLine();
                        if (smth != "")
                        {
                            l.Add(smth);
                        }
                    } while (smth != "");
                    Console.WriteLine("your list :");
                    foreach (string item in l)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("--------------");
                    for (int i = 1; i < l.Count; i++)
                    {
                        string l1 = l[i - 1];
                        string l2 = l[i];
                        l[i] = $"{l2} {l1}";
                    }
                    Console.WriteLine("new list :");
                    foreach (string word in l)
                    {
                        Console.WriteLine(word);
                    }
                }

                if (task == 3)
                {
                    Console.WriteLine("write the string");
                    string text = Console.ReadLine();//"rumor humor roar r road";
                    Console.WriteLine("write the symbol");
                    char c = Char.Parse(Console.ReadLine());
                    string[] words = text.Split(' ');
                    var found = from each in words
                                where each.Last() == each.First() && each.StartsWith(c)==true && each.Count<char>()>1
                                select each;
                    int n = 0;
                    foreach(string w in found)
                    {
                        //Console.WriteLine(w);
                        n++;
                    }
                    Console.WriteLine($"There are {n} words that start and end with symbol {c}");
                    break;
                    Console.ReadKey();

                }

            }
        }
    }
}
