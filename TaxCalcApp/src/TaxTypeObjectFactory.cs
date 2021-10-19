using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculatorApp
{
    public class TaxTypeObjectFactory
    {
        // Creates a new object of reference type ITaxType, with an object of reference type Threshold object passed into the constructor.
        public static ITaxType GetObject(TypeOfTaxEnums typeOfTax)
        {
            if(typeOfTax == TypeOfTaxEnums.LBTT)
            {
                return new LbttTaxType(new LbttThresholds());
            }
            throw new Exception("There is a TypeOfTax enum missing from the method - debugging required.");
        }
    }
}
