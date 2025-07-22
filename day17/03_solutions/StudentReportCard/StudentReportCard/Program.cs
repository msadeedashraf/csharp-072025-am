using StudentReportCard;

namespace StudentReportCards
{
    internal class Program
    {

        static void Main(string[] arg)
        {
           StudentReport s1 = new StudentReport("Done", 85, 95 ,90);
            s1.PrintReport();

            StudentReport s2 = new StudentReport("Anurag", 95, 90, 90);
            s2.PrintReport();


            StudentReport s3 = new StudentReport("Salah", 90, 80, 85);
            s3.PrintReport();


            StudentReport s4 = new StudentReport("Aimee", 85, 90, 75);
            s4.PrintReport();

            StudentReport s5 = new StudentReport("Sam", 85, 90, 70);
            s5.PrintReport();



        }

    }


}
