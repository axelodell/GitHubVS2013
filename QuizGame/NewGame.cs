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
    public partial class NewGame : Form
    {
        Utility util = new Utility();

        // Constructor below.
        public NewGame()
        {
            InitializeComponent();
        }

        public void NewGame_Load(object sender, EventArgs e)
        {
            this.playerTableAdapter.Fill(this.sYSA14DataSet.Player);           
        }

        private void btn_createNewUser_Click(object sender, EventArgs e)
        {
            try
            {
                CreateUser cu = new CreateUser();
                this.Hide();
                cu.ShowDialog();
                this.Close();
            }
            catch (Exception r)
            {
                MessageBox.Show("Error: " + r);
            }
            finally
            {
                Close();
            }
        }

        private void btn_startNewGame_Click(object sender, EventArgs e)
        {            
            try
            {
                //string culture = cb_Culture.Text;
                //string sport = cb_Sport.Text;
                //string entertainment = cb_Entertainment.Text;
                //string geography = cb_Geography.Text;
                //string history = cb_History.Text;
                //string technology = cb_Technology.Text;
                //string nature = cb_Nature.Text;
                //List<string> categoryList = util.CreateCategoryList(culture,sport,entertainment,geography,technology,nature,history);

                int questions = cb_nrOfQuestions.SelectedIndex;                            
                string username = cb_username.Text;
                util.NewGame(questions, username);
                //util.NewGame(questions, username, categoryList);   Axels shiet
                QuestionFrame qf = new QuestionFrame();
                Hide();
                qf.ShowDialog();
                
            }
            catch (SqlException r)
            {
                MessageBox.Show("Error when creating a new game: " + r);
            }
            finally
            {
                Close();
            }
        }

        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            try
            {
                MainMenu mm = new MainMenu();
                this.Hide();
                mm.ShowDialog();
                this.Close();
            }
            catch (Exception r)
            {
                MessageBox.Show("Error: " + r);
            }
            finally
            {
                Close();
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
