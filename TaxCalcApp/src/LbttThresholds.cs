using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculatorApp
{
    public class LbttThresholds : IThresholds
    {
        public LbttThresholds()
        {
            this.SetThresholds();
        }
        public List<decimal> From { get; set; }
        public List<decimal> UpToAndIncluding { get; set; }
        public List<decimal> Rate { get; set; }

        public void SetThresholds()
        {
            // Based on current rates at https://revenue.scot/taxes/land-buildings-transaction-tax/residential-property
            From = new List<decimal>();
            UpToAndIncluding = new List<decimal>();
            Rate = new List<decimal>();
            //  Up to £145,000 - 0%
            From.Add(0);
            UpToAndIncluding.Add(145000);
            Rate.Add(0);
            //  Above £145,000 to £250,000 - 2%
            From.Add((decimal)145000.01);
            UpToAndIncluding.Add(250000);
            Rate.Add((decimal)0.02);
            //  Above £250,000 to £325,000 - 5%
            From.Add((decimal)250000.01);
            UpToAndIncluding.Add(325000);
            Rate.Add((decimal)0.05);
            //  Above £325,000 to £750,000 - 10%
            From.Add((decimal)325000.01);
            UpToAndIncluding.Add(750000);
            Rate.Add((decimal)0.1);
            //  Over £750,000 - 12%
            From.Add((decimal)325000.01);
            UpToAndIncluding.Add(Decimal.MaxValue);
            Rate.Add((decimal)0.12);
        }
    }
}
