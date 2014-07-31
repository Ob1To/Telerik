using System;

namespace TypePlane
{
    public class Plane : Object
    {
        #region Fields

        int lives;

        #endregion

        #region Constructors

        public Plane()
        {
            this.Visualisation = "\\__[0]__/";
            this.X = Console.WindowWidth / 2 - this.Visualisation.Length / 2;
            this.Y = Console.WindowHeight - 1;
            this.Color = ConsoleColor.Cyan;
            this.lives = 3;
        }

        #endregion

        #region Properties

        public int Lives
        {
            get { return this.lives; }
            set { this.lives = value; }
        }

        #endregion

        #region Public methods

        public void Die()
        {
            this.Visualisation = new string('X', this.Visualisation.Length);
            this.Color = ConsoleColor.Red;
            this.lives -= 1;
        }

        public void Revive()
        {
            this.Visualisation = "\\__[0]__/";
            this.X = Console.WindowWidth / 2 - this.Visualisation.Length / 2;
            this.Y = Console.WindowHeight - 1;
            this.Color = ConsoleColor.Cyan;
        }

        #endregion
    }
}
