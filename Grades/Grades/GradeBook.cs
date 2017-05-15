using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {
        protected List<float> grades;
        private string _name;
        public NameChangedDelegates NameChanged;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    if (_name != value)
                        NameChanged(_name, value);


                    _name = value;
                }
            }
        }

        public GradeBook()
        {
            grades = new List<float>();
            _name = "Empty";
        }


        public virtual GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;

            foreach (float grade in grades)
            {
                //if (grade > stats.HighestGrade)
                //    stats.HighestGrade = grade;

                //if (grade < stats.LowestGrade)
                //    stats.LowestGrade = grade;

                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);

                sum += grade;
            }

            stats.AverageGrade = sum / grades.Count;

            return stats;
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }



        public void WriteGrade(TextWriter outputFile)
        {
            foreach (float gd in grades)
            {
                outputFile.WriteLine(gd);
            }
        }
    }
}
