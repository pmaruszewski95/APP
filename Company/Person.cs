namespace Security
{    
    public class Person
    {
        public Person(string _firstName, string _lastName, int _idNumber)
        {
            this.FirstName = _firstName;
            this.LastName = _lastName;
            this.IdNumber = _idNumber;
        }

        public string FirstName { get; }

        public string LastName { get; }

        public int IdNumber { get; }
    }
}
