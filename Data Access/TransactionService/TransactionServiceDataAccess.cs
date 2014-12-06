using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Data_Access.TransactionService
{
    public class TransactionServiceDataAccess : ITransactionServiceDataAccess
    {
        public void TestTransaction()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Constants.TransactionServiceURI);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = client.GetAsync("api/transactions/0").Result;


                if (response.IsSuccessStatusCode)
                {
                    Object o = response.Content.ReadAsStringAsync().Result;
                }

                Console.WriteLine(response);
            }
        }
    }
}
