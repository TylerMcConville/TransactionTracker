using System.Web.Mvc;
using Application_Logic.Transaction;
using TransactionTracker.Extensions;

namespace TransactionTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITransactionLogic transactionLogic;

        public HomeController(ITransactionLogic transactionLogic)
        {
            this.transactionLogic = transactionLogic;
        }

        public ActionResult Index()
        {
            var transactions = transactionLogic.GetAllTransactions();
            return View(transactions.ToTransactionViewModels());
        }
    }
}