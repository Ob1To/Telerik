namespace Task_4_PersonInfo
{
    public class Person
    {
        private string name;

        private byte? age;

        public Person(string name)
        {
            this.Name = name;
        }
        public Person(string name, byte? age) : this(name)
        {
            this.Age = age;
        }


        public byte? Age
        {
            get { return age; }
            set 
            { 
                age = value; 
            }
        }
        

        public string Name
        {
            get { return name; }
            set 
            { 
                name = value; 
            }
        }

        public override string ToString()
        {
            if (this.Age == null)
            {
                return string.Format("{0} - Age is null !",this.Name);
            }
            else
            {
                return string.Format("{0} - Age of {1}", this.Name, this.Age);
            }
        }
    }
}
