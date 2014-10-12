using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data.Odbc;
using System.Data.Sql;
namespace QuizGame
{
    class DAL
    {
        private SqlConnection con = null;
        private SqlCommand cmd = null;
        private SqlDataReader reader = null;
        string sqlStr;
        int count;
        List<string> list;

        // Constructor below.
        public DAL()
        {
            GetCon();
        }

        // Get connection to SQL database.
        public void GetCon()
        {
            try
            {
                //con = new SqlConnection("Data Source=DESTRUCTOR;Initial Catalog=SYSA14;Integrated Security=True");
                con = new SqlConnection("Data Source=AXELS;Initial Catalog=SYSA14;Integrated Security=True");
                con.Open();
                con.Close();
            }
            catch (SqlException)
            {
                throw;
            }            
        }

        // Register new player in the database.
        public void RegisterPlayer(string userName)
        {
            try
            {
                sqlStr = "INSERT INTO Player VALUES('" + userName + "')";
                cmd = new SqlCommand(sqlStr, con);
                con.Open();
                reader = cmd.ExecuteReader();
                con.Close();
                reader.Close();
                
            }
            catch (SqlException r)
            {
                throw r;
            }
           
        }

        public void AbortGame(int gId)
        {
            try
            {
                DeleteResults(gId);
                DeleteGameSettings(gId);
                DeleteGame(gId);
            }
            catch (SqlException e)
            {
                throw;
            }
        }

        public void DeleteGameSettings(int gId)
        {
            try
            {
                sqlStr = "DELETE GameSettings WHERE  gId = '" + gId + "'";
                cmd = new SqlCommand(sqlStr, con);
                con.Open();
                reader = cmd.ExecuteReader();
                con.Close();
            }
            catch (SqlException e)
            {
                throw;
            }
        }

        public void DeleteResults(int gId)
        {
            try
            {
                sqlStr = "DELETE Results WHERE  gId = '" + gId + "'";
                cmd = new SqlCommand(sqlStr, con);
                con.Open();
                reader = cmd.ExecuteReader();
                con.Close();
            }
            catch (SqlException e)
            {
                throw;
            }
        }

        public void DeleteGame(int gId)
        {
            try
            {
                sqlStr = "DELETE Game WHERE  gId = '" + gId + "'";
                cmd = new SqlCommand(sqlStr, con);
                con.Open();
                reader = cmd.ExecuteReader();
                con.Close();
            }
            catch (SqlException e)
            {
                throw;
            }
        }



        //// Delete results from the database. (NOT IN USE)
        //public void deleteResult(string userName)
        //{
        //    try
        //    {
        //        sqlStr = "DELETE FROM Results WHERE userName = '" + userName + "'";
        //        cmd = new SqlCommand(sqlStr, con);
        //        con.Open();
        //        reader = cmd.ExecuteReader();
        //        con.Close();
        //    }
        //    catch (SqlException e)
        //    {
        //        Console.WriteLine("Error in deleteResult: " + e);
        //    }
        //}

        //// Delete player from the database. (NOT IN USE)
        //public void deletePlayer(string userName)
        //{
        //    deleteResult(userName);
        //    sqlStr = "Delete from Player where userName = '" + userName + "'";
        //    cmd = new SqlCommand(sqlStr, con);
        //    con.Open();
        //    reader = cmd.ExecuteReader();
        //    con.Close();
        //}

