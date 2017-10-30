using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationLibrary
{
    public class ValidateCreditCardNumber
    {
        public bool Validate(string creditCardNumber)
        { 
            if (string.IsNullOrWhiteSpace(creditCardNumber))
                return false;

            var total = 0;
            var creditCardLenght = creditCardNumber.Length;

            //operation that starts from first number and escapes the following number
            for (var i = 0; i < creditCardLenght; i += 2)
            {
                //double digits by escaping one starting form the first number
                var doubled = Convert.ToInt32(creditCardNumber.Substring(i, 1)) * 2;

                // if the product is less than 10, add it to the total otherwise split the two digits and add them 
                if (doubled < 10)
                {
                    total += doubled;
                }
                else
                {
                    var doubleDigit = doubled.ToString();
                    total += doubleDigit.Select((t, j) => Convert.ToInt32(doubleDigit.Substring(j, 1))).Sum();
                }
            }

            //operation that starts from second number and escapes the following number
            for (var i = 1; i < creditCardLenght; i += 2)
            {
                total += Convert.ToInt32(creditCardNumber.Substring(i, 1));

            }

            return total % 10 == 0;

        }
    }
}
