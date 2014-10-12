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
    public partial class CreateQuestion : Form
    {

        MainMenu mm = new MainMenu();
        Utility util = new Utility();


        public CreateQuestion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            mm.ShowDialog();
        }

        private void btn_addQuestion_Click(object sender, EventArgs e)
        {
         try
            {
            string qDescription;
            string corrAns;
            string incAlt1;
            string incAlt2;
            string incAlt3;
            string difficulty;
            string category;

            category = cb_category.SelectedItem.ToString();
            difficulty = cb_difficulty.SelectedItem.ToString();
            qDescription = tb_qDescription.Text;
            corrAns = tb_corrAns.Text;
            incAlt1 = tb_IncAlt1.Text;
            incAlt2 = tb_IncAlt2.Text;
            incAlt3 = tb_IncAlt3.Text;

                util.CreateQuestion(qDescription,corrAns,incAlt1,incAlt2,incAlt3, category, difficulty);
                this.Hide();
                this.Close();
                mm.ShowDialog();
            }
            catch (SqlException r)
            {
                MessageBox.Show("Error: " + r);
            }
            finally
            {
                Close();
            }
        }

    }
}
