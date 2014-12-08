using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
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
                SetHttpClientParameters(client);

                var response = client.GetAsync("api/transactions/").Result;

                if (response.IsSuccessStatusCode == false)
                {
                    //TODO catch this in the presentation layer
                    throw new ReadTransactionsException();
                }

                return response.Content.ReadAsAsync<IEnumerable<Transaction>>().Result;
            }
        }

        public void CreateTransaction(Transaction transaction)
        {
            using (var client = new HttpClient())
            {
                SetHttpClientParameters(client);

                var response = client.PostAsJsonAsync("api/transactions/", transaction).Result;

                if (response.IsSuccessStatusCode == false)
                {
                    //TODO catch this in the presentation layer
                    throw new CreateTransactionException();
                }
            }
        }

        private static void SetHttpClientParameters(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri(Constants.TransactionServiceURI);
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));   
        }
    }
}
