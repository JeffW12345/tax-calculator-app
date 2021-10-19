using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculatorApp
{
    public class LbttTaxType : ITaxType
    {
        public IThresholds Thresholds { get; set; }
        public decimal NewPropertyValue { get; set; }
        public LbttTaxType(IThresholds thresholds)
        {
            Thresholds = thresholds;
        }
        public void SummariseResults(decimal propertyValue)
        {
            if(propertyValue <= 0)
            {
                throw new Exception("Invalid property value");
            }
            LbbtTaxCalc taxCalc = new LbbtTaxCalc();
            this.NewPropertyValue = propertyValue;
            Console.WriteLine("Property value: " + string.Format("£{0}", this.NewPropertyValue.ToString()));
            Console.WriteLine("Total LBBT tax due: " + string.Format("£{0}", taxCalc.GetTaxDue(this).ToString()));
        }
    }
}
