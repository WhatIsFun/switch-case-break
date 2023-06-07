using System.Security.Cryptography.X509Certificates;

namespace switch_case_break
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Create a program that takes a character as input and prints "Vowel" if the character
            //is a vowel (a, e, i, o, u) and "Consonant" if it is a consonant.

            //Console.Write("Enter a character> ");//User input character to scan if it is vowel or not
            //char chr = Convert.ToChar(Console.ReadLine());
            //switch (chr)
            //{
            //    case 'a':
            //        Console.WriteLine(chr + " is vowel");
            //        break;

            //    case 'e':
            //        Console.WriteLine(chr + " is vowel");
            //        break;

            //    case 'i':
            //        Console.WriteLine(chr + " is vowel");
            //        break;
            //    case 'o':
            //        Console.WriteLine(chr + " is vowel");
            //        break;
            //    case 'u':
            //        Console.WriteLine(chr + " is vowel");
            //        break;
            //    default:
            //        Console.WriteLine(chr + " is consonant");
            //        break;
            //}




            void month()
            {
                Console.Write("Enter number of the month: ");//User input number of the month
                int months = Convert.ToInt32(Console.ReadLine());
                switch (months)
                {
                    case 1:
                        Console.WriteLine("JAN");
                        break;
                    case 2:
                        Console.WriteLine("FEB");
                        break;
                    case 3:
                        Console.WriteLine("MAR");
                        break;
                    case 4:
                        Console.WriteLine("APR");
                        break;
                    case 5:
                        Console.WriteLine("MAY");
                        break;
                    case 6:
                        Console.WriteLine("JUN");
                        break;
                    case 7:
                        Console.WriteLine("JUL");
                        break;

                    case 8:
                        Console.WriteLine("SEP");
                        break;
                    case 9:
                        Console.WriteLine("OCT");
                        break;
                    case 10:
                        Console.WriteLine("NOV");
                        break;
                    case 11:
                        Console.WriteLine("DEC");
                        break;
                    case 12:
                        Console.WriteLine("Friday");
                        break;
                    default:
                        Console.WriteLine("***   Try Again   ***");
                        month();
                        break;

                }

            }
        }
    }
}