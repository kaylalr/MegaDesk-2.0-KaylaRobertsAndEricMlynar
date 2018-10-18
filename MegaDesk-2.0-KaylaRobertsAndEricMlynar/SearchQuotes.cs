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

namespace MegaDesk_3_KaylaRoberts
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void cancelQuoteBtn_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            var materials = new List<Desk.SurfaceMaterial>();

            materials = Enum.GetValues(typeof(Desk.SurfaceMaterial))
                .Cast<Desk.SurfaceMaterial>()
                .ToList();

            surfaceMaterialDropDown.DataSource = materials;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            //var materials = new List<Desk.SurfaceMaterial>();

            //materials = Enum.GetValues(typeof(Desk.SurfaceMaterial))
            //    .Cast<Desk.SurfaceMaterial>()
            //    .ToList();

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


            //        for (int i = 0; i < materials.Count(); i++)
            //        {
            //            if (values[5] == materials.ElementAt(i).ToString())
            //            {
            //                quotesGrid.Rows.Add();
            //                for (int j = 0; j < 8; j++)
            //                {
            //                    quotesGrid[j, row].Value = values[j];
            //                    //quotesGrid[value, row].Value = values[value];
            //                }

            //                row++;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("There are no quotes to show.");
            //    }
            //}

            //String quotesFile = @"quotes.txt";
            //StreamReader streamReader = new StreamReader(quotesFile);
            ////string[] values = null;
            //int row = 0;

            //quotesGrid.Rows.Clear();

            //while (!streamReader.EndOfStream)
            //{
            //    string rowData = streamReader.ReadLine();

            //    if (rowData.Length > 0)
            //    {
            //        string[] values = rowData.Split(',');

            //        //foreach (string value in values)

            //        if (values[5] == surfaceMaterialDropDown.SelectedValue.ToString())
            //        {
            //            quotesGrid.Rows.Add();
            //            for (int i = 0; i < 8; i++)
            //            {
            //                quotesGrid[i, row].Value = values[i];
            //                //quotesGrid[value, row].Value = values[value];
            //            }

            //            row++;
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("There are no quotes to show.");
            //    }

            string quotesFile = @"quotes.json";

            using (StreamReader reader = new StreamReader(quotesFile))
            {

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
                })
                //.Where(surfaceMaterialDropDown.SelectedValue == )
                .ToList();

            }
        }
    }
}
