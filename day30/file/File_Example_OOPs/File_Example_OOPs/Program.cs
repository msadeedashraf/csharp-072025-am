//Change the name of the namespace to your project name
namespace File_Example_OOPs
{
    internal class Program
    {

        static void Main(string[] arg)
        {
            string sourceFolder = @"D:\CBC\SEProject\SE_MAR_2025\csharp\csharp-072025-am\day30\file\sample_files\FileCollection";
            string resultFile = Path.Combine(sourceFolder, "new_results.txt");

            try
            {
                FileOrganizer organizer = new FileOrganizer(sourceFolder, resultFile);
                organizer.OrganizeFiles();
                organizer.GenerateReport();
                Console.WriteLine("Files organized and report generated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
        }

    }
}