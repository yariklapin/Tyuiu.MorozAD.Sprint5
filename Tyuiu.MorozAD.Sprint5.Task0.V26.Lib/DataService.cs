﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MorozAD.Sprint5.Task0.V26.Lib
{
    public class DataService : ISprint5Task0V26
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";

            double y = 2;

            y = 0.7 * Math.Pow(y, 3) + 1.52 * Math.Pow(y, 2);

            y = Math.Round(y, 3);
            File.WriteAllText(path, Convert.ToString(y));

            return path; 

        }
    }
}
