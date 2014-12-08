using Model.Transaction;

namespace TransactionTracker.ViewModels
{
    public class TransactionViewModel
    {
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public bool WasPlanned { get; set; }
        public bool WasNecessary { get; set; }

        public Transaction ToTransaction()
        {
            return new Transaction
            {
                Amount = Amount,
                Description = Description,
                WasNecessary = WasNecessary,
                WasPlanned = WasPlanned
            };
        }
    }
}