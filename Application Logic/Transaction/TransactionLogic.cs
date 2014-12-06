using Data_Access.TransactionService;

namespace Application_Logic.Transaction
{
    public class TransactionLogic : ITransactionLogic
    {
        private readonly ITransactionServiceDataAccess transactionServiceDataAccess;

        public TransactionLogic(ITransactionServiceDataAccess transactionServiceDataAccess)
        {
            this.transactionServiceDataAccess = transactionServiceDataAccess;
        }

        public void TestTransaction()
        {
            transactionServiceDataAccess.TestTransaction();
        }
    }
}
