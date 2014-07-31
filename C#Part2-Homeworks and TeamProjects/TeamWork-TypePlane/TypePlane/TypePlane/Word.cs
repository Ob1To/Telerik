using System;

namespace TypePlane
{
    public class Word : Object
    {
        #region Constructors

        public Word(int x, string visualisation)
        {
            this.Visualisation = visualisation;
            this.X = x;
            this.Y = 0;
            this.Color = ConsoleColor.Magenta;
        }

        #endregion

        #region Public methods

        public bool Equals(string input)
        {
            return this.Visualisation == input;
        }

        #endregion
    }
}
