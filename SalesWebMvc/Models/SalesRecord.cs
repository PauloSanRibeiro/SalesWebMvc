using SalesWebMvc.Models.Enums;
using System;


namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Satatus { get; set; }

        //SalesRecord Possui um vendedor (Saller
        public SalesRecord Seller { get; set; }
        
        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus satatus, SalesRecord seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Satatus = satatus;
            Seller = seller;
        }
    }
}
