using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculatorApp
{
    public class LbbtTaxCalc : ITaxCalc
    {
        public decimal GetTaxDue(ITaxType tax)
        {
            LbttTaxType lbtt = (LbttTaxType) tax;
            decimal valueLeftToConsider = lbtt.NewPropertyValue;
            decimal totalTax = 0;
            for(int i = 0; i < lbtt.Thresholds.From.Count; i++)
            {
                if (valueLeftToConsider <= 0)
                {
                    break;
                }
                decimal amountInRange = lbtt.Thresholds.UpToAndIncluding[i] - lbtt.Thresholds.From[i];
                if(valueLeftToConsider >= amountInRange)
                {
                    totalTax += (lbtt.Thresholds.Rate[i] * amountInRange);
                    valueLeftToConsider -= amountInRange;
                }
                else
                {
                    totalTax += (lbtt.Thresholds.Rate[i] * valueLeftToConsider);
                    valueLeftToConsider = 0;
                }
            }
            return Math.Round(totalTax, 2);
        }
    }
}
