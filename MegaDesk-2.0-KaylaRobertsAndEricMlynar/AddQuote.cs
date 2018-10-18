using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace MegaDesk_3_KaylaRoberts

{

    public partial class AddQuote : Form
    {

        public AddQuote()
        {
            InitializeComponent();
        }

        private void cancelQuoteBtn_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            var materials = new List<Desk.SurfaceMaterial>();

            materials = Enum.GetValues(typeof(Desk.SurfaceMaterial))
                .Cast<Desk.SurfaceMaterial>()
                .ToList();

            surfaceMaterialDropDown.DataSource = materials;
        }

        private void addQuoteBtn_Click(object sender, EventArgs e)
        {
            Desk desk = new Desk
            {
                Depth = (int)depthInput.Value,
                Width = (int)widthInput.Value,
                NumOfDrawers = (int)drawersInput.Value,
                DeskMaterial = (Desk.SurfaceMaterial)surfaceMaterialDropDown.SelectedValue
            };

            DeskQuote deskQuote = new DeskQuote();
            deskQuote.Desk = desk;
            /*
             *Normal (14 days)
            Rush (7 days)
            Rush (5 days)
            Rush (3 days)
             */
            var shippingChoice = shippingDropDown.SelectedValue;
            var shippingTime = 0;
            switch(shippingChoice)
            {
                case "Rush (7 days)":
                    shippingTime = 7;
                    break;
                case "Rush (5 days)":
                    shippingTime = 5;
                    break;
                case "Rush (3 days)":
                    shippingTime = 3;
                    break;
                default:
                    shippingTime = 14;
                    break;
            }
            
            deskQuote.CustomerName = custNameTxt.Text;
            deskQuote.Shipping = shippingTime;

            deskQuote.Price = (int)deskQuote.GetQuote();

            priceOfDeskLabel.Text = "Desk Price: " + deskQuote.Price;

            custNameTxt.Enabled = false;
            widthInput.Enabled = false;
            depthInput.Enabled = false;
            drawersInput.Enabled = false;
            surfaceMaterialDropDown.Enabled = false;
            shippingDropDown.Enabled = false;

            DateTime dateTime = DateTime.Now;
            var date = dateTime.ToString("MM/dd/yyyy HH:mm");


            //String quotesFile = @"quotes.txt";
            //using (StreamWriter streamWriter = File.AppendText(quotesFile))
            //{
            //    streamWriter.WriteLine
            //        (
            //        //Date, time, name, depth, width, numDrawers, material, shipping, somethingElse ?
            //        date + "," +
            //        deskQuote.CustomerName + "," +
            //        deskQuote.Desk.Width + "," +
            //        deskQuote.Desk.Depth + "," +
            //        deskQuote.Desk.NumOfDrawers + "," +
            //        deskQuote.Desk.DeskMaterial + "," +
            //        deskQuote.Shipping + "," +
            //        deskQuote.Price
            //        );
            //}
            //if (custNameTxt.Text == null)
            //{

            //}

            //List<DeskQuote> quotes = new List<DeskQuote>();
            //quotes.Add(new DeskQuote()
            //{
            //    CustomerName = deskQuote.CustomerName,
            //    Desk =
            //    {
            //        Width = deskQuote.Desk.Width,
            //        Depth = deskQuote.Desk.Depth,
            //        NumOfDrawers = deskQuote.Desk.NumOfDrawers,
            //        DeskMaterial = deskQuote.Desk.DeskMaterial
            //    },
            //    Shipping = deskQuote.Shipping,
            //    Price = deskQuote.Price
            //});

            SaveQuotes(deskQuote);
        }

        private void SaveQuotes(DeskQuote deskQuote)
        {
            var quotesFile = @"quotes.json";

            string jsonFile = JsonConvert.SerializeObject(deskQuote);

            System.IO.File.WriteAllText(quotesFile, jsonFile);
        }
    }
}