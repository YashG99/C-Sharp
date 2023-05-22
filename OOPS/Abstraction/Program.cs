namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstraction Example");

            Person person = new Person
            {
                FirstName = "Homer",
                LastName = "Simpson",
                DateOfBirth = new DateTime(1986, 1, 14)
            };

            //Implementation details for calculating Full Name and Age has been abstracted (hidden) from this class 
            if(person.FullName != null) 
                Console.WriteLine("FullName: " + person.FullName);
            if(person.Age != null)
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

        public string? FullName
        {
            get
            {
                return CalculateFullName();
            }
        }

        public int? Age
        {
            get
            {
                return CalculateAge();
            }
        }

        private string? CalculateFullName()
        {
            if(string.IsNullOrWhiteSpace(firstName) && string.IsNullOrWhiteSpace(lastName))
            {
                Console.WriteLine("Invalid first and last names.");
                return null;
            }
            return string.Format("{0} {1}", firstName, lastName).Trim();
        }

        private int? CalculateAge()
        {
            if(dateOfBirth > DateTime.Now)
            {
                Console.WriteLine("Invalid date.");
                return null;
            }

            var age = DateTime.Now.Year - dateOfBirth.Year;
            if (dateOfBirth > DateTime.Now.AddYears(-age))
                age--;
            return age;
        }
    }
}