namespace Task_1To3_StudentInfo
{
    using System;
    public class Student : ICloneable,IComparable<Student>
    {
        public string FirstName { get; set; }

        public string MiddleName { get; private set; }

        public string LastName { get; private set; }

        public string Ssn { get; private set; }

        public string PermanentAddress { get; private set; }

        public string MobilePhone { get; private set; }

        public string Email { get; private set; }

        public string Course { get; private set; }


        public Specialties Speciality{ get; private set; }

        public Faculties Faculty { get; private set; }

        public University University { get; private set; }



        public Student(string firstName, string middleName, string lastName, string ssn,string address, string mobilePhone, 
            string email, string course, Specialties speciality, Faculties faculty, University university)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Ssn = ssn;
            this.PermanentAddress = address;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Speciality = speciality;
            this.Faculty = faculty;
            this.University = university;
        }


        public override bool Equals(object obj)
        {
            Student student = obj as Student;
            if (student == null)
            {
                return false;
            }

            bool equals = (this.FirstName == student.FirstName) && (this.Ssn == student.Ssn);
            return equals;
        }


        public override int GetHashCode()
        {
            int hashCode = this.FirstName.GetHashCode() ^ this.MiddleName.GetHashCode() ^ this.LastName.GetHashCode() ^ this.Ssn.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return string.Format("Student\r\nName: {0,12} {1} {2}\r\nSSN: {3,15}\r\nUniversity: {4,20}", this.FirstName, this.MiddleName, this.LastName, this.Ssn,this.University);
        }

        public static bool operator == (Student firstStudent, Student secondStudent)
        {
            return Student.Equals(firstStudent, secondStudent);
        }

        public static bool operator != (Student firstStudent, Student secondStudent)
        {
            return !Student.Equals(firstStudent, secondStudent);
        }


        Object ICloneable.Clone()
        {
            return this.Clone();
        }
        public Student Clone()
        {
            Student clone = new Student(
                this.FirstName,
                this.MiddleName,
                this.LastName,
                this.Ssn,
                this.PermanentAddress,
                this.MobilePhone,
                this.Email,
                this.Course,
                this.Speciality,
                this.Faculty,
                this.University);
            return clone;
        }



        public int CompareTo(Student other)
        {
            string thisFullName = string.Format("{0}{1}{2}", this.FirstName, this.MiddleName, this.LastName);
            string otherFullName = string.Format("{0}{1}{2}", other.FirstName, other.MiddleName, other.LastName);

            int namesCompareResult = string.Compare(thisFullName, otherFullName);

            if (namesCompareResult != 0)
            {
                return namesCompareResult;    
            }
            else
            {
                int ssnCompareResult = string.Compare(this.Ssn, other.Ssn);
                return ssnCompareResult;
            }
        }

    }
}
