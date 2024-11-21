using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShabalinaYP.Sprint5.Task1.V15.Lib
{
    public class DataService : ISprint5Task1V15
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            double res;
            string strres;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x - 0.4 == 0)
                {
                    res = 0;
                }
                else
                {
                    res = (Math.Cos(x) / (x - 0.4) + Math.Sin(x) * 8 * x + 2);
                }
                res = Math.Round(res, 2);
                strres = Convert.ToString(res);
                if (x != stopValue)
                {
                    File.AppendAllText(path, strres + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strres);
                }

            }
            return path;
        }
    }
}
