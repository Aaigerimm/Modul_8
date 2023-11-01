using Modul_8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_8
{
    public class Supermarket
    {
        List<Product> products = null;
        public Supermarket()
        {
            products = new List<Product>();
            products.Add(new Product { Price = 1000, Category = 1 });
            products.Add(new Product { Price = 2000, Category = 1 });


        }
        public double this[int category]
        {
            get
            {
                TimeSpan startTime = new TimeSpan(8, 0, 0);
                TimeSpan endTime = new TimeSpan(12, 0, 0);
                var t = DateTime.Now.TimeOfDay;
                double sum = 0;
                foreach (Product item in products)
                {
                    sum += item.Price;

                }
                if (t > startTime && t < endTime)
                {
                    return sum * 0.95;
                }
                else
                {
                    return sum;
                }
            }
        }
    }
}

