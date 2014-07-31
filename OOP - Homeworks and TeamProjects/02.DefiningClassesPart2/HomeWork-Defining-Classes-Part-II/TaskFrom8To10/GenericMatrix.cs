namespace TaskFrom8To10
{
    using System;
    using System.Text;
    public class GenericMatrix<T> where T : IComparable<T>
    {
        private T[,] matrix;

        public GenericMatrix(uint rows, uint cols)
        {
            this.Rows = rows;
            this.Cols = cols;

            this.matrix = new T[rows, cols];
        }

        public uint Rows { get; private set; }

        public uint Cols { get; private set; }

        public T this[int row, int col]
        {
            get
            {
                if ((row < 0 || row >= this.Rows) || (col < 0 || col >= this.Cols))
                {
                    throw new IndexOutOfRangeException();
                }

                return this.matrix[row, col];
            }
            set
            {
                if ((row < 0 || row >= this.Rows) || (col < 0 || col >= this.Cols))
                {
                    throw new IndexOutOfRangeException();
                }

                this.matrix[row, col] = value;
            }
        }

        public static GenericMatrix<T> operator +(GenericMatrix<T> first, GenericMatrix<T> second)
        {
            return PlusMinus(first, second, true);
        }

        public static GenericMatrix<T> operator -(GenericMatrix<T> first, GenericMatrix<T> second)
        {
            return PlusMinus(first, second, false);
        }

        public static GenericMatrix<T> operator *(GenericMatrix<T> first, GenericMatrix<T> second)
        {
            if (first.Cols != second.Rows)
            {
                throw new ArgumentException("Matrices must be of the same size");
            }

            GenericMatrix<T> result = new GenericMatrix<T>(first.Rows, second.Cols);

            for (int row = 0; row < first.Rows; row++)
            {
                for (int col = 0; col < second.Cols; col++)
                {
                    result[row, col] = (dynamic)first[row, col] * (dynamic)second[col, row];
                }
            }

            return result;
        }

        public static bool operator true(GenericMatrix<T> matrix)
        {
            return BoolOperation(matrix, true);
        }

        public static bool operator false(GenericMatrix<T> matrix)
        {
            return BoolOperation(matrix, false);
        }

        public override string ToString()
        {
            var matrix = new StringBuilder();

            for (int row = 0; row < this.Rows; row++)
            {
                for (int column = 0; column < this.Cols; column++)
                {
                    matrix.Append(this.matrix[row, column] + (column != this.Cols - 1 ? " " : Environment.NewLine));
                }
            }

            return matrix.ToString();
        }

        private static GenericMatrix<T> PlusMinus(GenericMatrix<T> first, GenericMatrix<T> second, bool operation) // plus = true, minus = false
        {
            if (!(first.Rows == second.Rows && first.Cols == second.Cols))
            {
                throw new ArgumentException("Matrices must be of the same size");
            }

            GenericMatrix<T> result = new GenericMatrix<T>(first.Rows, first.Cols);

            for (int row = 0; row < first.Rows; row++)
            {
                for (int col = 0; col < first.Cols; col++)
                {
                    result[row, col] = first[row, col] + (operation ? second[row, col] : -(dynamic)second[row, col]);
                }
            }

            return result;
        }

        private static bool BoolOperation(GenericMatrix<T> matrix, bool operation)
        {
            foreach (T element in matrix.matrix)
            {
                if ((dynamic)element != 0)
                {
                    return operation;
                }
            }

            return !operation;
        }
    }
}
