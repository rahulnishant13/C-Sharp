using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class ThrowAwayGradeBook : GradeBook
    {
        public override GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("In ThrowAway GradeBook Class");
            float lowest = float.MaxValue;
            foreach(float x in grades)
            {
                lowest = Math.Min(x, lowest);
            }

            grades.Remove(lowest);

            return base.ComputeStatistics();
        }
    }
}
