using System.Collections.Generic;
using System.Linq;
using Model.Transaction;
using TransactionTracker.ViewModels;

namespace TransactionTracker.Extensions
{
    public static class TransactionExtensions
    {
        public static TransactionViewModel ToTransactionViewModel(this Transaction source)
        {
            return new TransactionViewModel
            {
                Amount = source.Amount,
                Description = source.Description,
                WasNecessary = source.WasNecessary,
                WasPlanned = source.WasPlanned
            };
        }

        public static IEnumerable<TransactionViewModel> ToTransactionViewModels(this IEnumerable<Transaction> source)
        {
            return source.Select(x => x.ToTransactionViewModel());
        }
    }
}