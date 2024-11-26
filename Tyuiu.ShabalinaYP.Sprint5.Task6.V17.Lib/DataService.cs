﻿using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShabalinaYP.Sprint5.Task6.V17.Lib
{
    public class DataService : ISprint5Task6V17
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < (line.Length-1); i++)
                    {
                        if ((line[i] == line[i + 1]) && (line[i] == ' '))
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
