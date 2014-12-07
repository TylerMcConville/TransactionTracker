using Application_Logic.Transaction;
using Data_Access.TransactionService;
using Ninject.Modules;

namespace TransactionTracker
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<ITransactionLogic>().To<TransactionLogic>();
            Bind<ITransactionDataAccess>().To<TransactionDataAccess>();
        }
    }
}