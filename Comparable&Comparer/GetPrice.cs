using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparable_Comparer
{
    public class GetPrice : IComparer
    {
        public int Compare(object x, object y)
        {
            Product p1=(Product)x;
            Product p2=(Product)y;

            if(p1.Price>p2.Price)
            {
                return 1;

            }
            else if(p1.Price <p2.Price)
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
