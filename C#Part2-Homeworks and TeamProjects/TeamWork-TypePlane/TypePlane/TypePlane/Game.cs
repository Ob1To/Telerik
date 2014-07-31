using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TypePlane
{
    public class Game : Plane
    {
        #region Fields

        int score;
        int highscore;
        string user;
        string[] gameNameASCII = new string[7];
        List<string> wordList = new List<string>();

        #endregion

        #region Constructors

        public Game()
        {
            this.score = 0;
            this.highscore = GetHighscore();
            this.gameNameASCII[0] = " _______ __   __ _______ _______ _______ ___     _______ __    _ _______ ";
            this.gameNameASCII[1] = "|       |  | |  |       |       |       |   |   |   _   |  |  | |       |";
            this.gameNameASCII[2] = "|_     _|  |_|  |    _  |    ___|    _  |   |   |  |_|  |   |_| |    ___|";
            this.gameNameASCII[3] = "  |   | |       |   |_| |   |___|   |_| |   |   |       |       |   |___ ";
            this.gameNameASCII[4] = "  |   | |_     _|    ___|    ___|    ___|   |___|       |  _    |    ___|";
            this.gameNameASCII[5] = "  |   |   |   | |   |   |   |___|   |   |       |   _   | | |   |   |___ ";
            this.gameNameASCII[6] = "  |___|   |___| |___|   |_______|___|   |_______|__| |__|_|  |__|_______|";
            this.wordList = GetWords();
        }

        #endregion

        #region Properties

        public List<string> Word
        {
            get { return this.wordList; }
        }

        public int Score
        {
            get { return this.score; }
            set { this.score = value; }
        }

        #endregion

        #region Private methods

        private static List<string> GetWords()
        {
            List<string> wordsList = new List<string>();

            using (StreamReader words = new StreamReader("../../../DATA/Words.txt"))
                for (string word; (word = words.ReadLine()) != null; )
                    wordsList.Add(word.ToLower());

            return wordsList;
        }

        private static int GetHighscore()
        {
            int highscore = int.MinValue;

            using (StreamReader scores = new StreamReader("../../../DATA/Highscores.txt"))
                highscore = int.Parse(scores.ReadLine().Split(':')[1]);

            return highscore;
        }

        private static void SaveHighscore(int newScore, string user)
        {
            Dictionary<string, int> highscores = new Dictionary<string, int>();

            using (StreamReader scores = new StreamReader("../../../DATA/Highscores.txt"))
                for (string score; (score = scores.ReadLine()) != null; )
                    highscores.Add(score.Split(':')[0], int.Parse(score.Split(':')[1]));

            try
            {
                highscores.Add(user, newScore);
            }
            catch
            {
                highscores[user] = Math.Max(highscores[user], newScore);
            }
            highscores = highscores.OrderBy(x => x.Value).Reverse().ToDictionary(x => x.Key, x => x.Value);

            using (StreamWriter newscores = new StreamWriter("../../../DATA/Highscores.txt"))
                foreach (var scoreInfo in highscores)
                    newscores.WriteLine(scoreInfo.Key + ": " + scoreInfo.Value.ToString());
        }

        private void PrintHighscores()
        {
            string[,] highscores = new string[5, 2];

            int count = 0;

            string top = "TOP SCORERS";
            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (top.Length / 2)) + "}", top);
            Console.WriteLine();

            using (StreamReader scores = new StreamReader("../../../DATA/Highscores.txt"))
                for (string score; (score = scores.ReadLine()) != null; count++)
                {
                    highscores[count, 0] = score.Split(':')[0];
                    highscores[count, 1] = score.Split(':')[1];

                    string theScore = highscores[count, 0] + " = " + highscores[count, 1];
                    Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (theScore.Length / 2)) + "}", theScore);

                    if (count == 4) break;
                }   
        }

        #endregion

        #region Public methods

        public void MainMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Title = "TypePlane";

            Console.WriteLine(Environment.NewLine);
            foreach (string line in this.gameNameASCII)
                Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (line.Length / 2)) + "}", line);

            Console.WriteLine(Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine);

            string welcomeText = "Press any key to start...";
            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (welcomeText.Length / 2)) + "}", welcomeText);

            Console.WriteLine(Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine);

            string scoreText = "Highest score: " + this.highscore.ToString();
            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (scoreText.Length / 2)) + "}", scoreText);

            Console.ReadKey(true);

            ExplanationMenu();
        }

        public void ExplanationMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to TypePlane!");
            Console.WriteLine("You are a plane that stays on the bottom of the screen.");
            Console.WriteLine("Every 2.5 seconds a new word pops at the top of the screen.");
            Console.WriteLine("You have 2.5 to enter the word that you see");
            Console.WriteLine("until a new one shows up and you have to retry the last one.");
            Console.WriteLine("If a word reaches your plane you lose a life.");
            Console.WriteLine("You have 3 lives in total.");
            Console.WriteLine(Environment.NewLine + "Enjoy playing!");
            Console.WriteLine(Environment.NewLine + "Press any key to start...");

            Console.ReadKey(true);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorVisible = false;
        }

        public void RIP()
        {
            string textOne = "You died.";
            string textTwo = "You have " + this.Lives + " lives left.";
            string textThree = "Press any key to continue...";

            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Environment.NewLine + Environment.NewLine + Environment.NewLine);
            Console.WriteLine(Environment.NewLine + Environment.NewLine + Environment.NewLine);
            Console.WriteLine(Environment.NewLine + Environment.NewLine);
            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (textOne.Length / 2)) + "}", textOne);
            Console.WriteLine(Environment.NewLine + "{0," + ((Console.WindowWidth / 2) + (textTwo.Length / 2)) + "}", textTwo);
            Console.WriteLine(Environment.NewLine + "{0," + ((Console.WindowWidth / 2) + (textThree.Length / 2)) + "}", textThree);

            Console.ReadKey(true);
        }

        public ConsoleKey GameOverMenu()
        {
            Console.WriteLine(Environment.NewLine + Environment.NewLine + Environment.NewLine);
            Console.WriteLine(Environment.NewLine + Environment.NewLine + Environment.NewLine);
            Console.WriteLine(Environment.NewLine + Environment.NewLine);

            string textOne = "Game Over!";
            string textTwo = "Enter your name: ";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (textOne.Length / 2)) + "}", textOne);
            Console.Write(Environment.NewLine + "{0," + ((Console.WindowWidth / 2) + (textTwo.Length / 2)) + "}", textTwo);
            this.user = Console.ReadLine();

            SaveHighscore(this.score, this.user);
            return ResultsMenu();
        }

        public ConsoleKey ResultsMenu()
        {
            Console.Clear();
            Console.WriteLine(Environment.NewLine + Environment.NewLine + Environment.NewLine);
            Console.WriteLine(Environment.NewLine + Environment.NewLine + Environment.NewLine);

            string textTwo = "Press Enter to restart the game, any other key to Exit";
            string textThree = "Your score this game: " + this.score;

            PrintHighscores();
            Console.WriteLine(Environment.NewLine + "{0," + ((Console.WindowWidth / 2) + (textTwo.Length / 2)) + "}", textTwo);
            Console.WriteLine(Environment.NewLine + "{0," + ((Console.WindowWidth / 2) + (textThree.Length / 2)) + "}", textThree);

            while (Console.KeyAvailable)
                Console.ReadKey(true);
            return Console.ReadKey(true).Key;
        }

        #endregion
    }
}
