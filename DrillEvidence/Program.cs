using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrillEvidence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n======================  Decision  ======================");
            Decision();
            Console.WriteLine("\n======================  LOOPS  ======================");
            Loops();
            Console.WriteLine("\n======================  SHORT CIRCUIT  ======================");
            ShortCircuit();
            Console.ReadKey();
        }

        private static void ShortCircuit()
        {
            Console.WriteLine("\nAND OPERATION: ");
            double evidenceMark = 40;
            double extarnalMark = 26;
            if (evidenceMark >= 30 && extarnalMark >= 30)
            {
                Console.WriteLine("You PASSED!!!!!!!!!!");
            }
            else
            {
                Console.WriteLine("TRY NEXT TIME........");
            }
            Console.WriteLine("\nOR OPERATION: ");
            int retakeTaken = 1;
            if (evidenceMark >= 30 && extarnalMark >= 30)
            {
                Console.WriteLine("You PASSED!!!!!!!!!!");
            }
            else if (evidenceMark >= 30 && extarnalMark >= 30 || retakeTaken< 2)
            {
                Console.WriteLine("RETAKE THE EXAMS. BEST OF LUCK......");
            }
            else
            {
                Console.WriteLine("SORRY. YOU HAVE BEEN WITHDRAWNED........");
            }
        }

        private static void Decision()
        {
            Console.WriteLine("\nIf...Else: \n");
            int mark = 55;
            if (mark >= 40)
            {
                Console.WriteLine("You have Passed");
            }
            else
            {
                Console.WriteLine("You have Failed");
            }

            Console.WriteLine("\nSwitch Case: \n");
            DateTime dT = DateTime.Now;
            switch (DateTime.Now.Hour>=12)
            {
                case true:
                    Console.WriteLine("Good Afternoon");
                break;
                case false:
                    Console.WriteLine("Good Morning");
                    break;
                default:
                    Console.WriteLine("Good Day");
                    break;
            }
        }

        private static void Loops()
        {
            Console.WriteLine("\nfor Loop: ");

            int i;
            for (i = 0; i<=10; i++)
            {
                Console.Write($"{i} \t");
            }
            Console.WriteLine();

            Console.WriteLine("\nwhile loop:");

            int n = 0;
            while (n<=10)
            {
                Console.Write($"{n} \t");
                ++n;
            }
            Console.WriteLine();

            Console.WriteLine("\ndo........while loop:");

            int m= 0;
            do
            {
                Console.Write($"{m} \t");
                ++m;
            } while (m<=10);
            Console.WriteLine();
        }
    }
}
