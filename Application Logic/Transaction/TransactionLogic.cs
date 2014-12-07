using Data_Access.TransactionService;

namespace Application_Logic.Transaction
{
    public class TransactionLogic : ITransactionLogic
    {
        private readonly ITransactionDataAccess transactionServiceDataAccess;

        public TransactionLogic(ITransactionDataAccess transactionServiceDataAccess)
        {
            this.transactionServiceDataAccess = transactionServiceDataAccess;
        }

        public void TestTransaction()
        {
            transactionServiceDataAccess.TestTransaction();
        }
    }
}
