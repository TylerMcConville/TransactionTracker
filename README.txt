TransactionTracker - using Transaction Service (by Tyler McConville)



INSTRUCTIONS TO RUN:
1. Pull down/clone both TransactionTracker and TransactionService
2. Open the TransactionService solution in Visual Studio, and click "Run", "Debug", or "Attach"
2a. When the web service starts to run, your browser will probably give you an HTTP Error 403.14 - Forbidden. This is okay. 
3. Open the TransactionTracker solution in Visual Studio
4. Note the URI and port number that TransactionService is running on. For example "localhost:53604". 
5. In the TransactionTracker solution, open up Data_Access/Constants.cs and change the TransactionServiceURI property to match the value from step 4
6. Click "Run", "Debug", or "Attach"
7. The TransactionTracker homepage should open up in your browser


Future improvements:
-Catch exceptions in the presentation layer and add Error messages to the ModelState

-Add a "Date of transaction" field

-Make transaction creation an AJAX call

-Find a more visually appealing way to display the ugly checkboxes

-Make the "Create transaction" button use Bootstrap's button styling

-Remove the default header and footer

-Add the ability to sort and filter transactions

-Add a "Total" column that's the sum of all transaction amounts

-Add the ability to create recurring transactions (possibly using Daily/Weekly/Monthly SQL jobs? This will be interesting)

-Validate user input

-Look into using Dapper

-Remove spaces/underscores from project names. Not sure what I was thinking there

-Fix namespaces so I don't have to fully qualify class names (see TransactionLogic.cs - fully typing "Model.Transaction.Transaction" is silly)