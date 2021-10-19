using System;
using Xunit;
using TaxCalculatorApp;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestGetTaxDueMethod()
        {
            // Expected figures calculated manually and checked against https://revenue.scot/calculate-tax/calculate-property-transactions#calculator
            LbttTaxType lbbt = (LbttTaxType)TaxTypeObjectFactory.GetObject(TypeOfTaxEnums.LBTT);
            LbbtTaxCalc taxCalc = new LbbtTaxCalc();
            lbbt.NewPropertyValue = 0;
            Assert.Equal(0, taxCalc.GetTaxDue(lbbt));
            lbbt.NewPropertyValue = -1;
            Assert.Equal(0, taxCalc.GetTaxDue(lbbt));
            lbbt.NewPropertyValue = 145000; // Tax is 0 % <= 145000
            Assert.Equal(0, taxCalc.GetTaxDue(lbbt));
            lbbt.NewPropertyValue = 146000;
            Assert.Equal(20, taxCalc.GetTaxDue(lbbt));
            lbbt.NewPropertyValue = (decimal)199999.99;
            Assert.Equal(1100, taxCalc.GetTaxDue(lbbt));
            lbbt.NewPropertyValue = 350000;
            Assert.Equal(8350, taxCalc.GetTaxDue(lbbt));
            lbbt.NewPropertyValue = 800000;
            Assert.Equal(54350, taxCalc.GetTaxDue(lbbt));
        }
    }
}
