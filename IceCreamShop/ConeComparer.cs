using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IceCreamShop
{
    class ConeComparer : IComparer<Cone>
    {
        public int Compare(Cone c, Cone d)
        {
            if (c.Cost > d.Cost)
            {
                return 1;
            }
            else if (c.Cost < d.Cost)
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
