namespace EncapsulationExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Encapsulation Example");

            Person person = new Person
            {
                FirstName = "Homer",
                LastName = "Simpson",
                DateOfBirth = new DateTime(1986, 1, 14)
            };

            //Logic for calculating Full Name and Age has been encapsulated 
            Console.WriteLine("FullName: " + person.FullName);
            Console.WriteLine("Age: " + person.Age);
            Console.ReadKey();
        }
    }

    class Person
    {
        private string firstName = string.Empty;
        private string lastName = string.Empty;
        private DateTime dateOfBirth;

        public string FirstName
        {
            get => firstName;
            set { firstName = value; }
        }
        public string LastName
        {
            get => lastName;
            set { lastName = value; }
        }
        public DateTime DateOfBirth
        {
            get => dateOfBirth;
            set { dateOfBirth = value; }
        }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", firstName, lastName);
            }
        }

        public int Age
        {
            get
            {
                return CalculateAge();
            }
        }

        private int CalculateAge()
        {
            var age = DateTime.Now.Year - dateOfBirth.Year;
            if (dateOfBirth > DateTime.Now.AddYears(-age))
                age--;
            return age;
        }
    }
}