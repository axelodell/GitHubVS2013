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
using System.Diagnostics;

namespace QuizGame
{
    
    public partial class QuestionFrame : Form
    {
        Stopwatch startq = new Stopwatch();
        
        Utility util = new Utility();
        LeaderBoard lb = new LeaderBoard();
        NewGame ng = new NewGame();
        int i = 0;        
        public QuestionFrame()
        {
            InitializeComponent();
        }

        public void QuestionFrame_Load(object sender, System.EventArgs e)
        {
            nextQuestion(i);
        }

        public void nextQuestion(int i)
        {
            try
            {
                startq.Start();
                List<string> oLista = util.NextQuestion(i);
                this.btn_1.Text = oLista[0];
                this.btn_2.Text = oLista[1];
                this.btn_3.Text = oLista[2];
                this.btn_4.Text = oLista[3];
                this.lbl_qNr.Text = util.NumberOf(i);
                this.lbl_question.Text = util.GetQuestion();
                startq.Stop();
                Console.WriteLine("Time to load new question {0}",
                startq.Elapsed);
            }
            catch (SqlException r)
            {
                MessageBox.Show("Error: " + r);
            }          
        }

        private void btn_1_Click(object sender, EventArgs e)
        {

            try
            {
                string answer = btn_1.Text;
                MessageBox.Show(util.CheckAnswer(answer));
                if (util.CheckIfLast())
                {
                    int last = util.GetI();
                    nextQuestion(last);
                }
                else
                {
                    MessageBox.Show(util.GetEndgameText());
                    Hide();
                    lb.ShowDialog();
                    Close();
                }
            }
            catch (SqlException r)
            {
                MessageBox.Show("Error: " + r);
            }
            
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            try
            {
                string answer = btn_2.Text;
                MessageBox.Show(util.CheckAnswer(answer));
                if (util.CheckIfLast())
                {
                    int last = util.GetI();
                    nextQuestion(last);
                }
                else
                {
                    MessageBox.Show(util.GetEndgameText());
                    Hide();
                    lb.ShowDialog();
                    Close();
                }
            }
            catch (SqlException r)
            {
                MessageBox.Show("Error: " + r);
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {

            try
            {
                string answer = btn_3.Text;
                MessageBox.Show(util.CheckAnswer(answer));
                if (util.CheckIfLast())
                {
                    int last = util.GetI();
                    nextQuestion(last);
                }
                else
                {
                    MessageBox.Show(util.GetEndgameText());
                    Hide();
                    lb.ShowDialog();
                    Close();
                }
            }
            catch (SqlException r)
            {
                MessageBox.Show("Error: " + r);
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            try
            {
                string answer = btn_4.Text;
                MessageBox.Show(util.CheckAnswer(answer));
                if (util.CheckIfLast())
                {
                    int last = util.GetI();
                    nextQuestion(last);
                }
                else
                {
                    MessageBox.Show(util.GetEndgameText());
                    Hide();
                    lb.ShowDialog();
                    Close();
                }
            }
            catch (SqlException r)
            {
                MessageBox.Show("Error: " + r);
            }
        }

        private void AbortGame(object sender, EventArgs e)
        {
            int gId = util.GetGameId();
            util.AbortGame(gId);
            this.Hide();
            ng.ShowDialog();

            
        }

        private void lbl_qNr_Click(object sender, EventArgs e)
        {

        } 
    }
}
