using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MorozAD.Sprint5.Task7.V6.Lib
{
    public class DataService : ISprint5Task7V6
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V6 .txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    foreach (char str in line)
                    {
                        if (Char.IsPunctuation(str))
                        {
                            line = line.Replace(str, '#');
                        }

                    }
                    File.AppendAllText(pathSaveFile, line + Environment.NewLine);
                    line = "";
                }
                return pathSaveFile;

            }
        }
    }
}
