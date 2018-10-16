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
        const decimal RUSH_3DAY_LESS_THAN_2000 = 70.00M;
        const decimal RUSH_3DAY_GRATER_THAN_2000 = 80.00M;
        const decimal RUSH_5DAY_LESS_THAN_1000 = 40.00M;
        const decimal RUSH_5DAY_LESS_THAN_2000 = 50.00M;
        const decimal RUSH_5DAY_GREATER_THAN_1000 = 60.00M;
        const decimal RUSH_7DAY_LESS_THAN_1000 = 30.00M;
        const decimal RUSH_7DAY_LESS_THAN_2000 = 35.00M;
        const decimal RUSH_7DAY_GREATER_THAN_1000 = 40.00M;


        public int DeskQuoteID { get; set; }
        public DateTime QuoteDate { get; set; }
        public string CustomerName { get; set; }
        public Desk Desk { get; set; }
        public int Shipping { get; set; }
        public int Price { get; set; }

        public enum Delivery
        {
            Rush3Day,
            Rush5Day,
            Rush7Day,
            Normal14Day
        }

        public decimal GetQuote()
        {
            var surfaceArea = Desk.Width * Desk.Depth;
            var surfaceAreaPrice = 0;
            if (surfaceArea > 1000)
            {
                surfaceAreaPrice = surfaceArea;
            }
            // probably don't need this
            else
            {
                surfaceAreaPrice = 0;
            }
            var numOfDrawersPrice = Desk.NumOfDrawers * 50;

            var surfaceMaterialPrice = 0;
            switch (Desk.DeskMaterial)
            {
                case Desk.SurfaceMaterial.Oak:
                    surfaceMaterialPrice = 200;
                    break;
                case Desk.SurfaceMaterial.Laminate:
                    surfaceMaterialPrice = 100;
                    break;
                case Desk.SurfaceMaterial.Pine:
                    surfaceMaterialPrice = 50;
                    break;
                case Desk.SurfaceMaterial.Rosewood:
                    surfaceMaterialPrice = 300;
                    break;
                case Desk.SurfaceMaterial.Veneer:
                    surfaceMaterialPrice = 125;
                    break;
            }

            var shippingPrice = 0;
            switch (Shipping)
            {
                case 3:
                    if (surfaceArea < 1000)
                    {
                        shippingPrice = 60;
                    }
                    else if (surfaceArea < 2000)
                    {
                        shippingPrice = 70;
                    }
                    else
                    {
                        shippingPrice = 80;
                    }
                    break;
                case 5:
                    if (surfaceArea < 1000)
                    {
                        shippingPrice = 40;
                    }
                    else if (surfaceArea < 2000)
                    {
                        shippingPrice = 50;
                    }
                    else
                    {
                        shippingPrice = 60;
                    }
                    break;
                case 7:
                    if (surfaceArea < 1000)
                    {
                        shippingPrice = 30;
                    }
                    else if (surfaceArea < 2000)
                    {
                        shippingPrice = 35;
                    }
                    else
                    {
                        shippingPrice = 40;
                    }
                    break;
                default:
                    shippingPrice = 0;
                    break;
            }

            var totalPrice = 200 + surfaceAreaPrice + numOfDrawersPrice + surfaceMaterialPrice + shippingPrice;

            return totalPrice;
        }
    }
}
