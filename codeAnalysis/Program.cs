using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());

            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                string[] ss = s.Split(' ');
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = Convert.ToInt32(ss[j]);
                }
            }

            int h = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] < 0)
                    {
                        h = h + a[i, j];
                    }
                }
            }

            Console.WriteLine(h);
            Console.ReadKey();
        }
    }
}