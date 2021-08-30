using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] athletesAndTheirThrows = Console.ReadLine().Split(' ');
            int athletes = Convert.ToInt32(athletesAndTheirThrows.First());
            int throws = Convert.ToInt32(athletesAndTheirThrows.Last());

            int[,] attemptsAthletes = new int[athletes, throws];
            for (int i = 0; i < athletes; i++)
            {
                string attempts = Console.ReadLine();
                string[] numberOfThrows = attempts.Split(' ');

                for (int j = 0; j < throws; j++)
                {
                    attemptsAthletes[i, j] = Convert.ToInt32(numberOfThrows[j]);
                }
            }

            int index = 0;
            int comparisonVariable = 0;
            for (int i = 0; i < athletes; i++)
            {
                int amountPerLine = 0;
                for (int j = 0; j < throws; j++)
                {
                    amountPerLine = amountPerLine + attemptsAthletes[i, j];
                }
                if(comparisonVariable < amountPerLine)
                {
                    comparisonVariable = amountPerLine;
                    index = i;
                }
            }

            Console.WriteLine(comparisonVariable);
            Console.WriteLine(index);
            Console.ReadKey();
        }
    }
}