using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculatorApp
{
    public interface ITaxCalc
    {
        public decimal GetTaxDue(ITaxType tax);
    }
}
