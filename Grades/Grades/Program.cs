using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new ThrowAwayGradeBook();
            book.NameChanged = new NameChangedDelegates(OnNameChanged);
            book.NameChanged += new NameChangedDelegates(OnNameChanged2);
            book.AddGrade(96);
            book.AddGrade(89.6f);
            book.AddGrade(56.25f);
            book.Name = "Rahul's Book";
            book.Name = "Apple's Book";

            using (StreamWriter outputFile = File.CreateText("MyGradeBook.txt"))
            {
                book.WriteGrade(outputFile);

            }

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            WriteResult("Average",stats.AverageGrade);
            WriteResult("Lowest Grade",(int)stats.LowestGrade); // explicit 
            WriteResult("Highest Grade", stats.HighestGrade, 1, 2, 6);
            WriteResult(stats.Description, stats.LetterGrade);
            Console.ReadKey();
        }

        static void OnNameChanged(string ExistName, string newName)
        {
            Console.WriteLine("Name got updated from {0}   to {1} ",ExistName, newName);
        }

        static void OnNameChanged2(string ExistName, string newName)
        {
            Console.WriteLine("****");
        }

        static void WriteResult(string message, Int32 x)
        {
            Console.WriteLine(message + ": " + x);
        }

        static void WriteResult(string message, params float[] x)
        {
            Console.WriteLine("{0}: {1}",message, x[0]);
        }

        static void WriteResult(string message, string msg)
        {
            Console.WriteLine("{0}: {1}", message, msg);
        }
    }
}
