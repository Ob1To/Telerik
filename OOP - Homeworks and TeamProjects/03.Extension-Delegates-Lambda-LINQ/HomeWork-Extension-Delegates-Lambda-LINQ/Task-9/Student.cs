namespace Task_9
{
    using System.Collections.Generic;
    using System.Text;
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int FN { get; set; }

        public string TelephoneNumber { get; set; }

        public string Email { get; set; }

        public List<int> Marks { get; set; }

        public int GroupNumber { get; set; }

        public Student(string firstName, string LastName, int fN,string telephoneNumber, string email, List<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = LastName;
            this.FN = fN;
            this.TelephoneNumber = telephoneNumber;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public override string ToString()
        {
            var st = new StringBuilder();

            st.AppendLine("First Name: " + this.FirstName);
            st.AppendLine("Last Name: " + this.LastName);
            st.AppendLine("FN: " + this.FN);
            st.AppendLine("Telephone Number: " + this.TelephoneNumber);
            st.AppendLine("Email: " + this.Email);
            st.Append("Marks: ");
            foreach (var mark in this.Marks)
            {
                st.Append(mark + ", ");
            }
            st.AppendLine();
            st.AppendLine("Group Number: " + this.GroupNumber);
            return st.ToString();
        }
    }
}
