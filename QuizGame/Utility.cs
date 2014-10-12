using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizGame;
using System.Data.SqlClient;

namespace QuizGame
{
    class Utility
    {
        Controller controller;
        int qNr = 0;
        int length = 0;
        int i = 0;
        
        // Constructor below.
        public Utility()
        {
            controller = new Controller();
            qNr = GetQnr();
        }

        // Create a new game, further instructions below.
        //public void NewGame(int questions, string username, List<string> categoryList)
        public void NewGame(int questions, string username)
        {
            // Create new game with new gId
            int gId;
            gId = controller.GetNrOfGames();
            gId++;
            controller.RegisterGame(gId);

            // Assign questions to game
            List<int> rndList = new List<int>();
            int qNr = 0;
            for (int i = 0; i <= questions; i++)
            {
                //qNr = controller.GetRandomNumber(categoryList);
                qNr = controller.GetRandomNumber();
                if (!rndList.Contains(qNr))
                {
                    rndList.Add(qNr);
                }
                else
                {
                    i--;
                }
            }
            foreach (int prime in rndList)
            {
                controller.RegisterGameSettings(prime, gId);
            }
            controller.AddStatistics(username, gId);
        }

        //Return a List with the alternatives for the question.
        public List<string> NextQuestion(int i)
        {
            int gId = GetGameId();
            List<int> qLista = controller.GetQuestions(gId);
            qNr = qLista[i];
            length = qLista.Count;
            List<string> oLista = controller.GetOptions(qNr);

            return oLista;
        }

        //Abort current gamesession
        public void AbortGame(int gId)
        {
            controller.AbortGame(gId);
        }

        // Return the game id with the highest value.
        public int GetGameId()
        {
            int gId = controller.GetGameId();
            return gId;
        }

        public int test()
        {
            return 5;
        }
        // Return questionnumber.
        public int GetQnr()
        {
            return qNr;
        }

        // Return a string that contains the question that is being answered.
        public string NumberOf(int i)
        {
            int gId = controller.GetGameId();
            int correct = controller.GetNrOfCorrect(gId);
            return "Question number: " + (1 + i) + "/" + length + " ,correct answers: " + correct;
        }

        // Return a question.
        public string GetQuestion()
        {
            string question = controller.GetRandomQuestion(qNr);
            return question;
        }

        public int GetNrOfCorrect(int gId)
        {
            return controller.GetNrOfCorrect(gId);
        }   
     

        // Checks if the answer is correct or not, then returns a string.
        public string CheckAnswer(string answer)
        {
            int gId = GetGameId();
            string qCorrect = controller.GetCorrect(qNr);
            string userName = controller.GetUserName(gId);
            

            if (answer == qCorrect)
            {
                controller.UpdateCorrect(userName, gId);
                string correct = "Your answer was correct " + userName + "!";
                return correct;
            }
            else
            {
                controller.UpdateIncorrect(userName, gId);
                string inCorrect = "Sorry, your answer was incorrect " + userName + ".";
                return inCorrect;
            }
        }


        //public List<string> Shuffle(List<string> lista)
        //{
        //    Random rng = new Random();
        //    int n = lista.Count;
        //    while (n > 1)
        //    {
        //        n--;
        //        int k = rng.Next(n + 1);
        //        string value = lista[k];
        //        lista[k] = lista[n];
        //        lista[n] = value;
        //    }
        //    return lista;
        //}

        // Checks if i is of greater value than the amount of questions chosen.
        public bool CheckLength(int i)
        {
            bool lastBool;            
            if (i > length)
            {
                lastBool = false;
            }
            else
            {
                lastBool = true;
            }
            return lastBool;
        }

        // return the value of i.
        public int NextQuestionNr()
        {
            int last = 150;
            if (CheckLength(i) == true)
            {
                if (i <= length)
                {
                    AddI();
                    return i;
                }
                else 
                {
                    return last;
                }
            }
            else 
            {
                return last;
            }
        }

        // Add i.
        public int AddI()
        {
            i++;
            return i;
        }

        // Return i.
        public int GetI()
        {
            return i;
        }

        // Return the amount of questions chosen.
        public int GetLength()
        {
            return length;
        }

        // Return true/false if there are no more questions.
        public bool CheckIfLast()
        {            
                       
            bool no;
            int last = NextQuestionNr();

            if (last < GetLength())
            {
                no = true;
                return no;
            }
            else
            {
                no = false;
                return no;
            }
                
        }

        // Checks if user already exists or the value is null.
        public bool CheckUser(string userName)
        {
            bool availability;
            string noName = "";
            if(userName == controller.CheckUser(userName))
            {
                availability = false;
                return availability;
            }
            else if(userName.Equals(noName))
            {
                availability = false;
                return availability;
            }
            else
            {
                availability = true;
                return availability;
            }
        }

        // Register a new player.
        public string RegisterPlayer(string userName)
        {
            string returnString;
            try
            {
                if (CheckUser(userName) == true)
                {
                    controller.RegisterPlayer(userName);
                    returnString = "Player successfully registered.";
                    return returnString;
                }
                else
                {
                    returnString = "Username cannot be null or already exists, please choose another username.";
                    return returnString;
                }
            }
            catch (SqlException r)
            {
                
                throw r;
            }
        }

        // Return a string that will appear when the last question is answered.
        public string GetEndgameText()
        {
            string endgameText = "That was the last question in the game. \nThe leaderboard will now open "
            + "and show the result for this game (#" + GetGameId() + "), and every other previously completed game.\nThank you for playing!";
            return endgameText;
        }

        //public List<string> CreateCategoryList(string culture, string sport, string entertainment, string geography, string technology, string nature,string history)
        //{
        //    List<string> categoryList = new List<string>();
        //    if (culture != null)
        //    {
        //        categoryList.Add(culture);
        //        if (sport != null)
        //        {
        //            categoryList.Add(sport);
        //            if (entertainment != null)
        //            {
        //                categoryList.Add(entertainment);
        //                if (geography != null)
        //                {
        //                    categoryList.Add(geography);
        //                    if (technology != null)
        //                    {
        //                        categoryList.Add(technology);
        //                        if (technology != null)
        //                        {
        //                            categoryList.Add(nature);
        //                            if (history != null)
        //                            {
        //                                categoryList.Add(history);
        //                            }
        //                         }
        //                     }
        //                 }
        //             }
        //         }
        //    }   
            
        //    return categoryList;
        //}
    }

}