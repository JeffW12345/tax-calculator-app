using System;

namespace TaxCalculatorApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            TaxTypeObjectFactory.GetObject(TypeOfTaxEnums.LBTT).SummariseResults((decimal)199999.99); // The property value is passed into the SummariseResults method.
        }
    }
}
