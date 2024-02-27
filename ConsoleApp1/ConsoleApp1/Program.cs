// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

public interface IAccount //this is a simple interface that our program can use to make accounts
{
    public bool SetName(string inputUserName);
    public bool Withdraw(int amount);
    public bool Deposit(int amount);
    }
class Account
{
    private string fullname;
    private int age;
    private string stateOfOrigin;
    public Account(string userName, int userAge, string userState)//constructors cannot return anything they just initialize or run a bit of code when the class is created
    {
        fullname = userName;
        age = userAge;
        stateOfOrigin = userState;
        Console.WriteLine("This is" + fullname);
        Console.WriteLine("They are " + age + "years old");
        Console.WriteLine("They are from " + stateOfOrigin);
    }
}

class Bank
{
    private int Balance;
    private static int maxWithdrawal;//using statiic permanently store variable for all instances it is now a member
    public bool Withdraw(int Amount){
        if(Balance < Amount)
        {
            return false;
        }
        Balance -= Amount;
        return true;
       }
     
    public void Deposit(int Amount)
    {
        Balance += Amount;
    }
    
    public int GetAmount()
    {
        return Balance;
    }

    public void SetMax(int Amount)
    {
        maxWithdrawal = Amount;

    }
     
    public int ReturnMax()
    {
        return maxWithdrawal;
    }
    
    static public void StaticMethodTest(string Output)//this is an example of static methods
    {
        Console.WriteLine(Output);
    }
}
class Program
{
    enum TrafficLights
    {
        Red,
        Amber,
        Green,
        Disabled
    };

    enum AccountState
    {
        New,
        Blocked,
        Frozen,
        Deactivated
    };

