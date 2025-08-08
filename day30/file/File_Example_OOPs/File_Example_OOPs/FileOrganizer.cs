using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Example_OOPs
{
    internal class FileOrganizer
    {

        private readonly string _sourceFolder;
        private readonly string _resultFile;
        private readonly Dictionary<string, FileCategoryInfo> _fileCategories;

        private long _totalFiles = 0;
        private long _totalSize = 0;

        public FileOrganizer(string sourceFolder, string resultFile)
        {
            _sourceFolder = sourceFolder;
            _resultFile = resultFile;

            _fileCategories = new Dictionary<string, FileCategoryInfo>(StringComparer.OrdinalIgnoreCase)
            {
                { ".xlsx", new FileCategoryInfo("XLSX") },
                { ".docx", new FileCategoryInfo("DOCX") },
                { ".pptx", new FileCategoryInfo("PPTX") },
                { ".txt",  new FileCategoryInfo("TXT") },
                { ".jpg",  new FileCategoryInfo("JPG") }
            };

            CreateDirectories();
        }

        private void CreateDirectories()
        {
            foreach (var category in _fileCategories.Values)
            {
                string dirPath = Path.Combine(_sourceFolder, category.FolderName);
                if (!Directory.Exists(dirPath))
                {
                    Directory.CreateDirectory(dirPath);
                }
                category.TargetPath = dirPath;
            }
        }

        public void OrganizeFiles()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(_sourceFolder);

            foreach (FileInfo file in dirInfo.GetFiles())
            {
                try
                {
                    string ext = file.Extension.ToLower();

                    if (_fileCategories.ContainsKey(ext))
                    {
                        _totalFiles++;
                        _totalSize += file.Length;

                        var category = _fileCategories[ext];
                        category.Count++;
                        category.TotalSize += file.Length;

                        string destinationPath = Path.Combine(category.TargetPath, file.Name);

                        // Avoid overwriting files
                        if (File.Exists(destinationPath))
                        {
                            string uniqueName = Path.GetFileNameWithoutExtension(file.Name) +
                                                "_" + Guid.NewGuid().ToString().Substring(0, 4) +
                                                ext;
                            destinationPath = Path.Combine(category.TargetPath, uniqueName);
                        }

                        file.MoveTo(destinationPath);
                    }
                }
                catch (IOException ioEx)
                {
                    Console.WriteLine($"IO Error for file {file.Name}: {ioEx.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error processing file {file.Name}: {ex.Message}");
                }
            }
        }

        public void GenerateReport()
        {
            try
            {
                using StreamWriter sw = File.CreateText(_resultFile);

                sw.WriteLine("~~~~ Results ~~~~");
                sw.WriteLine($"Total Files: {_totalFiles}");
                sw.WriteLine($"Total Size: {_totalSize:N0} bytes");
                sw.WriteLine();

                foreach (var kv in _fileCategories)
                {
                    sw.WriteLine($"{kv.Value.FolderName} Count: {kv.Value.Count}");
                    sw.WriteLine($"{kv.Value.FolderName} Size: {kv.Value.TotalSize:N0} bytes");
                    sw.WriteLine();
                }
            }
            catch (IOException ioEx)
            {
                Console.WriteLine("Error writing report: " + ioEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error while writing report: " + ex.Message);
            }
        }
    }

    public class FileCategoryInfo
    {
        public string FolderName { get; }
        public string TargetPath { get; set; }
        public long Count { get; set; }
        public long TotalSize { get; set; }

        public FileCategoryInfo(string folderName)
        {
            FolderName = folderName;
            Count = 0;
            TotalSize = 0;
        }
    }

}
