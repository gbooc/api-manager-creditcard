using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace api_manager_creditcard.Controllers
{
    public class CreditCardController : ApiController
    {
        public HttpResponseMessage Post([FromBody] string creditcardnumber)
        {
            creditcardnumber = creditcardnumber.Replace(" ", string.Empty); // Remove spaces

            //Return false if empty
            if (String.IsNullOrEmpty(creditcardnumber) || creditcardnumber.Length < 15)
                return Request.CreateResponse(HttpStatusCode.Created, false);

            //Start of luhn algorithm implementation
            bool alternate = false;
            int sum = 0;

            // Loop through the digits in reverse order
            for (int i = creditcardnumber.Length - 1; i >= 0; i--)
            {
                if (!char.IsDigit(creditcardnumber[i]))
                    return Request.CreateResponse(HttpStatusCode.Created, false); ; // Return false if non numeric char found

                int digit = creditcardnumber[i] - '0'; // Convert the char to an integer

                if (alternate)
                {
                    // Double every other digit
                    digit *= 2;
                    if (digit > 9)
                        digit -= 9; // Subtract 9 if the doubled value is greater than 9
                }
                sum += digit;
                alternate = !alternate; // Toggle alternate flag
            }

            // If the sum is divisible by 10, the number is valid
            return Request.CreateResponse(HttpStatusCode.Created, (sum % 10 == 0 ? true : false));

        }
    }
}