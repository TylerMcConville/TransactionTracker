using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Script.Serialization;
using Model.Exceptions;
using Model.Transaction;

namespace Data_Access.TransactionService
{
    public class TransactionDataAccess : ITransactionDataAccess
    {
        public IEnumerable<Transaction> GetAllTransactions()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Constants.TransactionServiceURI);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = client.GetAsync("api/transactions/").Result;

                if (response.IsSuccessStatusCode == false)
                {
                    //TODO catch this in the presentation layer
                    throw new ReadTransactionsException();
                }

                var JSONResult = response.Content.ReadAsStringAsync().Result;
                var jsSerializer = new JavaScriptSerializer();
                var transactions = jsSerializer.Deserialize<List<Transaction>>(JSONResult);
                return transactions;
            }
        }
    }
}
