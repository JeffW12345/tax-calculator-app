using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculatorApp
{
    public interface ITaxType
    {
        IThresholds Thresholds { get; set; }
        public void SummariseResults(decimal amount);
    }
}
