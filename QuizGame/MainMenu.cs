using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame
{
    public partial class MainMenu : Form
    {

        public MainMenu()
        {
            InitializeComponent();
        }

        private void btn_Leaderboard_Click(object sender, EventArgs e)
        {
            LeaderBoard lb = new LeaderBoard();
            this.Hide();
            lb.ShowDialog();
            this.Close();
        }

        private void btn_NewGame_Click(object sender, EventArgs e)
        {
            NewGame ng = new NewGame();
            this.Hide();
            ng.ShowDialog();
            this.Close();
        }

        private void btn_createQuestion_Click(object sender, EventArgs e)
        {
            CreateQuestion cq = new CreateQuestion();
            this.Hide();
            cq.ShowDialog();
            this.Close();
        }

    }
}
