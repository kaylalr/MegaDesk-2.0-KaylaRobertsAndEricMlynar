using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_KaylaRoberts
{
    public class DeskQuote
    {
        public int DeskQuoteID { get; set; }
        public DateTime QuoteDate { get; set; }
        public string CustomerName { get; set; }
        public Desk Desk { get; set; }
        public int Shipping { get; set; }
        public int Price { get; set; }
    }
}
