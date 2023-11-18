/**
 Problem Link : https://codeforces.com/problemset/problem/118/A
 Status : Accepted.

Sample input : tour
Sample Output : .t.r

**/

namespace Codeforces118A
{
    internal class Codeforces118AClass
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            word = word.ToLower();

            for(int i = 0; i < word.Length; i++)
            {
                char ch = word[i];

                if (ch != 'a' && ch != 'e' && ch != 'i' && ch != 'o' && ch != 'u' && ch!= 'y')
                    Console.Write(".{0}", ch);
            }
            Console.WriteLine();
        }
    }
}


// another approch

using System;

namespace Codeforces118A
{
    internal class Codeforces118AClass
    {
        static void Main(string[] args)
        {
            string? word = Console.ReadLine();
            word = word?.ToLower();
            string vowels = "aeiouy";

            foreach(char ch in word)
            {
                if (!vowels.Contains(ch))
                    Console.Write($".{ch}");
            }
        }
    }
}
