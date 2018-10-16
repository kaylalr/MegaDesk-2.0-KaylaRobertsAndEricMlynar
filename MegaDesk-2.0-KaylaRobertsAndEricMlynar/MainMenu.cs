using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_KaylaRoberts
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addQuoteBtn_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }

        private void viewAllQuotesBtn_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewQuotesForm = new ViewAllQuotes();
            viewQuotesForm.Tag = this;
            viewQuotesForm.Show(this);
            Hide();
        }

        private void searchQuotesBtn_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotesForm = new SearchQuotes();
            searchQuotesForm.Tag = this;
            searchQuotesForm.Show(this);
            Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
