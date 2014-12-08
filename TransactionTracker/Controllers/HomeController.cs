using System.Web.Mvc;
using Application_Logic.Transaction;
using TransactionTracker.Extensions;
using TransactionTracker.ViewModels;

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

        public ActionResult CreateTransaction(TransactionViewModel transactionViewModel)
        {
            transactionLogic.CreateTransaction(transactionViewModel.ToTransaction());
            return RedirectToAction("Index");
        }
    }
}