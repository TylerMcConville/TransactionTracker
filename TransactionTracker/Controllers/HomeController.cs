using System.Web.Mvc;
using Application_Logic.Transaction;
using Ninject;

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
            transactionLogic.TestTransaction();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}