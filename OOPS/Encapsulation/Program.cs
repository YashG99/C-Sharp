namespace Encapsulation
{
    //Encapsulating all the properties for a Person together.
    //Access modifers control accessability of these properties to the outside world (as shown in the example below)
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
    }

    public class BaseClass
    {
        public string publicVariable = "public";
        private string privateVariable = "private";
        protected string protectedVariable = "protected";
        internal string internalVariable = "internal";
        internal protected string internalProtectedVariable = "internal protected";

        public void TestVariableAccess()
        {
            Console.WriteLine("BaseClass:");            

            //Accessible variables:
            Console.WriteLine(publicVariable);
            Console.WriteLine(privateVariable);
            Console.WriteLine(protectedVariable);
            Console.WriteLine(internalVariable);
            Console.WriteLine(internalProtectedVariable);

            //Non-accessible variables:
            //None
        }
    }

    public class DerivedClass : BaseClass
    {
        public new void TestVariableAccess()
        {
            Console.WriteLine("DerivedClass:");

            //Accessible variables:
            Console.WriteLine(publicVariable);
            Console.WriteLine(protectedVariable);
            Console.WriteLine(internalVariable);
            Console.WriteLine(internalProtectedVariable);

            //Non-accessible variables:
            //Console.WriteLine(privateVariable);
        }
    }

    public class NonRelatedClass
    {
        public void TestVariableAccess()
        {
            Console.WriteLine("NonRelatedClass:");

            BaseClass baseClass = new BaseClass();
            //Accessible variables:
            Console.WriteLine(baseClass.publicVariable);
            Console.WriteLine(baseClass.internalVariable);
            Console.WriteLine(baseClass.internalProtectedVariable);

            //Non-accessible variables:
            //Console.WriteLine(privateVariable);
            //Console.WriteLine(baseClass.protectedVariable);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Encapsulated properties are available, if accessible
            Person person = new Person
            {
                FirstName = "Bart",
                LastName = "Simpson",
                DateOfBirth = new DateTime(2010, 01, 01)
            };

            //Access modifiers
            BaseClass baseClass = new BaseClass();
            baseClass.TestVariableAccess();

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.TestVariableAccess();

            NonRelatedClass nonRelatedClass = new NonRelatedClass();
            nonRelatedClass.TestVariableAccess();
        }
    }
}