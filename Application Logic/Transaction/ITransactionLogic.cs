using System.Collections.Generic;

namespace Application_Logic.Transaction
{
    public interface ITransactionLogic
    {
        IList<Model.Transaction.Transaction> GetAllTransactions();
        void CreateTransaction(Model.Transaction.Transaction toTransaction);
    }
}
