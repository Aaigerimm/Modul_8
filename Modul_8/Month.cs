using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_8
{
    internal class Month
    {
        static void Main(string[] args)
        {
            double forecast;

            double[] months = { 1, 2, 3, 4, 5 };
            double[] sales = { 5, 10, 15, 20, 25 };

            int n = months.Length;

            double sumM = 0, sumS = 0, sumMSales = 0, sumMSquared = 0;
            for (int i = 0; i < n; i++)
            {
                sumM += months[i];
                sumS += sales[i];
                sumMSales += months[i] * sales[i];
                sumMSquared += months[i] * months[i];
            }

            double a = (n * sumMSales - sumM * sumS) / (n * sumMSquared - sumM * sumM);
            double b = (sumS - a * sumM) / n;

            for (int month = 6; month <= 8; month++)
            {
                forecast = a * month + b;
            }



            Console.ReadLine();
        }
    }
}
