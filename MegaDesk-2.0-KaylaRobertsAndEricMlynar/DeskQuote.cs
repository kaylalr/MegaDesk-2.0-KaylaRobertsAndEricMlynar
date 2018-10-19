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
        public int DeskQuoteID { get; set; }
        public DateTime QuoteDate { get; set; }
        public string CustomerName { get; set; }
        public Desk Desk { get; set; }
        public int Shipping { get; set; }
        public int Price { get; set; }

        public enum Delivery
        {
            Rush_3_Day,
            Rush_5_Day,
            Rush_7_Day,
            Normal_14_Day
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

            int[ , ] rushOrderArray = getRushOrder(@"rushOrderPrices.txt");

            const int BASE_DESK_PRICE = 200;
            int RUSH_3DAY_LESS_THAN_1000 = rushOrderArray[0,0];
            int RUSH_3DAY_LESS_THAN_2000 = rushOrderArray[0,1];
            int RUSH_3DAY_GREATER_THAN_2000 = rushOrderArray[0, 2];
            int RUSH_5DAY_LESS_THAN_1000 = rushOrderArray[1, 0];
            int RUSH_5DAY_LESS_THAN_2000 = rushOrderArray[1, 1];
            int RUSH_5DAY_GREATER_THAN_1000 = rushOrderArray[1, 2];
            int RUSH_7DAY_LESS_THAN_1000 = rushOrderArray[2, 0];
            int RUSH_7DAY_LESS_THAN_2000 = rushOrderArray[2, 1];
            int RUSH_7DAY_GREATER_THAN_1000 = rushOrderArray[2, 2];

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

        private int[ , ] getRushOrder(string v)
        {
            String[] shippingArray = File.ReadAllLines(v);

            int[ , ] prices = new int[3,3];

            int k = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    prices[i,j] = Int32.Parse(shippingArray[k]);
                    k++;
                }
            }

            return prices;
        }
    }
}
