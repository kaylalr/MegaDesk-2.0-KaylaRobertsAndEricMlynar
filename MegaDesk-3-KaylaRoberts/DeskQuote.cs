using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_KaylaRoberts
{
    public class DeskQuote
    {
        // constants
        const decimal BASE_DESK_PRICE = 200.00M;
        const decimal RUSH_3DAY_LESS_THAN_1000 = 60.00M;

        public int DeskQuoteID { get; set; }
        public DateTime QuoteDate { get; set; }
        public string CustomerName { get; set; }
        public Desk Desk { get; set; }
        public int Shipping { get; set; }
        public int Price { get; set; }
    }
    //public decimal GetQuote()
    //{
    //    //take this out when I do this
    //    return 100.00M;
    //}
}
