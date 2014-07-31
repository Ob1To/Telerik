namespace Human
{
    using System;
    public class Student : Human
    {
        private byte grade;


        public Student(string firstName,string lastName, byte grade) : base(firstName,lastName)
        {
            this.Grade = grade;
        }


        public byte Grade
        {
            get { return grade; }
            set 
            {
                if (value <= 1 && value >= 7)
                {
                    throw new ArgumentOutOfRangeException("Grade must be between 2 and 6");
                }
                else
                {
                    grade = value;
                }
            }
        }
        
    }
}
