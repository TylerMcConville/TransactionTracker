using System.Collections.Generic;
using Data_Access.TransactionService;

namespace Application_Logic.Transaction
{
    public class TransactionLogic : ITransactionLogic
    {
        private readonly ITransactionDataAccess transactionDataAccess;

        public TransactionLogic(ITransactionDataAccess transactionDataAccess)
        {
            this.transactionDataAccess = transactionDataAccess;
        }

        public IList<Model.Transaction.Transaction> GetAllTransactions()
        {
            return transactionDataAccess.GetAllTransactions();
        }

        public void CreateTransaction(Model.Transaction.Transaction transaction)
        {
            transactionDataAccess.CreateTransaction(transaction);
        }
    }
}
