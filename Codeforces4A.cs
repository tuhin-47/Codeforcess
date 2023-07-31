//Problem Link: https://codeforces.com/contest/4/problem/A
//Status : Accepted

namespace Codeforces4A
{
    internal class Codeforces4AClass
    {
        static void Main(string[] args)
        {
            int w = Convert.ToInt32(Console.ReadLine());
            if( w % 2 == 0 && w!= 2)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
