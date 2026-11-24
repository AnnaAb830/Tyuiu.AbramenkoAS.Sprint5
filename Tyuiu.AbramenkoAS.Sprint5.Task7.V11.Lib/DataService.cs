using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AbramenkoAS.Sprint5.Task7.V11.Lib
{
    public class DataService : ISprint5Task7V11
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V11.txt");
            if (File.Exists(pathSaveFile))
            {
                File.Delete(pathSaveFile);
            }

            string content = File.ReadAllText(path);
            string newContent = "";

            foreach (char c in content)
            {

                bool isSpace = (c == ' ');
                bool isLowerRussian = (c >= 'а' && c <= 'я') || c == 'ё';

                if (!isSpace && !isLowerRussian)
                {
                    newContent += c;
                }
            }

            File.WriteAllText(pathSaveFile, newContent);

            return pathSaveFile;
        }
    }
}
