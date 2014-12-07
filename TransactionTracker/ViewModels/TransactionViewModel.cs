namespace TransactionTracker.ViewModels
{
    public class TransactionViewModel
    {
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public bool WasPlanned { get; set; }
        public bool WasNecessary { get; set; }
    }
}