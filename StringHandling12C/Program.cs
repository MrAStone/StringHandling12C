using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHandling12C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aString = "This is a string";
            //length
            Console.WriteLine(aString.Length);
         
            //position
            Console.WriteLine(aString[0]);
            Console.WriteLine(aString[aString.Length-1]);
            // Console.WriteLine(aString[aString.Length]); will error as outside bounds
            for (int i = 0; i < aString.Length; i++)
            {
                Console.WriteLine(aString[i]);
            }
            //substring
            Console.WriteLine(aString.Substring(7));
            Console.WriteLine(aString.Substring(2, 4));
            //Console.WriteLine(aString.Substring(7, 20));error as 20 length is too much


            //concatenation
            Console.WriteLine("This is a astring " + aString);
            Console.WriteLine("This is a astring " + aString + " look what I can do");
            Console.WriteLine($"this is a string {aString} look what I can do");
            Console.WriteLine($"{aString} {aString}");
            Console.WriteLine("this is a string {0}", aString);
            string first = "First String";
            string second = "Second String";
            Console.WriteLine("Using + to join " + first + second);
            Console.WriteLine($"Using string formatter {first} {second}");
            Console.WriteLine("Using parameters {0} {1}",first,second);

            //character → character code
            char aChar = 'A';
            Console.WriteLine(Convert.ToInt32(aChar));
            aChar = '1';
            Console.WriteLine(Convert.ToInt32(aChar));
            string name;
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            for(int i = 0;i< name.Length;i++)
            {
                Console.WriteLine(Convert.ToInt32(name[i]));
            }

            //character code → character
            Console.WriteLine(Convert.ToChar(65));
            Console.WriteLine(Convert.ToChar(42));
            for(int i = 65;i< 91; i++)
            {
                Console.Write(Convert.ToChar(i));
            }
            Console.WriteLine();
            for(int i = Convert.ToInt32('A'); i <= Convert.ToInt32('Z'); i++)
            {
                Console.WriteLine(Convert.ToChar(i));
            }

            //string conversion operations.
            //Expected string conversion operations:

            //string to integer
            int age;
            Console.Write("Enter your age: ");
            age =Convert.ToInt32( Console.ReadLine());

            //string to float
            double volume;
            Console.Write("Enter the volume of your cup: ");
            volume = Convert.ToDouble( Console.ReadLine());

            //integer to string
            Console.WriteLine(age.ToString());

            //float to string
            Console.WriteLine(volume.ToString().Length);

            //date / time to string
            DateTime d = DateTime.Now;
            Console.WriteLine(d.ToString());
            Console.WriteLine(d.DayOfWeek);
            //string to date / time

            string DOB;
            Console.Write("Enter DOB: ");
            DOB = Console.ReadLine();
            d = Convert.ToDateTime(DOB);
            Console.WriteLine(d.DayOfWeek);




        }
    }
}
