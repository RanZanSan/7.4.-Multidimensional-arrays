using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrixSymmetric
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                string[] ss = s.Split(' ');

                for (int j = 0; j < n; j++)
                {
                    a[i, j] = Convert.ToInt32(ss[j]);
                }
            }

            string answer = "";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] == a[j, i])
                        answer = "YES";
                    else
                    {
                        answer = "NO";
                        break;
                    }
                }
                if (answer == "NO")
                    break;
            }

            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}