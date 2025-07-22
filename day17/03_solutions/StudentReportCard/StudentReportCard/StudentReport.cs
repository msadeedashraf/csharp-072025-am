using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentReportCard
{
    internal class StudentReport
    {
        //Fields
        private string studentName;
        private int subject1, subject2, subject3;

        //Constructor
        public StudentReport(string name, int s1, int s2, int s3)
        {
            studentName = name;
            subject1 = s1;
            subject2 = s2;
            subject3 = s3;
        }

        //Methods
        //https://www.w3schools.com/cs/cs_methods.php

        


        public double CalculateAverage() 
        {
            /* TODO */
            return (subject1 + subject2 + subject3) / 3;

        }
        public string GetGrade() 
        { 
            /* TODO */ 
            double avg = CalculateAverage();
            if (avg >= 90) return "A";
            else if (avg >= 80) return "B";
            else if (avg >= 70) return "C";
            else if (avg >= 60) return "D";
            else return "F";
        }
        public void PrintReport() 
        { 
            /* TODO */ 
            Console.WriteLine($"\t\t ******* \nStudent Name : {studentName}");
            Console.WriteLine($"Average : {CalculateAverage()}");
            Console.WriteLine($"Grade : {GetGrade()}\n \t\t ******* \n");
        }
    }
}
