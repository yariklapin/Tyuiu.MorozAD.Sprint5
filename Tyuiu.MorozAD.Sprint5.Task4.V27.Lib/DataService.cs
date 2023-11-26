using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.MorozAD.Sprint5.Task4.V27.Lib
{
    public class DataService : ISprint5Task4V27
    {
        public double LoadFromDataFile(string path)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            double y = 0;

            string strX = File.ReadAllText(path);
            
            y = Math.Round((((Math.Pow(Convert.ToDouble(strX), 3))-4*Convert.ToDouble(strX))/(Math.Cos(Convert.ToDouble(strX)))),3);
            return y;
        }
    }
}
