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
            String quotesFile = @"quotes.txt";
            StreamReader streamReader = new StreamReader(quotesFile);
            //string[] values = null;
            int row = 0;

            while (!streamReader.EndOfStream)
            {
                string rowData = streamReader.ReadLine();

                if (rowData.Length > 0)
                {
                    string[] values = rowData.Split(',');
                    quotesGrid.Rows.Add();
                    //foreach (string value in values)
                    for (int i = 0; i < 8; i++)
                    {
                        quotesGrid[i,row].Value = values[i];
                        //quotesGrid[value, row].Value = values[value];
                    }
                    
                    row++;
                    
                }
                else
                {
                    MessageBox.Show("There are no quotes to show.");
                }
                
            }
        }
    }
}
