using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShabalinaYP.Sprint5.Task2.V22.Lib
{
    public class DataService : ISprint5Task2V22
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            matrix = new int[3, 3];
            string res = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] >= 0)
                    {
                        matrix[i, j] = 1;
                    }
                    if (matrix[i, j] <= 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns-1)
                    {
                        res = res + matrix[i, j] + ";";
                    }
                    else 
                    {
                        res = res + matrix[i, j];
                    }
                }
                if (i != rows-1)
                {
                    File.AppendAllText(path, res + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, res);
                }
                res = "";
            }

            return path;

        }
    }
}
