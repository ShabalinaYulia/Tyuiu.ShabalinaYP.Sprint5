using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShabalinaYP.Sprint5.Task4.V18.Lib
{
    public class DataService : ISprint5Task4V18
    {
        public double LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);
            string strX = str.Replace(".", ",");
            double x = Convert.ToDouble(strX);
            double res = Math.Round(Math.Cos(x) + (Math.Pow(Convert.ToDouble(strX), 2)/2), 3);
            return res;
        }
    }
}
