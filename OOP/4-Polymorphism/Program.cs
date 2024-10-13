using System;

namespace PolymorphismBasics
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    // Define the Cat class here
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows.");
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            // Create instances of derived classes
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            // Call the MakeSound method
            myDog.MakeSound(); // Output: Dog barks.
            myCat.MakeSound(); // Output: Cat meows.
        }
    }
}

//Console.WriteLine("-------------------------------------------Upcasting Objects-----------------------------------------------------------")

//using System;

//namespace PolymorphismBasics
//{
//    public class Employee
//    {
//        // Virtual method in the base class
//        public virtual void MakeHRRequest()
//        {
//            Console.WriteLine("Employee makes an HR request.");
//        }
//    }

//    public class Engineer : Employee
//    {
//        // Override the virtual method in the derived class
//        public override void MakeHRRequest()
//        {
//            Console.WriteLine("Engineer makes an HR request.");
//        }
//    }

//    public class Manager : Employee
//    {
//        // Override the virtual method in the derived class
//        public override void MakeHRRequest()
//        {
//            Console.WriteLine("Manager makes an HR request.");
//        }
//    }

//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            // Your code below
//            Manager myManager = new Manager();
//            Employee myEmployeeManager = myManager;
/*// */   //        myEmployeeManager.MakeHRRequest();

//Console.WriteLine("-------------------------------------------Downcasting Objects-----------------------------------------------------------")

//          Employee myEmployeeManager = new Manager();
//          Your code below
//          Manager myManager = (Manager)myEmployeeManager;
//          myManager.MoveToOffice();

//Console.WriteLine("-------------------------------------------Using 'is' Operators-----------------------------------------------------------")

//          Console.WriteLine(myEmployee is Engineer);
//          Console.WriteLine(myEmployee is Manager);

//Console.WriteLine("-------------------------------------------Using 'as' Operators-----------------------------------------------------------")

//        Employee myEmployeeEngineer1 = new Engineer();
//        Employee myEmployeeEngineer2 = new Engineer();

//        Engineer engineer = myEmployeeEngineer1 as Engineer;
//        Console.WriteLine(engineer == null);
//        Manager manager = myEmployeeEngineer2 as Manager;
//        Console.WriteLine(manager == null);


//        }
//    }
//}

//Console.WriteLine("-------------------------------------------Abstract Classes-----------------------------------------------------------")

//using System;

//namespace PolymorphismBasics
//{
//    // Your classes below
//    public abstract class Employee
//    {
//        public abstract void MakeHRRequest();

//        public void Promotion()
//        {
//            Console.WriteLine("Employee gets a promotion.");
//        }
//    }

//    public class Manager : Employee
//    {
//        public override void MakeHRRequest()
//        {
//            Console.WriteLine("Manager makes an HR request.");
//        }
//    }

//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            // Your manger variable below
//            Manager manager = new Manager();
//            manager.MakeHRRequest();
//            manager.Promotion();
//        }
//    }
//}

