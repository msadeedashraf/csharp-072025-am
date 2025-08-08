//Change the name of the namespace to your project name
namespace File_Example
{
    internal class Program
    {

        static void Main(string[] arg)
        {
            const string folder = "D:\\CBC\\SEProject\\SE_MAR_2025\\csharp\\csharp-072025-am\\day30\\file\\sample_files\\FileCollection";
            const string resultFile = "D:\\CBC\\SEProject\\SE_MAR_2025\\csharp\\csharp-072025-am\\day30\\file\\sample_files\\FileCollection\\results.txt";


            string new_path_xls = "EMPTY";
            string new_path_doc = "EMPTY";
            string new_path_txt = "EMPTY";
            string new_path_ppt = "EMPTY";
            string new_path_jpg = "EMPTY";

            string my_fileName = "no path";


            long XLSCount = 0, DOCCount = 0, PPTCount = 0, TXTCount = 0, JPGCount = 0;
            long XLSSize = 0, DOCSize = 0, PPTSize = 0, TXTSize = 0, JPGSize = 0;
            long totalfiles = 0;
            long totalsize = 0;

            DirectoryInfo di = new DirectoryInfo(folder);

            new_path_xls = di.FullName + "\\XLSX";
            new_path_txt = di.FullName + "\\TXT";
            new_path_ppt = di.FullName + "\\PPTX";
            new_path_doc = di.FullName + "\\DOCX";
            new_path_jpg = di.FullName + "\\jpg";


            if( !Directory.Exists(new_path_xls))
            {
                Directory.CreateDirectory(new_path_xls);

            }
            if (!Directory.Exists(new_path_doc))
            {
                Directory.CreateDirectory(new_path_doc);

            }
            if (!Directory.Exists(new_path_ppt))
            {
                Directory.CreateDirectory(new_path_ppt);

            }
            if (!Directory.Exists(new_path_txt))
            {
                Directory.CreateDirectory(new_path_txt);

            }
            if (!Directory.Exists(new_path_jpg))
            {
                Directory.CreateDirectory(new_path_jpg);

            }


            foreach (FileInfo fi in di.EnumerateFiles())
            {
                my_fileName = fi.Name;
                if(checkFileType(fi.Name))
                {
                    totalfiles++;
                    totalsize += fi.Length;

                    if (fi.Name.EndsWith(".xlsx"))
                    {
                        XLSCount++;
                        XLSSize += fi.Length;
                        fi.MoveTo(new_path_xls + "\\" + fi.Name);

                    }
                    if (fi.Name.EndsWith(".txt"))
                    {
                        TXTCount++;
                        TXTSize += fi.Length;
                        fi.MoveTo(new_path_txt + "\\" + fi.Name);

                    }
                    if (fi.Name.EndsWith(".docx"))
                    {
                        DOCCount++;
                        DOCSize += fi.Length;
                        // fi.CopyTo(new_path_doc+"\\"+fi.Name);
                        fi.MoveTo(new_path_doc + "\\" + fi.Name);
                    }
                    if (fi.Name.EndsWith(".pptx"))
                    {
                        PPTCount++;
                        PPTSize += fi.Length;
                        //fi.CopyTo(new_path_ppt+"\\"+fi.Name);
                        fi.MoveTo(new_path_ppt + "\\" + fi.Name);
                    }
                    if (fi.Name.EndsWith(".jpg"))
                    {
                        JPGCount++;
                        JPGSize += fi.Length;
                        //fi.CopyTo(new_path_ppt+"\\"+fi.Name);
                        fi.MoveTo(new_path_jpg + "\\" + fi.Name);
                    }
                }
            }




            bool checkFileType(string fileName)
                {
                if (    
                        fileName.EndsWith(".xlsx") || 
                        fileName.EndsWith(".docx") || 
                        fileName.EndsWith(".txt")  || 
                        fileName.EndsWith(".pptx") || 
                        fileName.EndsWith(".jpg")
                   )
                {
                    return true;
                }

                return false;
                }



            //Write the File  info in the txt file

            using (StreamWriter sw = File.CreateText(resultFile))
            {

                sw.WriteLine("~~~~ Results ~~~~");
                sw.WriteLine($"Total Files: {totalfiles}");
                //sw.WriteLine($"newPath: {new_path}");
                //   sw.WriteLine($"My Path with File: {my_fileName}");  
                sw.WriteLine($"Excel Count: {XLSCount}");
                sw.WriteLine($"Word Count: {DOCCount}");
                sw.WriteLine($"PowerPoint Count: {PPTCount}");
                sw.WriteLine($"Text File Count: {TXTCount}");
                sw.WriteLine($"JPG File Count: {JPGCount}");
                sw.WriteLine("----");
                sw.WriteLine($"Total Size: {totalsize:N0}");
                sw.WriteLine($"Excel Size: {XLSSize:N0}");
                sw.WriteLine($"Word Size: {DOCSize:N0}");
                sw.WriteLine($"PowerPoint Size: {PPTSize:N0}");
                sw.WriteLine($"Text File Size: {TXTSize:N0}");
                sw.WriteLine($"JPG File Size: {JPGSize:N0}");


            }


        }
    }
}