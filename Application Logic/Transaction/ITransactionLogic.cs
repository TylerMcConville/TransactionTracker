using System.Collections.Generic;

namespace Application_Logic.Transaction
{
    public interface ITransactionLogic
    {
        IEnumerable<Model.Transaction.Transaction> GetAllTransactions();
    }
}
