using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuizGame
{
    public partial class LeaderBoard : Form
    {

        public LeaderBoard()
        {
            InitializeComponent();
        }


        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            this.Hide();
            mm.ShowDialog();
            this.Close();
        }

        private void LeaderBoard_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sYSA14DataSet.Results' table. You can move, or remove it, as needed.
            this.resultsTableAdapter.Fill(this.sYSA14DataSet.Results);

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.resultsTableAdapter.FillBy1(this.sYSA14DataSet.Results);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.resultsTableAdapter.FillBy1(this.sYSA14DataSet.Results);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.resultsTableAdapter.FillBy1(this.sYSA14DataSet.Results);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
