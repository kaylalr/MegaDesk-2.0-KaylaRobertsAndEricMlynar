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
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void cancelQuoteBtn_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            //String quotesFile = @"quotes.txt";
            //StreamReader streamReader = new StreamReader(quotesFile);
            ////string[] values = null;
            //int row = 0;

            //while (!streamReader.EndOfStream)
            //{
            //    string rowData = streamReader.ReadLine();

            //    if (rowData.Length > 0)
            //    {
            //        string[] values = rowData.Split(',');
            //        quotesGrid.Rows.Add();
            //        //foreach (string value in values)
            //        for (int i = 0; i < 8; i++)
            //        {
            //            quotesGrid[i,row].Value = values[i];
            //            //quotesGrid[value, row].Value = values[value];
            //        }

            //        row++;

            //    }
            //    else
            //    {
            //        MessageBox.Show("There are no quotes to show.");
            //    }

            //}



            //// load existing quotes
            //string quotes = reader.ReadToEnd();
            //List<DeskQuotes> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuotes>>(quotes);

            //dataGridView1.DataSource = deskQuotes.Selected(d-> new
            //{
            //    Data = d.QuoteDate,
            //    Customer = d.CustomerName,
            //...
            //}).ToList();

            string quotesFile = @"quotes.json";

            using (StreamReader reader = new StreamReader(quotesFile)) {

                var quotes = reader.ReadToEnd();

                List<DeskQuote> allQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);

                //quotesGrid.AutoGenerateColumns = true;

                //var source = new BindingSource();
                ////source.DataSource = allQuotes;
                //source.Add(allQuotes);
                //source.ResetBindings(true);
                //quotesGrid.DataSource = source;

                // quotesGrid.DataSource = allQuotes;


                quotesGrid.DataSource = allQuotes.Select(d => new
                {
                    QuoteDate = d.QuoteDate,
                    CustomerName = d.CustomerName,
                    Width = d.Desk.Width,
                    Depth = d.Desk.Depth,
                    NumOfDrawers = d.Desk.NumOfDrawers,
                    DeskMaterial = d.Desk.DeskMaterial,
                    Shipping = d.Shipping,
                    Price = d.Price
                }).ToList();

            }
        }
    }
}
