using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MegaDesk_3_KaylaRoberts
{
    public class DeskQuote
    { 

        // constants
        const int BASE_DESK_PRICE = 200;
        const int RUSH_3DAY_LESS_THAN_1000 = 60;
        const int RUSH_3DAY_LESS_THAN_2000 = 70;
        const int RUSH_3DAY_GREATER_THAN_2000 = 80;
        const int RUSH_5DAY_LESS_THAN_1000 = 40;
        const int RUSH_5DAY_LESS_THAN_2000 = 50;
        const int RUSH_5DAY_GREATER_THAN_1000 = 60;
        const int RUSH_7DAY_LESS_THAN_1000 = 30;
        const int RUSH_7DAY_LESS_THAN_2000 = 35;
        const int RUSH_7DAY_GREATER_THAN_1000 = 40;


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

            getRushOrder(@"rushOrderPrices.txt");

            var shippingPrice = 0;
            switch (Shipping)
            {
                case 3:
                    if (surfaceArea < 1000)
                    {
                        shippingPrice = RUSH_3DAY_LESS_THAN_1000;
                    }
                    else if (surfaceArea < 2000)
                    {
                        shippingPrice = RUSH_3DAY_LESS_THAN_2000;
                    }
                    else
                    {
                        shippingPrice = RUSH_3DAY_GREATER_THAN_2000;
                    }
                    break;
                case 5:
                    if (surfaceArea < 1000)
                    {
                        shippingPrice = RUSH_5DAY_LESS_THAN_1000;
                    }
                    else if (surfaceArea < 2000)
                    {
                        shippingPrice = RUSH_5DAY_LESS_THAN_2000;
                    }
                    else
                    {
                        shippingPrice = RUSH_5DAY_GREATER_THAN_1000;
                    }
                    break;
                case 7:
                    if (surfaceArea < 1000)
                    {
                        shippingPrice = RUSH_7DAY_LESS_THAN_1000;
                    }
                    else if (surfaceArea < 2000)
                    {
                        shippingPrice = RUSH_7DAY_LESS_THAN_2000;
                    }
                    else
                    {
                        shippingPrice = RUSH_7DAY_GREATER_THAN_1000;
                    }
                    break;
                default:
                    shippingPrice = 0;
                    break;
            }

            var totalPrice = 200 + surfaceAreaPrice + numOfDrawersPrice + surfaceMaterialPrice + shippingPrice;

            return totalPrice;
        }

        private void getRushOrder(string v)
        {
            String[] shippingArray = File.ReadAllLines(v);

            String[ , ] prices = new String[3,3];

            int k = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    prices[i,j] = shippingArray[k];
                    k++;
                }
            }
        }
    }
}
