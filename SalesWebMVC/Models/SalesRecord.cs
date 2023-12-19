using SalesWebMVC.Models.Enums;
using System;

namespace SalesWebMVC.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amounnt { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Saller { get; set; }

        public SalesRecord() 
        {
        }

        public SalesRecord(int id, DateTime date, double amounnt, SaleStatus status, Seller saller)
        {
            Id = id;
            Date = date;
            Amounnt = amounnt;
            Status = status;
            Saller = saller;
        }
    }
}
