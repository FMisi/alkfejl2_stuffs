using System;
using CsvHelper.Configuration.Attributes;

namespace Stocks.Models
{
    public class Stock
    {
        public DateTime Date { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
        public long Volume { get; set; }

        // Default konstruktor
        public Stock() { }
    }
}