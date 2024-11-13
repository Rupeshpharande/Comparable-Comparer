using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Comparable_Comparer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1=new Product("fan",2500);
            Product p2 = new Product("Table", 4000);

            //int result=p1.CompareTo(p2);

            GetPrice getPrice = new GetPrice();
            int result=getPrice.Compare(p1,p2);

            if (result == 1)
            {
                Console.WriteLine("p1 has more price than p2");
            }
            else if (result == -1)
            {
                Console.WriteLine("p2 has more price than p1");
            }
            else
            {
                Console.WriteLine("both price is same");
            }
        }
    }
}
