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
            Console.WriteLine("\n======================  (a) Decision  ======================");
            Decision();

            Console.WriteLine("\n======================  (a) LOOPS  ======================");
            Loops();

            Console.WriteLine("\n======================  (b) SHORT CIRCUIT  ======================");
            ShortCircuit();


            Console.WriteLine("\n======================  (c) Declaring, naming & assigning variable, using primitive data types  ======================\n");
            Variables();

            Console.WriteLine("\n======================  (c) arithmetic operators  ======================\n");
            Oparetors();

            Console.WriteLine("\n======================  (c) POST-PREfix  ======================\n");
            PostPreFix();

            Console.WriteLine("\n======================  (d) Methods  ======================\n");
            MethodsParameters1(1, "NAKIBUL");
            MethodsParameters2(msg: "ISLAM", n: 2);
            MethodsOptionalParameters();
            int sum = Addition(10, 20);
            Console.WriteLine(sum);

            Console.WriteLine("\n======================  (e) Checked and UNchecked  ======================\n");
            CheckedUnchecked();

            Console.WriteLine("\n======================  (f) TRY-CATCH-FINALLY  ======================\n");
            TryCatchFinally();

            Console.ReadKey();
        }

        private static void TryCatchFinally()
        {
            int x = 10, y = 0;
            try
            {
                Console.WriteLine(x / y);
                throw new Exception("Fatal ERROR!!!!!!!!!");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }   
        }

        private static void CheckedUnchecked()
        {
            int n = int.MaxValue;
            checked
            {
                try
                {
                    n++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            unchecked
            {
                n++;
                Console.WriteLine(n);
            }
        }

        private static int Addition(int a, int b)
        {
            Console.WriteLine("\n\nMethod with Returns: \n");
            return a + b;
        }

        private static void MethodsOptionalParameters(int n = 1, string msg = "NAKIBUL")
        {
            Console.WriteLine("\n\nMethod with Optional Parameters: \n");
            for (n = 0; n < 5; n++)
            {
                Console.Write($"{msg} \t");
            }

        }

        private static void MethodsParameters2(int n, string msg)
        {
            Console.WriteLine("\n\nMethod call by parameters Name: \n");
            for (n = 0; n < 5; n++)
            {
                Console.Write($"{msg} \t");
            }
        }

        private static void MethodsParameters1(int n, string msg)
        {
            Console.WriteLine("Method call by Parameters: \n");
            for (n = 0; n < 5; n++)
            {
                Console.Write($"{msg} \t");
            }
        }

        private static void PostPreFix()
        {
            int num1 = 10;
            Console.WriteLine($"Initial Value: {num1}");
            int preFixResult = ++num1;
            Console.WriteLine($"\nPre-Fix Increment: ++Value = {preFixResult} (num1 is now {num1})");
            num1 = 10;
            int postFixResult = num1++;
            Console.WriteLine($"\nPost-Fix Increment: Value++ = {postFixResult} (num1 is now {num1})");
        }

        private static void Oparetors()
        {
            int a = 61, b = 66;
            Console.WriteLine("Addition :\n "+ $"{a} + {b} = {a + b}");
            Console.WriteLine($"\nSubstraction :\n {a} - {b} = {a - b}");
            Console.WriteLine($"\nMultiplication :\n {a} * {b} = {a * b}");
            Console.WriteLine($"\nDivision :\n {a} / {b} = {a / b}");
            Console.WriteLine($"\nModulus :\n {a} % {b} = {a % b}");
        }

        private static void Variables()
        {
            int IntVar = 22;
            double DoubleVar = 22.5D;
            string StringVar = "Nakibul Islam Fahim";
            bool BoolVar = true;
            float FloatVar = 22.7F;
            long LongVar = 225000L;
            decimal DecimalVar = 22500.55M;
            DateTime DateTimeVar = DateTime.Now;
            var ImplicitVar = 213123123L;
            Console.WriteLine($"{IntVar}, {DoubleVar}, {StringVar}, {BoolVar}, {FloatVar}, {LongVar}, {DecimalVar}, {DateTimeVar:f}, {ImplicitVar}");
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
