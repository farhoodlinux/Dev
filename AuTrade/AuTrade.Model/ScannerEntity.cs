using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuTrade.Model
{
    public class ScannerEntity
    {
        public int? ScannerId { get; set; }
        public string ScannerName { get; set; }
        public int? ScanCode { get; set; }
        public int? InstrumentType { get; set; }
        public string LocationType { get; set; }
        public int? StockTypeFilter { get; set; }
        public int? MinPrice { get; set; }
        public int? MaxPrice { get; set; }
        public int? MarketCapAbove { get; set; }
        public int? MarketCapBelow { get; set; }
        public bool Enabled { get; set; }

    }
}
