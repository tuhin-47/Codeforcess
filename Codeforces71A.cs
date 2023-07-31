/**
 * Problem Link : https://codeforces.com/problemset/problem/71/A
 * Status : Accepted
 
Sample Input:
------------
4
word
localization
internationalization
pneumonoultramicroscopicsilicovolcanoconiosis

Sample Output:
-------------
word
l10n
i18n
p43s

**/

namespace Codeforces71A
{
    internal class Codeforces71AClass
    {
        static void Main(string[] args)
        {
            int totalCases = Convert.ToInt32(Console.ReadLine());
            while( totalCases > 0)
            {
                string word = Console.ReadLine();
                int length = word.Length;
                if (length <= 10)
                    Console.WriteLine("{0}", word);
                else
                {
                    Console.Write("{0}{1}{2}\n", word[0], word.Length - 2, word[word.Length - 1]);
                    
                }

                --totalCases;
            }
        }
    }
}
