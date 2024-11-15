api-manager-creditcard

Overview

This is an ASP.NET Web API project that contains single REST action that will validate credit card number using Luhn Algorithm.


Base URL

The base URL for API requests is -> http://localhost:55501/api/CreditCard

Content-Type: application/json

Expected Results: 

true (Credit Card number is valid)

false (Credit Card number is invalid)


Follow these steps to test locally:
1. Clone this repository
2. Build project
3. Run the project **Note: Just ignore the "Server Error in '/' Application" message, since this is only to enable the API
4. Open postman or any other API platforms
5. Change to POST and paste the base URL (http://localhost:55501/api/CreditCard)
6. Change Body to "raw" and set to JSON format
7. Click send


Refer to this site for card number testing -> https://docs.adyen.com/development-resources/testing/test-card-numbers/

Tools used for development:
1. Visual studio
2. Postman	

