using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9
{
    class cTax
    {
        public double item1;
        public double mcTax_Rate = 0.65;
        
        public double GetAmount()
        {
            return item1;
        }

        public Double cFindTax(double cAmount)
        {
            double FindTax = cAmount - (cAmount * mcTax_Rate);
            return FindTax;

        }

    }
}