    struct Account
    {
        public string FullName;
        public int Age;
        public AccountState CurrentState;
        public int CurrencyAmount;
        public string Address;
    };
    static void Main()
    {
        /*
        Console.Write("Enter a string: ");
        string userInput = Console.ReadLine();

        string reversedString = ReverseString(userInput);
        Console.WriteLine("Reversed string: " + reversedString);
        */

        //Testing out the writeline formatting
        /*
        long i = 947;
        double j = 123.45;
        Console.WriteLine("i : {0,3} , j : {1,6}", i, j);
        Console.ReadLine();
        //{0,15:0.00} {1,-15:0.00}



        //out and ref are used for the parameters of functions to modify them accordinly
        Console.Write("Enter you name please:");
        string UserName = Console.ReadLine();
        Console.Write("Enter your year of birth:");
        string UserAgeText= Console.ReadLine();
        int UserAge = int.Parse(UserAgeText);
        ModifyMembers(ref UserName, ref UserAge);
        Console.WriteLine("You are now " + UserName + "and your year is " + UserAge);

        arrays:
        int [,] squareWeights = new int [3,3] { {1,0,1}, {0,2,0}, {1,0,1} };
        
        try
        {
            //your code here
        }
        catch or catch(Exception e)
        {
            //your code also should be here
        }
        finally
        {

        }
        
        throw new Exception("Kablamo"); // needs to be in the try and catch block

        switch (command) 
             { 
                case "casement" : 
                case "c" :
                            handleCasement (); 
                            break ; case "standard" : case "s" : handleStandard () ; break ; case "patio" : case "P" : handlePatio () ; break ; default : Console.WriteLine ( "Invalid command" ) ; break ; }
        
        StreamWriter writer;
        string path = @"C:\Users\user\Documents\Csharp work\ConsoleApp1\test.txt";
        writer = new StreamWriter(path);
        writer.WriteLine("hello world");
        writer.Close();
        StreamReader reader = new StreamReader(path);
        while (reader.EndOfStream == false)
        { 
            string line = reader.ReadLine();
            Console.WriteLine(line); 
        }
        reader.Close();


        //Testing out enums for the first time
        TrafficLights TrafficPole;
        TrafficPole = TrafficLights.Red;
        if (TrafficPole == TrafficLights.Red)
        {
            Console.WriteLine("Stop your vehicle imdiately");
        }

        
        Account NewAccount;
        //To create a list of structures: Account[] NewAccount =  New Account[10]
        NewAccount.FullName = "Bamijoko Oluwasyifunmi";
        NewAccount.Age = 18;
        NewAccount.CurrentState = AccountState.New;
        NewAccount.Address = "Galadimawa round about";
        NewAccount.CurrencyAmount = 100000000;

        Console.WriteLine("Bank of Edo:");
        Console.WriteLine("Full Name: "+ NewAccount.FullName);
        Console.WriteLine("Age: "+NewAccount.Age);
        Console.WriteLine("Current State: " +NewAccount.CurrentState);
        Console.WriteLine("Currency amount: {0:0000,000.00}", NewAccount.CurrencyAmount);
        
        //encapsulation example
        Bank NewAccount = new Bank();
        NewAccount.Deposit(100000000);
        NewAccount.Withdraw(99);
        Console.WriteLine("Your current balance is: ${0:000,000}", NewAccount.GetAmount());
        NewAccount.SetMax(500);
        Console.WriteLine("The max for this account is:" + NewAccount.ReturnMax());

        Bank AnotherAccount = new Bank();
        AnotherAccount.Deposit(2000000);
        AnotherAccount.Withdraw(4000);
        Console.WriteLine("Your current balance is: ${0:000,000}", AnotherAccount.GetAmount());
        Console.WriteLine("The max for this account is:" + AnotherAccount.ReturnMax());
        Console.WriteLine("After changing the max using \"AnotherAccount\":");
        AnotherAccount.SetMax(250);
        Console.WriteLine("The max for this account is:" + NewAccount.ReturnMax());

        Bank.StaticMethodTest("This is now the ouput from out newly created static method");//static methods most use staic variables
        

        //test = new Account();,this is a constructor method called whenever we use a class to create a new object
        //constructors can also take in info that the class might need when 
        Account Person1;
        Person1 = new Account("John Thomas", 18, "kogi");//it's is supposed to work but it isn't

        //we can creae overloads by creating constructors with different parameters
        SetDate ( int year, int month, int day )
        SetDate ( int year, int julianDate )
        SetDate ( string dateInMMDDYY )

        //A simple call selects the the right constructor for the job
        SetDate(2004,12,1);

        //the "this" means another constructor in this class
        public Account (string inName, string inAddress, decimal inBalance)
        { 
            name = inName; address = inAddress; balance = inBalance; 
        }
        public Account (string inName, string inAddress) 
        { 
            name = inName; address = inAddress; balance = 0; 
        }
        public Account (string inName) 
        {
            name = inName; address = "Not Supplied"; balance = 0; 
        }

        //we can instead use this to reduce the redundancy of copying code
        public Account (string inName, string inAddress, decimal inBalance)
        {
            string name = inName;
            string address = inAddress;
            decimal balance = inBalance;
        }
        public Account (string inName, string inAddress) : this(inName, inAddress, 0)
        {
        }
        public Account (string inName) : this(inName, "Not Available", 0)
        {
        }

        //we can also throw and catch exceptions to prevent invalid data
        public Account (String inName, string inAddres, decimal inBalance)// simple cconstructor
        {
            if(SetName(inName) == false)
            {
                throw new Exception("Badn name:" + inName);
            }
        }
        
        //we can create interface that set down the foundations for what our program can do.
        //it can do other things, but these just show what it can do
        //we also add capital letter I to the begining of objects
        //to make classes using the IAccount interface we simply inherit the interface
        //class account : IAccount{}
        //it can be used as a type when creating arrays of classes/objects
        //very usefull for insterting classes that inherited from this interface, thus creating variety
        //accounts array can hold references to any object that implements the IAccount interface.
        //classes can also contain multiple instances
        //class account : IAccount,IWarning{}


        //we can make life easier for us without block copying by using inheritance:
        //public class BabyAccount : Account, IAccount{}
        // we can use the keyword "override when we want to change the method of a class
        //that we inherited from
        public class BabyAccount : Account, IAccount 
    { 
        public override Setname(string inputUserName)
        {

        }
    }
        //for overrides to work, we need to make the method we are overrideing "virtual"

        //with the override statement, however, we cannot change private variables that are used by the methods we overrided
        //to reduce the amount of protection used by these "private" methods, we use the keyword "protected"
        //since they are in the same class hierarchy

        //if we still want to use the original method we overrode from we can use the "base" keyword
        public override Setname(string inputUserName)
        {
            if(intputUserName == "Margret"){
                KillProram();
            }
            base.Setname(intputUserName);//uses the original piece of code
        }
        //this solves the issues of having to make a private code protected
        //since we can just use the original code

        //but if we still want to recreate the a method with the same namespace from scratch, without having to
        //override a method, we use the keyword "new"
        public new Setname(string inputUserName)
        {
            //New stuff that wasn't in the original
        }
        //this reduces the need to go back and forth to refernce to the original method
        
        //the "sealed" keyword can prevent a method from being overided and it can also be used for classes
        //to prevent them from being used as the basis for other classes through inheritance

        //to use constructors for classes that were inherited, we have to use "base" keyword for them
        public CustomerAccount (string inName, decimal inBalance) : base ( inName, inBalance)
        {
            // set the name and the balance here 
        }

        //C# provides a way of flagging a method as abstract. 
        //This means that the method body is not provided in this class, but will be provided in a child class:
        public abstract class Account 
        { 
            public abstract string RudeLetterString(); 
        }

        //created is the indirect child class of the object class
        //with this we have inbuilt methods that we can modify
        //An example of this method is the "ToString" method
        //It return a string by default which is the hiararchy of our class
        public class BabbyAccount
        {
            public override string ToString()//we can modify this to our heart's desire
            {
                return "This is an account designed for those younger than 7. It contains the main variables...";
            }
        }
        //to return the base "Tostring" method of the the overriden method we do this
        public override string ToString()//we can modify this to our heart's desire
            {
                return base.ToString();
            }

        
        //we can also change our built in "Equals" method for the class
        //and change it to check if any object or any other items are equal
        //we can create a new method, but this is just better

        //"this", as in this.data, is used to refer to methods and variables that are part of the class
        //cs normally does this automatically but its good to do it for the sake of others that are
        //reading your work

        //strings are immutable, they create new memory spaces when they are moved from their original reference
        string s1="Rob";
        string s2=s1;
        s2 = "different";
        Console.WriteLine(s1 + " " + s2);
        
        //you can also compare strings like you can with values since they are hybrids
        if ( s1 == s2 ) 
        { 
            Console.WriteLine("The same"); 
        }
        //other string properties:
        //one can take the individual character of each array like strings:
        string Name = "Aron";
        char FirstChar = Name[0];
        //we can also get subtsrings from them
        string NewName = Name.Substring(1,2);
        //we can also simply get their length
        int NameLength = Name.Length();
        //we can change all to upper case using:
        Name.ToUpper();
        //and we can trim trailing spaces and new lines using
        Name.Trim();

        //properties are the variables that can be defaultly used and set by a class
        //"private" can be changed using public methods in the class to change it
        //but instead of using two methods to change this properties we can use "get" and "set" methodsin a variable
        public class StaffMember
        { 
            private int ageValue;
            public int Age//It can be renamed as "AgeValue" to reduce confusion
            {  
                set 
                { 
                    if ( (value > 0) && (value < 120) ) 
                    { 
                    this.ageValue = value; 
                    } 
                } 
                get 
                {  
                return this.ageValue; 
                } 
            } 
        }
        //we can modify the get modifier to our hearts desire

        //A delegate is a type safe reference to a method in a class.
        //it needs the same return type and same number and type of parameters
        public delegate decimal CalculateFee (decimal balance);//outside of classes since we need to obv use them outside
        //we can have two methods that have the same parameters and returns, but their context is different 
        public decimal RipoffFee (decimal balance){}
        public decimal FriendlyFee (decimal balance){}
        //we can now do this
        CalculateFee calc = new CalculateFee(RipoffFee);
        fees = calc(100);
        //if we want to change to the method
        calc = new CalculateFee (FriendlyFee);
        //both method might have to be static inorder to call the methods without creating a object

        //we can create arrays of classes to make it easier to store large information

        //cs provides us with a Hashtable type that can be used to efficiently store information
        Hashtable Newtable = new Hashtable();
        Newtable[Key];
        Newtable.add(key,value);

        //"as" is just another way of casting
        string NewString = SetName(Name) as string;
        string Newstring = (string) SetName(Name);

           
        //---------------- ADVANCED CS ----------------//
        //ArrayList is another inbuilt Systems.Collections object that serves as an expandable means of
        //storing information compared to using normal arrays
        ArrayList Store = new ArrayList();//It doesn't need a definite amount
        ArrayList StoreFifty = new ArrayList(50);//It can store fifty references or more
        //the "Add" method doesn't store the object directly, it stores the reference intstead
        Store.Add(RobsAccount);
        //we access the members like a normal array, but we have to cast out its type to use it
        Account RobsAccount = (Account) Store[0];//just a reference not the actual object
        //and we can simply remove it if we please
        Store.Remove(RobsAccount);
        //we a can also get the size of our array list
        Store.Count();
        //checking if a reference is available is also possible
        Store.Contains(RobsAccount);
        //It is not TypeSafe so it can hold any type of reference when compared to normal arrays

        //Generics is the idea of having the implementing the general behaviours or code for an object
        //without actually knowing the objects type
        //it's like having a system to divide things among your siblings, without specifying 
        //what those things are, it can be anything
        //Generics (Generilization) is just another form of abstraction
    
        //What the list stores is not important when making the list, just as long as you have a way of telling it what to store.
        List<Account> accountList = new List<Account>();
        //Hence we have told it not to store anything apart from list
        KitchenSink NewSink = new KithcenSink();
        accountList.Add(NewSink)//this is no longer possible since our list only store Account types
        //Since the list now what exactly it is holding, it can do this:
        accountList.[0].PayInAmount(70);
        //unlike ArrayLists, Normal, List can be TypeSafe

        //The Dictionary is the more powerfully ehanced version of the HashTable
        Dictionary<string,Account> accountDictionary = new Dictionary<string,Account>();//Means that we only deal with strings as keys and objects
        accountDictionary.Add("Rob", robsAccount);
        //this means that this is not allowed:
        KitchenSink k = new KitchenSink();
        accountDictionary.Add("Glug", k);
        //Since it's TypeSafe, we can also do this:
        accountDictionary["Rob"].PayInFunds(50);
        //we can check if a key is in a certain dictionary using this:
        accountDictionary.ContainsKey("Rob"));
        //Unkike HashTable, ArrayLists and Lists, Dictionaries, don't allow us to have the same key
        

        //^^^^^^^^^^^^^Threads^^^^^^^^^^^^^//
        //Threads are a feature of csharp that allows us to assign computing tasks to the cores of our processors
        //This allows to split tasks into to and it allows for our program to run and complete processes faster
        //To use threads we need to use delegates that containg the starting position of out thread
        ThreadStart busyLoopMethod = new ThreadStart(busyLoop);
        //we then assign this delegate to the a a thread
        Thread t1 = new Thread(busyLoopMethod);
        t1.Start();
        //we can use two threads, but without synchronization both threads will fight for the same variables
        //We need an object token that is constantly monitored
        static object sync = new object();
        Monitor.Enter(sync); 
        overDraftCount = overDraftCount + 1;
        Monitor.Exit(sync);
        //To pause our program using threads and not using for loops, we can do this:
        thread.Sleep(500);//Read in thoudandth of seconds
        //the join methods makes executing threads to wait for thread that called it to finish before they can continue on
        t1.Join();
        //we can stop a thread immediately by using its abort method
        t1.Abort();
        //it destroy the thread and removes it from memory permanently 
        //if we don't want to destroy and just pause it temporarily we use the suspend method
        t1.Suspend();
        //and we can simply resume
        t1.Resume();

        //we can find the state of thread using enumerated values given by the ThreadState method
        //here are the values:
        ThreadState.Running;
        ThreadState.Stopped;
        ThreadState.Suspended;
        ThreadState.WaitSleepJoin;

        //^^^^^^^^^^^^Porcesses^^^^^^^^^^^^//
        //Prcesses are different from threads, in the fact that processes are a colllection of threads
        //"calculator.exe" is an example of a process
        //Processes can not directly access the threads of another process
        using System.Diagnostics;
        Process.Start("Notepad.exe");//starts a program on our system

        //^^^^^^^^^^^^Exceptions part 2^^^^^^^^^^^^//
        public class BankException : System.Exception 
            {
            public BankException (string message) : base (message) 
                { 
                } 
            }
        //we can use this custom exception in our code like this:
        if ( inName.Length == 0 ) 
            { 
                throw new BankException( "Invalid Name" ); 
            }

        //And when catch the same exception we threw
        try 
            { 
                a = new Account(newName, newAddress); 
            } 
        catch (BankException exception) 
            { 
                Console.WriteLine( "Error : " + exception.Message); 
            }
        catch (System.Exception exception )//we use the system default catch to catch exceptions that can't
        //be caught we our custom exceptions
            {
                Console.WriteLine("System exception : " + exception.Message); 
            }

        //^^^^^^^^^Creating libraries and source files^^^^^^^^^//
        csc /target:library AccountManagement.cs
        //the above command creates an AccountManagement.dll fill, which is a dynamically linked library file
        //that stores the class in a library
        //Programs that need to use these libraries need to directly use these classes can reference them
        csc /reference:AccountManagement.dll AccountTest.cs//the cs code being the target of this refernce
        //issues can occur when two different classes that share the same name use the globalnamespace
        //to solve this issue we encapsulate these classes in into namespaces
        namespace CustomerBanking
        {
            public class Account(){}
        }
        //we can different these accounts easily
        CustomerBanking.Account RobsAccount = new CustomerBanking.Account();
        Stationeries.Account ClarksAccount = new Stationeries.Account();
        //We can avoid clutter if these classes share different namespaces by using the keyword "using"
        using CustomerBanking;
        //if it has two classes that share the same name, it will complain that it doesn't now
        which one to use
        //you can also break down namespaces into smaller fractions like this:
        using CustomerBanking.Accounts;
        //and the namespaces and classes will look like this
        namespace CustomerBanking 
        { 
            namespace Accounts 
            { 
                // account classes go here 
            } 
            namespace Statements 
            { 
                // statement classes go here 
            } 
            namespace RudeLetters 
            { 
                // rude letter classes go here 
            }
        }


        */

        static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void ModifyMembers(ref string name, ref int date)
        {
            name = "John Thomas";
            date += 1000;
        }
    }
}
