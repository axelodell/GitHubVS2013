using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data.Sql;
using System.Data.SqlClient;

namespace QuizGame
{
    class Controller
    {
        private DAL dal;
        
        // Constructor below.
        public Controller()
        {           
            dal = new DAL();
        }

        public void RegisterPlayer(string userName)
        {
            dal.RegisterPlayer(userName);
            
        }

        public void AbortGame(int gId)
        {
            dal.AbortGame(gId);
        }

        public int GetNrOfCorrect(int gId)
        {
            return dal.GetNrOfCorrect(gId);
        }

        //// Not in use.
        //public SqlDataReader GetPlayers()
        //{
        //    return dal.GetPlayers();
        //}

        //// Not in use.
        //public int GetNrOfQuestions()
        //{
        //    return dal.GetNrOfQuestions();
        //}

        //public int GetRandomNumber(List<string> categoryList)
        public int GetRandomNumber()
        {
            //return dal.GetRandomNumber(categoryList);
            return dal.GetRandomNumber();
        }

        //// Not in use.
        //public List<int> CheckUnique(int gId)
        //{
        //    return dal.CheckUnique(gId);
        //}

        public void CreateQuestion(string qDescription, string qCorrect, string qIncorrect1, string qIncorrect2, string qIncorrect3, string qCategory, string qDifficulty)
        {
            dal.CreateQuestion(qDescription, qCorrect, qIncorrect1, qIncorrect2, qIncorrect3, qCategory, qDifficulty);
        }
        public string GetCorrect(int qNr)
        {
            return dal.GetCorrect(qNr);
        }

        public string GetRandomQuestion(int qNr)
        {
            return dal.GetRandomQuestion(qNr);
        }

        public string GetUserName(int gId)
        {
            return dal.GetUserName(gId);
        }

        public void AddStatistics(string userName, int gId)
        {
            dal.AddStatistics(userName, gId);
        }

        public void UpdateCorrect(string userName,int gId)
        {
            dal.UpdateCorrect(userName, gId);
        }

        public void UpdateIncorrect(string userName, int gId)
        {
            dal.UpdateIncorrect(userName, gId);
        }

        //// Not in use.
        //public void deletePlayer(string userName)
        //{
        //    dal.deletePlayer(userName);
        //}

        public void GetCon()
        {
            dal.GetCon();
        }

        public SqlDataReader getResults(){
            return dal.GetResults();
        }

        public int GetNrOfGames()
        {
            return dal.GetNrOfGames();
        }

        public void RegisterGame(int gId)
        {
            dal.RegisterGame(gId);
        }

        public void RegisterGameSettings(int qNr, int gId)
        {
            dal.RegisterGameSettings(qNr, gId);
        }

        public List<string> GetOptions(int qNr)
        {
            return dal.GetOptions(qNr);
        }

        public int GetGameId()
        {
            return dal.GetGameId();
        }

        public List<int> GetQuestions(int gId)
        {
            return dal.GetQuestions(gId);
        }

        public string CheckUser(string userName)
        {
            return dal.CheckUser(userName);
        }
    }
}










