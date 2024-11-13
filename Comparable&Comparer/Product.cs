using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparable_Comparer
{
    public class Product:IComparable
    {
        private string Pname;
        private int price;

        public Product(string Pname, int price)
        {
            this.Pname = Pname; 
            this.price = price;
        }
        public int Price
        { 
            get { return price; }
        }

        public int CompareTo(object obj)
        {
            Product p1=(Product)obj;

            if (this.price > p1.price)
            {
                return 1;
            }
            else if(this.price < p1.price)
            {
                return -1;
            }
            else
            {

                return 0;
                
            }
        }
    }
}
