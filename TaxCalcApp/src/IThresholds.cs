using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculatorApp
{
    public interface IThresholds
    {
        public void SetThresholds();

        // For any given index in 'From', 'UpToAndIncluding and Rate', 'From' represents the start of the threshold, 'UpToAndIncluding' represents its end
        // and 'Rate' represents the tariff that applies to that range of values. For example, if From[1] equals 100,000.00 and UpToAndIncluding[1] equals 200,000
        // and Rate[1] equals 0.06, that means that there is a tariff of 6% for £100,000.01 to £200,000.
        //
        // NB Rate bands need to be added to the lists in order of lowest to highest.
        public List<decimal> From { get; set; }
        public List<decimal> UpToAndIncluding { get; set; }
        public List<decimal> Rate { get; set; }
    }
}
