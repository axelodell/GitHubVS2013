using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame
{
    public partial class CreateUser : Form
    {
        Utility utility = new Utility();
        NewGame ng = new NewGame();
        public CreateUser()
        {
            InitializeComponent();
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
            try
            {
                string userName;
                userName = tb_username.Text;
                MessageBox.Show(utility.RegisterPlayer(userName));
                this.Hide();
                this.Close();
                ng.ShowDialog();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            ng.ShowDialog();
        }
    }
}