        // Get all players from the database.
        public SqlDataReader GetPlayers()
        {
            try
            {
                con.Open();
                string tmpUser;
                sqlStr = "SELECT * FROM Player";
                cmd = new SqlCommand(sqlStr, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tmpUser = reader.GetString(0);
                }
                con.Close();
                reader.Close();
                return reader;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public string GetSqlStr(List<string> categoryList)
        {
            List<string> categories = categoryList;
            string culture = "Culture";
            string sport = "Sport";
            string entertainment = "Entertainment";
            string geography = "Geography";
            string history = "History";
            string technology = "Technology";
            string nature = "Nature";
            string sqlStr = "SELECT COUNT(*) FROM Question WHERE qCategory = ";
            //int count = 0;
            for (int i = 0; i < categories.Count; i++){
                
                if (categories[i] == culture){
                    sqlStr += "'Culture'";
                    //count++;
                    Console.WriteLine(i);
                }
                if (categories[i] == sport)
                {
                    sqlStr += "OR qCategory = 'Sport'";
                    //count++;
                }
               
            }
            return sqlStr;
        }


        public void CreateQuestion(string qDescription, string qCorrect, string qIncorrect1, string qIncorrect2, string qIncorrect3, string qCategory, string qDifficulty)
        {
            try
            {
                int qNr = GetNrOfQuestionsInDatabase();
                qNr++;
                sqlStr = "INSERT INTO Question VALUES('" + qNr + "'" + qDescription + "', '" + qCorrect + "', '" + qIncorrect1 + "', '" + qIncorrect2 + "', '" + qIncorrect3 + "', '" + qCategory + "', '" + qDifficulty + "')";
                cmd = new SqlCommand(sqlStr, con);
                con.Open();
                reader = cmd.ExecuteReader();
                con.Close();
                reader.Close();

            }
            catch (SqlException r)
            {
                throw r;
            }
        }

        public int GetNrOfQuestions(List<string> categoryList){
        //public int GetNrOfQuestions(){

        
        
            try
            {
                con.Open();

                //sqlStr = GetSqlStr(categoryList);
                // den här under funkar, jag testar bara //Axel
                sqlStr = "SELECT COUNT(*) FROM Question";
                cmd = new SqlCommand(sqlStr, con);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    count = reader.GetInt32(0);
                }
                con.Close();
                reader.Close();
                return count;
            }
            catch (SqlException)
            {
                throw;
            }
        }
        
            public int GetNrOfQuestionsInDatabase(){
            try
            {
                con.Open();
                sqlStr = "SELECT COUNT(*) FROM Question";
                cmd = new SqlCommand(sqlStr, con);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    count = reader.GetInt32(0);
                }
                con.Close();
                reader.Close();
                return count;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        // Gets a random number
        public int GetRandomNumber(List<string> categoryList)          //  AXELS BAJS MED KATEGORIER
        //public int GetRandomNumber()
        {
            try
            {
                Random random = new Random();
                //int count = GetNrOfQuestions();
                int count = GetNrOfQuestions(categoryList);
                int nmbr = random.Next(1, count + 1);
                return nmbr;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        

        // Creates a List with questionnumbers.
        public List<int> CheckUnique(int gId)
        {
            try
            {
                con.Open();
                int uq = 0;
                List<int> uniqueList = new List<int>();
                sqlStr = "SELECT qNr FROM GameSettings WHERE gId = '" + gId + "'";
                cmd = new SqlCommand(sqlStr, con);
                reader = cmd.ExecuteReader();
                for (int i = 0; i <= reader.Depth; i++)
                {
                    uq = reader.GetInt32(i);
                    uniqueList.Add(uq);
                }
                con.Close();
                reader.Close();
                return uniqueList;
            }
            catch (SqlException)
            {
                
                throw;
            }
        }

        // Gets a questiondescription from database.
        public string GetRandomQuestion(int qNr)
        {
            try
            {
                string tmpQuestion = null;
                con.Open();
                sqlStr = "SELECT qDescription FROM Question WHERE qNr = '" + qNr + "'";
                cmd = new SqlCommand(sqlStr, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tmpQuestion = reader.GetString(0);
                }
                con.Close();
                reader.Close();
                return tmpQuestion;
            }
            catch (SqlException)
            {
                
                throw;
            }
        }

        // Add statistics to a new game id. 
        public void AddStatistics(string userName, int gId)
        {
            try
            {
                int correct = 0;
                int incorrect = 0;
                sqlStr = "INSERT INTO Results VALUES('" + userName + "', '" + gId + "', '" + correct + "', '" + incorrect + "')";
                con.Open();
                cmd = new SqlCommand(sqlStr, con);
                reader = cmd.ExecuteReader();
                con.Close();
                reader.Close();
            }
            catch (SqlException)
            {
                throw;
            }
        }

        // Update playerscore when answer is correct.
        public void UpdateCorrect(string userName, int gId)
        {
            try
            {
                int plus = 1;
                sqlStr = "UPDATE Results SET nrCorrect += '" + plus + "' WHERE userName = '" + userName + "' AND gId = '" + gId + "'";
                con.Open();
                cmd = new SqlCommand(sqlStr, con);
                reader = cmd.ExecuteReader();
                con.Close();
                reader.Close();
            }
            catch (SqlException )
            {
                throw;
            }
        }

        // Update playerscore when answer is incorrect.
        public void UpdateIncorrect(string userName, int gId)
        {
            try
            {
                int plus = 1;
                sqlStr = "UPDATE Results SET nrIncorrect += '" + plus + "' WHERE userName = '" + userName + "' AND gId = '" + gId + "'";
                con.Open();
                cmd = new SqlCommand(sqlStr, con);
                reader = cmd.ExecuteReader();
                con.Close();
                reader.Close();
            }
            catch (SqlException)
            {
                throw;
            }
        }

        // Get results from database to leaderboard.
        public SqlDataReader GetResults(){
            try
            {
                con.Open();
                sqlStr = "SELECT * FROM Results";
                cmd = new SqlCommand(sqlStr, con);
                reader = cmd.ExecuteReader();
                con.Close();
                reader.Close();
                return reader;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        // Get the number of unique games from database.
        public int GetNrOfGames()
        {
            try
            {
                con.Open();
                sqlStr = "SELECT COUNT(*) FROM Game";
                cmd = new SqlCommand(sqlStr, con);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    count = reader.GetInt32(0);
                }
                con.Close();
                reader.Close();
                return count;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        // Register a new game into the database.
        public void RegisterGame(int gId)
        {
            try
            {
                sqlStr = "INSERT INTO Game VALUES('" + gId + "')";
                cmd = new SqlCommand(sqlStr, con);
                con.Open();
                reader = cmd.ExecuteReader();
                con.Close();
                reader.Close();
            }
            catch (SqlException)
            {
                throw;
            }
        }

        // Register game settings in the database.
        public void RegisterGameSettings(int qNr, int gId)
        {
            try
            {
                sqlStr = "INSERT INTO GameSettings VALUES('" + qNr + "', '" + gId + "')";
                cmd = new SqlCommand(sqlStr, con);
                con.Open();
                reader = cmd.ExecuteReader();
                con.Close();
                reader.Close();
            }
            catch (SqlException)
            {
                throw;
            }
        }

        // Shuffles the items inside a list.
        public List<string> Shuffle(List<string> lista)
        {
            Random rng = new Random();
            int n = lista.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                string value = lista[k];
                lista[k] = lista[n];
                lista[n] = value;
            }
            return lista;
        }

        // Get the questions assigned to a unique game.
        public List<int> GetQuestions(int gId)
        {
            try
            {
                List<int> qList = new List<int>();
                con.Open();
                sqlStr = "SELECT qNr FROM GameSettings WHERE gId = '" + gId + "'";
                cmd = new SqlCommand(sqlStr, con);
                reader = cmd.ExecuteReader();
                int qnr = 0;
                while (reader.Read())
                {
                    for (int i = 0; i <= reader.Depth; i++)
                    {
                        qnr = reader.GetInt32(i);
                        qList.Add(qnr);
                    }
                }
                con.Close();
                reader.Close();
                return qList;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        // Get the options to the selected questions.
        public List<string> GetOptions(int qNr)
        {
            try
            {
                list = new List<string>();
                string correct;
                string wrong1;
                string wrong2;
                string wrong3;

                con.Open();
                sqlStr = "SELECT qCorrect, qWrong1, qWrong2, qWrong3 FROM Question WHERE qNr = '" + qNr + "'";
                cmd = new SqlCommand(sqlStr, con);
                reader = cmd.ExecuteReader();

                reader.Read();
                correct = reader.GetString(0);
                wrong1 = reader.GetString(1);
                wrong2 = reader.GetString(2);
                wrong3 = reader.GetString(3);

                list.Add(correct);
                list.Add(wrong1);
                list.Add(wrong2);
                list.Add(wrong3);

                Shuffle(list);
                con.Close();
                reader.Close();
                return list;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        // Get the latest created game from the database.
        public int GetGameId()
        {
            try
            {
                sqlStr = "SELECT MAX(gId) FROM GameSettings";
                int nr = 0;
                con.Open();
                cmd = new SqlCommand(sqlStr, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    nr = reader.GetInt32(0);
                }
                con.Close();
                reader.Close();
                return nr;
            }
            catch (SqlException)
            {
                
                throw;
            }
        }

        // Get the correct answer to a question from the database.
        public string GetCorrect(int qNr)
        {
            try
            {
                sqlStr = "SELECT qCorrect FROM Question WHERE qNr = '" + qNr + "'";
                string qCorrect = null;
                con.Open();
                cmd = new SqlCommand(sqlStr, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    qCorrect = reader.GetString(0);
                }
                con.Close();
                reader.Close();
                return qCorrect;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        // Get a username to display in Leaderboard.
        public string GetUserName(int gId)
        {
            try
            {
                sqlStr = "SELECT username FROM results WHERE gId = '" + gId + "'";
                string userName = null;
                con.Open();
                cmd = new SqlCommand(sqlStr, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    userName = reader.GetString(0);
                }
                con.Close();
                reader.Close();
                return userName;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        // Check if the username already exists in the database.
        public string CheckUser(string userName)
        {
            try
            {
                sqlStr = "SELECT userName FROM Player WHERE userName = '" + userName + "'";
                con.Open();
                cmd = new SqlCommand(sqlStr, con);
                reader = cmd.ExecuteReader();
                string tempUserName = null;
                while (reader.Read())
                {
                    tempUserName = reader.GetString(0);
                }
                con.Close();
                reader.Close();
                return tempUserName;
            }
            catch (SqlException)
            {
                throw;
            }
        }
        public int GetNrOfCorrect(int gId)
        {

            try
            {
                sqlStr = "SELECT nrCorrect FROM Results WHERE gId = '" + gId + "'";
                con.Open();
                int correct = 0;
                cmd = new SqlCommand(sqlStr, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    correct = reader.GetInt32(0);
                }
                con.Close();
                reader.Close();
                return correct;
            }
           
            catch (SqlException)
            {
                throw;
            }
            }


        }
    }











