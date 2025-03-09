using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Info_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Student Info List ****");
            Console.WriteLine();

            string studentName, studentSurname, studentAge, studentHighschool, studentGraduatedyear, studentBirthplace, studentBirtyear;

            Console.Write("Name: ");
            studentName = Console.ReadLine();

            Console.Write("Surname: ");
            studentSurname = Console.ReadLine();

            Console.Write("Age: ");
            studentAge = Console.ReadLine();

            Console.Write("Graduated High School Name: ");
            studentHighschool = Console.ReadLine();

            Console.Write("Graduated Year: ");
            studentGraduatedyear = Console.ReadLine();

            Console.Write("Birth Place: ");
            studentBirthplace = Console.ReadLine();

            Console.Write("Birth Year: ");
            studentBirtyear = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Name Surname: " + studentName + " " + studentSurname);
            Console.WriteLine("Graduated High School Name/Graduated Year: " + studentHighschool + " / " + studentGraduatedyear);
            Console.WriteLine("Birth Place/Year: " + studentBirthplace + " / " + studentBirtyear);

            Console.Read();



        }
    }
}
