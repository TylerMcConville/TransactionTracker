using System.Collections.Generic;
using System.Linq;
using Data_Access.DataHelpers;
using Transaction = Model.Transaction.Transaction;

namespace Data_Access.TransactionService
{
    public class TransactionDataAccess : ITransactionDataAccess
    {
        public IList<Transaction> GetAllTransactions()
        {
            using (var context = new TransactionTrackerDataContext())
            {
                return context.Transactions.Select(x => new Transaction
                {
                    Amount = x.Amount,
                    Description = x.Description,
                    WasNecessary = x.WasNecessary,
                    WasPlanned = x.WasPlanned
                }).ToList();
            }
        }

        public void CreateTransaction(Transaction transaction)
        {
            using (var context = new TransactionTrackerDataContext())
            {
                context.Transactions.InsertOnSubmit(new DataHelpers.Transaction
                {
                    Amount = transaction.Amount,
                    Description = transaction.Description,
                    WasNecessary = transaction.WasNecessary,
                    WasPlanned = transaction.WasPlanned
                });

                context.SubmitChanges();
            }
        }
    }
}
