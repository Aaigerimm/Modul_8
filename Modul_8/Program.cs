using Modul_8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_8
{
    internal class Program
    {
        private static readonly object forecast;

        public class RangeofArray
        {
            int[] array = null;
            public RangeofArray()
            {
                array = new int[10];
                Random random = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(0, 20);
                }
            }
            public int this[int index]
            {
                get
                {
                    if (index > 0 || index < array.Length)
                    {
                        return array[index - 1];
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
            public override string ToString()
            {
                string result = " ";
                for (int i = 0; i < array.Length; i++)
                {
                    result += array[i] + " ";
                }
                return result;
            }
        }
        static void Main(string[] args)
        {
            //RangeofArray rangeofArray = new RangeofArray();
            //Console.WriteLine(rangeofArray);
            //Console.WriteLine(rangeofArray[0]);
            //Console.WriteLine(rangeofArray[2]);
            //Console.WriteLine(rangeofArray[3]);
            //Console.WriteLine(rangeofArray[11]);




            //SuperMarket supermarket = new SuperMarket();
            //    Console.WriteLine("Сумма всех продуктов: {0} ",
            //        superarket[1]);
            //Console.ReadKey();



            Month month = new Month();

            Console.WriteLine($" Продажа за месяц {month}: {forecast:F2}");

            Console.ReadKey();


        }
    }

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public double Discount { get; set; }

        public int Category { get; set; }

    }
}