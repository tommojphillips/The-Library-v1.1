using System;
using System.Windows.Forms;
using TM_Db_Lib.Media;
using TM_Db_Lib.Search;

namespace YTS_Search_Test
{
    public partial class Form1 : Form
    {
        // Written, 14.09.2020

        private MovieSearchResult selectedResult = null;
        private MovieSearchResult[] searchResults = null;

        public Form1()
        {
            // Written, 14.09.2020

            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Written, 14.09.2020

            this.searchResults = await MovieSearchResult.searchAsync(this.textBox1.Text, 1);
            this.populateListBoxWithMovieSearchResults(this.searchResults);
        }

        private void populateListBoxWithMovieSearchResults(MovieSearchResult[] inResults) 
        {
            // Written, 14.09.2020
            if (inResults.Length < 1)
            {
                this.listBox1.Items.Add("No results to show");
                return;
            }
            foreach (MovieSearchResult item in inResults)
            {
                this.listBox1.Items.Add(String.Format("({1}) - {0} [{2}]", item.name, item.id, item.release_date));
            }
            if (inResults.Length < 1) 
                this.listBox1.Items.Add("No results to show");
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedResult = this.searchResults[this.listBox1.SelectedIndex];
        }
    }
}
