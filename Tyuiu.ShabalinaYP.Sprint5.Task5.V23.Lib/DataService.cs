﻿using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.ShabalinaYP.Sprint5.Task5.V23.Lib
{
    public class DataService : ISprint5Task5V23
    {
        public double LoadFromDataFile(string path)
        {
            double min = 100;
            using (StreamReader reader = new StreamReader(path)) 
            {                
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Replace(".", ",");
                    string[] num = line.Split(' ');
                    foreach (string s in num)
                    {
                        double d = double.Parse(s);
                        if (d < min) min = d;
                    }
                }
            }
            return Math.Round(min, 3);
        }
    }
}
