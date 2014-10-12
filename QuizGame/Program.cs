using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());

            //Controller controller = new Controller();
            //controller.registerPlayer("Swaggzel");
            //controller.getPlayers();
            //controller.getNrOfQuestions();
            //controller.getNrOfQuestions();            
            //controller.getRandomQuestion();
            //controller.addStatistics("Swaggzel", "1");
            //controller.updateCorrect("Swaggzel", "1");
            //controller.updateIncorrect("Swaggzel", "1");
            //controller.deletePlayer("Swaggzel");
            //controller.getResults();
        }
    }
}
