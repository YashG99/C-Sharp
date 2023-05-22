namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance Example");

            //Base Class
            BaseClass baseClass = new BaseClass();
            Console.WriteLine(baseClass.BaseName);

            //Single-level Inheritance
            SingleInheritedClass singleInheritedClass = new SingleInheritedClass();
            Console.WriteLine(singleInheritedClass.BaseName);
            Console.WriteLine(singleInheritedClass.SingleName);

            //Multi-level Inheritance
            FirstMultiInheritedClass firstMultiInheritedClass = new FirstMultiInheritedClass();
            Console.WriteLine(firstMultiInheritedClass.BaseName);
            Console.WriteLine(firstMultiInheritedClass.SingleName);
            Console.WriteLine(firstMultiInheritedClass.MultiName);

            //Heirarchical Inheritance
            SecondMultiInheritedClass secondMultiInheritedClass = new SecondMultiInheritedClass();
            Console.WriteLine(secondMultiInheritedClass.BaseName);
            Console.WriteLine(secondMultiInheritedClass.SingleName);
            Console.WriteLine(secondMultiInheritedClass.MultiName);

            ThirdMultiInheritedClass thirdMultiInheritedClass = new ThirdMultiInheritedClass();
            Console.WriteLine(thirdMultiInheritedClass.BaseName);
            Console.WriteLine(thirdMultiInheritedClass.SingleName);
            Console.WriteLine(thirdMultiInheritedClass.MultiName);
        }
    }

    public class BaseClass
    {
        public string BaseName { get; set; } = "BaseName";
    }

    public class SingleInheritedClass : BaseClass 
    {
        public string SingleName { get; set; } = "SingleName";
    }

    public class FirstMultiInheritedClass : SingleInheritedClass
    {
        public string MultiName { get; set; } = "FirstMultiName";
    }

    public class SecondMultiInheritedClass : SingleInheritedClass
    {
        public string MultiName { get; set; } = "SecondMultiName";
    }

    public class ThirdMultiInheritedClass : SingleInheritedClass
    {
        public string MultiName { get; set; } = "ThirdMultiName";
    }
}