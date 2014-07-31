using System;
using System.Collections.Generic;
using System.Threading;
using WindowsInput;

namespace TypePlane
{
    class Program
    {
        delegate string ReadLineDelegate();

        static string ReadLine(int timeoutms)
        {
            ReadLineDelegate d = Console.ReadLine;
            IAsyncResult result = d.BeginInvoke(null, null);
            result.AsyncWaitHandle.WaitOne(timeoutms);
            if (result.IsCompleted) return d.EndInvoke(result);
            else
            {
                InputSimulator.SimulateKeyPress(VirtualKeyCode.RETURN);
                return String.Empty;
            }
        }

        static void Main()
        {
            Game newGame = new Game();
            newGame.MainMenu();

            while (newGame.Lives > 0)
            {
                List<Word> words = new List<Word>();
                Random rng = new Random();

                while (true)
                {
                    Word newWord = new Word(rng.Next(0, Console.WindowWidth), newGame.Word[rng.Next(0, newGame.Word.Count)]);

                    if (newWord.X + newWord.Visualisation.Length >= Console.WindowWidth) continue;
                    else words.Add(newWord);

                    foreach (Word word in words)
                        word.PrintStringToScreen();

                    if (newGame.Visualisation.Length + words[0].X > Console.WindowWidth - 1)
                        newGame.X = Console.WindowWidth - newGame.Visualisation.Length - 1;
                    else if (words[0].X - words[0].Visualisation.Length <= 0)
                        newGame.X = 0;
                    else
                        newGame.X = words[0].X - (newGame.Visualisation.Length / 2 - words[0].Visualisation.Length / 2);

                    newGame.PrintStringToScreen();
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    Console.SetCursorPosition(words[0].X, newGame.Y - 2);

                    string input = ReadLine(2500);
                    Console.Clear();

                    if (words[0].Equals(input))
                    {
                        newGame.Score += words[0].Visualisation.Length;
                        words.RemoveAt(0);
                    }

                    try
                    {
                        if (words[0].Y == newGame.Y - 2)
                        {
                            newGame.Die();
                            newGame.PrintStringToScreen();
                            Console.Beep();
                            newGame.RIP();
                            newGame.Revive();
                            Console.Clear();
                            break;
                        }
                    }
                    catch
                    {
                        continue;
                    }

                    foreach (Word word in words)
                        word.Y += 1;
                }
            }

            if (newGame.GameOverMenu() == ConsoleKey.Enter) Main();
            Environment.Exit(0);
        }
    }
}
