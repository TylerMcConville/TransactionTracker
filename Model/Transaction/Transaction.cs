﻿namespace Model.Transaction
{
    public class Transaction
    {
        //TODO add a TransactionDate property
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public bool WasPlanned { get; set; }
        public bool WasNecessary { get; set; }
    }
}
