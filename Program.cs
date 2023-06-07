using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace switch_case_break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vowel();
            //month();
            //grade();
            days();

        }

        //Create a program that takes a character as input and prints "Vowel" if the character
        //is a vowel (a, e, i, o, u) and "Consonant" if it is a consonant.
        //static void vowel() {
        //    Console.Write("Enter a character> ");//User input character to scan if it is vowel or not
        //    char chr = Convert.ToChar(Console.ReadLine());
        //    switch (chr)
        //    {
        //        case 'a':
        //            Console.WriteLine(chr + " is vowel");
        //            break;

        //        case 'e':
        //            Console.WriteLine(chr + " is vowel");
        //            break;

        //        case 'i':
        //            Console.WriteLine(chr + " is vowel");
        //            break;
        //        case 'o':
        //            Console.WriteLine(chr + " is vowel");
        //            break;
        //        case 'u':
        //            Console.WriteLine(chr + " is vowel");
        //            break;
        //        default:
        //            Console.WriteLine(chr + " is consonant");
        //            break;
        //    }

        //}

        //Write a program that takes a month number (1-12) as input and prints the 
        //corresponding month name.For example, if the input is 3, the program should print
        //"March."
        //static void month()
        //{
        //    Console.Write("Enter number of the month: ");//User input number of the month
        //    int months = Convert.ToInt32(Console.ReadLine());
        //    switch (months)
        //    {
        //        case 1:
        //            Console.WriteLine("JAN");
        //            break;
        //        case 2:
        //            Console.WriteLine("FEB");
        //            break;
        //        case 3:
        //            Console.WriteLine("MAR");
        //            break;
        //        case 4:
        //            Console.WriteLine("APR");
        //            break;
        //        case 5:
        //            Console.WriteLine("MAY");
        //            break;
        //        case 6:
        //            Console.WriteLine("JUN");
        //            break;
        //        case 7:
        //            Console.WriteLine("JUL");
        //            break;

        //        case 8:
        //            Console.WriteLine("SEP");
        //            break;
        //        case 9:
        //            Console.WriteLine("OCT");
        //            break;
        //        case 10:
        //            Console.WriteLine("NOV");
        //            break;
        //        case 11:
        //            Console.WriteLine("DEC");
        //            break;
        //        case 12:
        //            Console.WriteLine("Friday");
        //            break;
        //        default:
        //            Console.WriteLine("***   Try Again   ***");
        //            month();
        //            break;

        //    }

        //}

        //Create a program that takes a grade (A, B, C, D, F) as input and prints the 
        //corresponding message. For example, if the input is 'A', the program should print
        //"Excellent."
        static void grade()
        {
            Console.Write("Enter a grade > ");//User input character to scan if it is vowel or not
            char gr = Convert.ToChar(Console.ReadLine());
            switch (gr)
            {
                case 'A' or 'a':
                    Console.WriteLine(gr + " is Excellent");
                    break;

                case 'B' or 'b':
                    Console.WriteLine(gr + " is Good");
                    break;

                case 'C' or 'c':
                    Console.WriteLine(gr + " is Satisfactory");
                    break;
                case 'D' or 'd':
                    Console.WriteLine(gr + " is Passing");
                    break;
                case 'F' or 'f':
                    Console.WriteLine(gr + " is Failure");
                    break;
                default:
                    Console.WriteLine("!!!! Enter Another Value !!!!");
                    grade();
                    break;
            }
        }



        //Write a program that takes a day number(1 - 7) as input and prints the
        //corresponding day of the week. For example, if the input is 2, the program should 
        //print "Tuesday."

        static void days()
        {
            Console.Write("Enter number of the day: ");//User input number of the month
            int day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    days();
                    break;
            }
        }




    }
}
