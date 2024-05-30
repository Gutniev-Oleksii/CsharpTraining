using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining
{
    public class ProgramOne
    {
        public static void Main(string[] args) // The entry point of the program where you call all the methods.
        {
            DrawPyramid1(7);
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Encapsulation.
            /*
            - Part of the meaning of the word encapsulation is the idea of "surrounding" an entity, 
            not just to keep what's inside together, but also to protect it.
            - In programming, encapsulation means more than simply combining members together within a class; 
            it also means restricting access to the inner workings of that class.
            - Encapsulation is implemented by using access modifiers. 
            - An access modifier defines the scope and visibility of a class member.
            */
            // (!) Encapsulation is also called information hiding. (!)
            /*
            - C# supports the following access modifiers: public, private, protected, internal, protected internal.
            - As seen in the previous examples, the public access modifier makes the member accessible from the outside of the class.
            - The private access modifier makes members accessible only from within the class and hides them from the outside.
            */
            // To show encapsulation in action, let’s consider the following example:
            BankAccount b = new BankAccount();
            b.Deposit(199);
            b.Withdraw(42);
            Console.WriteLine("Balance of the bank account is: " + b.GetBalance() + " $.");
            Console.WriteLine("\n");
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /* In summary, the benefits of encapsulation are:
            - Control the way data is accessed or modified.
            - Code is more flexible and easy to change with new requirements.
            - Change one part of code without affecting other parts of code. */

            // PRACTICE EXERCISE.
            /* 
            The program you are given should output the account number on the bank card.
            But something is wrong.
            Create a get property to access the corresponding class member and also fix the output.
            - In order to execute the output you should pass the property to Console.WriteLine() method.
            */
            Card card1 = new Card();
            Console.WriteLine("Card Acc #: " + "\"" + card1.AccountNum + "\".");
            Console.WriteLine("\n");
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /*
            Properties
            So, why use properties? Why not just declare the member variable public and access it directly?
            With properties you have the option to control the logic of accessing the variable.
            For example, you can check if the value of age is greater than 0, 
            before assigning it to the variable:

            class Person
            {
              private int age=0;
              public int Age
              {
                get { return age; }
                set {
                  if (value > 0)
                    age = value;
                }
              }
            }
            (!) - You can have any custom logic with get and set accessors. (!)
            */
            // Auto-Implemented Properties.
            /* 
            - When you do not need any custom logic, C# provides a fast and effective mechanism for declaring private members through their properties.
            - For example, to create a private member that can only be accessed through the Name property's get and set accessors, use the following syntax:

            public string Name { get; set; }
            - As you can see, you do not need to declare the private field name separately - it is created by the property automatically. Name is called an auto-implemented property. Also called auto-properties, they allow for easy and short declaration of private members.
            - We can rewrite the code from our previous example using an auto-property:
            class Person
                    {
                        public string Name { get; set; }
                    }
                    static void Main(string[] args)
                    {
                        Person p = new Person();
                        p.Name = "Bob";
                        Console.WriteLine(p.Name);
                    }
            */
            // PRACTICE EXERCISE.
            /* 
            You are making a social network application and want to add post creation functionality.
            As a user creates a post, the text "New post" should be automatically outputted so that then the user can add the text he/she wants to share.
            The program you are given declares a Post class with a text private field, and the ShowPost() method which outputs the content.
            Complete the class with
            - a constructor, which outputs "New post" as called,
            - Text property, which will allow you to get and set the value of the text field.

            Once you have made the changes to the program so that it works correctly, then in main, 
            the program will take the text of the post from the user, create a post object, assign the taken value to the text field and output it.

            Sample Input
            Hello!

            Sample Output
            New post
            Hello!

            Recall the value keyword for set accessor.
            */
            Console.WriteLine("Enter the message to your post: ");
            string postText = Console.ReadLine();

            Post post = new Post();
            post.Text = postText;
            post.ShowPost();
            Console.WriteLine("\n");
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // PRACTICE EXERCISE.
            /* 
            We are developing a profile system for player of our online game.
            The program already takes the number of games and wins as input and creates a player object.
            Complete the GetWinRate() method inside the given Player class to calculate and output the win rate.

            Sample Input
            130
            70

            Sample Output
            53

            Explanation
            Win rate is calculated by this formula: wins*100/games. So, in this case win rate is 70*100/130 = 53 (the final result should be an integer).

            Notice that you should execute the output of the win rate inside the method.
            */
            int games = 1;
            int wins = 0;
            try
            {
                // Read input and convert to integers
                games = Convert.ToInt32(Console.ReadLine());
                wins = Convert.ToInt32(Console.ReadLine());

                // Code to use the valid integer values of games and wins
                Console.WriteLine($"You played {games} games and won {wins} of them.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter only numbers.");
                // Optionally, ask the user to re-enter the input
            }
            catch (Exception ex) // Catch other potential exceptions
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }


            //creating the player object
            Player player1 = new Player();
            player1.games = games;
            player1.wins = wins;

            //output
            player1.GetWinRate();
            Console.WriteLine("\n");
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Constructors.
            /*
            - A class constructor is a special member method of a class that is executed whenever a new object of that class is created.
            - A constructor has exactly the same name as its class, is public, and does not have any return type.

            For example:
            class Person
            {
              private int age;
              public Person()
              {
                Console.WriteLine("Hi there");
              }
            }
            Now, upon the creation of an object of type Person, the constructor is automatically called.
            */
            /*
            - This can be useful in a number of situations. 
            - For example, when creating an object of type BankAccount, you could send an email notification to the owner.
            - The same functionality could be achieved using a separate public method. 
            - The advantage of the constructor is that it is called automatically.
            */
            // PRACTICE EXERCISE.
            /* 
            Your graphic application needs to report that a new project has been created successfully,
             once the "Create" button has been pressed.
            Complete the given class by adding a constructor that will show message "Project created",
             once the operation is done.
            - You need to execute the output inside the constructor.
            */
            Project project = new Project();  // Create a new Project object.
            Console.WriteLine("\n");
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        }

        private static void DrawPyramid1(int n2)
        {
            for (int i15 = n2; i15 >= 1; i15--)
            {
                for (int j2 = n2; j2 > i15; j2--)
                {
                    Console.Write("  ");
                }
                for (int k2 = 1; k2 <= 2 * i15 - 1; k2++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
    class BankAccount
    {
        private double balance = 0;
        public void Deposit(double n)
        {
            balance += n;
        }
        public void Withdraw(double n)
        {
            balance -= n;
        }
        public double GetBalance()
        {
            return balance;
        }
    }
    /*We used encapsulation to hide the balance member from the outside code. 
    - Then we provided restricted access to it using public methods. The class data can be read through the GetBalance method and modified only through the Deposit and Withdraw methods.
    - You cannot directly change the balance variable. You can only view its value using the public method. This helps maintain data integrity.
    - We could add different verification and checking mechanisms to the methods to provide additional security and prevent errors.*/
    class Card
    {
        private string accountNum = "0011592048120";
        public string AccountNum
        {
            get { return accountNum; }
            set { accountNum = value; }
        }
        //create a property to get the account

    }
    class Post
    {
        private string text;

        public Post()
        {  //write a constructor here.
            Console.WriteLine("New post: ");
        }

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public void ShowPost()
        {
            Console.WriteLine(text);
        }
    }
    //write a property for member text
    class Player
    {
        public int games;
        public int wins;
        //winrate is private
        private int winrate;

        //the method
        public void GetWinRate()
        {
            winrate = wins * 100 / games;
            Console.WriteLine($"Taking into account the amount of wins and games in general, your WinRate is: \"{winrate}\"" + "% .");
        }
    }
    class Project
    {
        public Project()  // Constructor is called when a new Project object is created.
        {
            Console.WriteLine("<\"Project created\">.");  // Print message inside the constructor.
        }
    }

    class Program
    {
        class Player2
        {
            private string name;
            public string Name  /* Once the property is defined, we can use it to assign 
                                and read the private member:
                                */
            {
                get { return name; }
                set { name = value; }
            }
        }
        class Person
        {
            int age;
            string name;
            public void SayHi()
            {
                Console.WriteLine(@"Hi," + "\"Welcome\"" + ".");
            }
        }
        /* 
        - Now that we have our Person class defined, 
        we can instantiate an object of that type in Main.
        */
        class Welcome
        {
            public void WelcomeMessage()
            {
                Console.WriteLine("  Welcome to OOP" + ".");
            }
        }
        class Man
        {
            private int age;
            private string name;
            public Man(string nm)
            {
                name = nm;
            }
            public string getName()
            {
                return name;
            }
        }

        class Dog
        {
            public string name;
            public int age;
        }
        /* Overloading method Print */
        static void Print(int a4)
        {
            Console.WriteLine("Value: " + a4);
        }
        static void Print(double a4)
        {
            Console.WriteLine("Value: " + a4);
        }
        static void Print(string label, double a4)
        {
            Console.WriteLine(label + a4);
        }
        /* Overloading method Add */
        static int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
        //overload it for double type.
        static double Add(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }
    }
}// Namespace.
