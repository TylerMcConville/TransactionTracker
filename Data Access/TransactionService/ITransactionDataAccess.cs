using System.Collections.Generic;
using Model.Transaction;

namespace Data_Access.TransactionService
{
    public interface ITransactionDataAccess
    {
        IEnumerable<Transaction> GetAllTransactions();
    }
}
