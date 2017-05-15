using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestGrade
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UsingArray()
        {

            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            Assert.AreEqual(91.65f, grades[0]);
            
        }

        private void AddGrades(float[] grades)
        {
            //grades = new float[5];
            grades[0] = 91.65f;
        }

        [TestMethod]
        public void TestString()
        {
            string name = "scott";
            name = name.ToUpper();

            Assert.AreEqual("SCOTT", name);
        }

        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2017, 3, 20);
            date = date.AddDays(1);

            Assert.AreEqual(21, date.Day);
        }
    }
}
