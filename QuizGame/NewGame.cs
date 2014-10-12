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
            try
            {
                this.playerTableAdapter.Fill(this.sYSA14DataSet.Player);
            }
            catch (Exception)
            {
                
                throw;
            }           
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
                bool culture = cb_Culture.Checked;
                bool sport = cb_Sport.Checked;
                bool entertainment = cb_Entertainment.Checked;
                bool geography = cb_Geography.Checked;
                bool history = cb_History.Checked;
                bool technology = cb_Technology.Checked;
                bool nature = cb_Nature.Checked;
                List<string> categoryList = util.CreateCategoryList(culture, sport, entertainment, geography, technology, nature, history);

                int questions = cb_nrOfQuestions.SelectedIndex;                            
                string username = cb_username.Text;
                //util.NewGame(questions, username);
                util.NewGame(questions, username, categoryList);  // Axels shiet
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
