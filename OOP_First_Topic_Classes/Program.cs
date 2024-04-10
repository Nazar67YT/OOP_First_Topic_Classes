

using Microsoft.Win32.SafeHandles;
using OOP_First_Topic_Classes;
using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

//partial class Car {

//    public string name { get; set; }
//    public string kraine {get;set;}
//    public int rik { get; set; }
//    public int speed;

//    public Car (string name, string kraine, int rik, int speed)
//    {
//        this.name = name;
//        this.kraine = kraine;
//        this.rik = rik;
//        this.speed = 90;
//    }


//    public void print() {
//        Console.WriteLine($"Ім'я: {name}, Країна: {kraine}, Рік: {rik}");

//    }
//}

//partial class Car {

//    public int UpSpeed(int delta) {

//        for (int i = 0; i < 5; i++)
//        {
//            delta += 10;
//        }
//        return delta;
//    }

//}

//class User
//{
//    string name;
//    int age;
//    string mail;

//    public User (string x,int y,string u)
//    {
//        this.name = x;
//        this.age = y;
//        this.mail = u;




//    }
//    public void Print()
//    {
//        Console.WriteLine($"Name:{name},Age:{age},Mail:{mail}");
//    }




//}
//class corustyvach
//{
//    public string name ;
//    public int age ;
//    public string avtor ;

//    public corustyvach(int x,string y,string u)
//    {

//        this.age = x;
//        this.name = y;
//        this.avtor = u;



//    }
//    public void Print() 
//    {
//        Console.WriteLine($"Name:{name},Age:{age},Author:{avtor}");




//    }





//}


//class Employee
//{
//    string _firstName;
//    public string FirstName {
//        get { return _firstName != null ? _firstName : "not writed"; }
//        set { _firstName = value.ToUpper(); }

//    }
//    string _lastName;
//    public string LastName {
//        get { return _lastName != null ? _lastName : "not writed"; }
//        set { _lastName = value.ToUpper(); }
//    }

//    public int age { get; set; } = 0;

//    public int ID { get; set; } = 1;



//    public string Print() {
//        return $"Name : {FirstName}, Lastname : {LastName}";
//    }
//}






//class rahynok
//{
//    public int number;
//    public int balance;
//    public rahynok(int x, int y)
//    {

//         this.number = x;
//         this.balance = y;



//    }

//    public int add(int x) { balance += x; return balance; }
//    public void Print()
//    {
//        Console.WriteLine($"Number:{number}, Balance:{balance}");




//    }
//    public void PrintBalance()
//    {
//        Console.WriteLine($"Balance:{balance}");




//    }



//}
//class rectangle
//{
//    public int x;
//    public int y;
//    public void Print(int x, int y)
//    {
//        Console.WriteLine(x*y);

//    }






//}
//class Calculator 
//{ 
//    public double add (double x,double y)
//    {
//        return x + y;
//    }
//    public double miltiply(double x, double y)
//    {

//        return x * y;
//    }
//    public double divide (double x, double y)
//    {

//        return x / y;
//    }
//    public double minus(double x, double y)
//    {
//        return x - y;
//    }





//}



public class Point2D<T> {

    public T x { get; set; }

    public T y { get; set; }


    public Point2D(T x, T y) {
        x = x;
        y = y;
    }
    public Point2D()
    {
        x = default(T);
        y = default(T);
    }
}




class OOP_First_Topsc_Classes {


    public static void Main(string[] args)
    {

        ArrayList arlist = new ArrayList();
        arlist.Add("One");
        arlist.Add("two");
        Console.WriteLine("before coping");
        foreach(var index in arlist)
        {
            Console.WriteLine(index);

        }
        Console.WriteLine(arlist.Count);

        object[] arr = new object[arlist.Count];
        arlist.CopyTo(arr,0);

        Console.WriteLine("Copied :");
        foreach (var index in arr) {
            Console.WriteLine(index);
        }
        Console.WriteLine();
        Dictionary<string, int> ageMap = new Dictionary<string, int>();
        ageMap["John"] = 30;
        ageMap["Alice"] = 25;
        ageMap["Bob"] = 35;


        foreach (var index in ageMap)
        {
            Console.WriteLine( $"{index.Key} :  {index.Value}");

        }






























        /*
      //  Users user1 = new Users(/* data *///);
       // string InputLogin = "213123";
       // int InputPassword = 12341;
      //  try
       // {
            /*string InputLogin = "213123";
        int InputPassword = 12341;
        }
        catch (Exception) {
            Console.WriteLine("Something go wrong , try again");
        }
        if (user1.login == InputLogin && user1.password == InputPassword ) {
            Console.WriteLine("you login");


        }

        Interface inf = new Interface();
        inf.printMenu();


        Home h1= new Home();
        h1.s = "asdf";

        Point2D<int>p1= new Point2D<int>();
        Console.WriteLine($"x = {p1.x}, y = {p1.y}");

        Console.WriteLine(typeof(Point2D<int>));


        Point2D<double> p2 = new Point2D<double>();
        p2.x = 10.5;
        p2.y = 13.7;

        Console.WriteLine($"x = {p2.x}, y = {p2.y}");

        Console.WriteLine(typeof(Point2D<double>));




        object obj = 45;
        Console.WriteLine($"Упаковка: {obj} ");

        int number = (int)obj;
        Console.WriteLine($"Розпаковка {number}");

        //List<int> Userindex = new List<int> { 1, 9, 73, 56, 8, 6 };
        //int usernumber = Convert.ToInt32(Console.ReadLine());

        //try
        //{
        //    if (usernumber >= Userindex.Count())
        //    {
        //        throw new IndexOutOfRangeException("You bounded of the range");

        //    }
        //    Console.WriteLine(Userindex[usernumber]);

        //}
        //catch (IndexOutOfRangeException e) { Console.WriteLine(e.Message); }


        */












        //int usernumber = Convert.ToInt32(Console.ReadLine());
        //int usernumber2 = Convert.ToInt32(Console.ReadLine());
        //try
        //{
        //    if (usernumber == 0|| usernumber2 == 0)
        //    {
        //        throw new DivideByZeroException("You can`t divide by zero");
        //    }
        //    Console.WriteLine(usernumber/usernumber2);

        //}
        //catch (DivideByZeroException e) { Console.WriteLine(e.Message); }
        //try
        //{
        // Console.WriteLine("Enter first number");

        // double UserNumber = Convert.ToDouble(Console.ReadLine());
        // Console.WriteLine("Enter you want 1:+,2:-,3:*,4:/");
        // int UserNumber3=Convert.ToInt32(Console.ReadLine());                        
        // Console.WriteLine("Enter second number");
        // double UserNumber2 = Convert.ToDouble(Console.ReadLine());
        //    if (UserNumber == 0 || UserNumber2 == 0)
        //    {
        //        throw new DivideByZeroException("You can`t divide by zero");

        //    }

        //    if (UserNumber3 < 1|| UserNumber3 > 4 )
        //    {
        //        throw new Exception ("Error You entered incorrect format");

        //    }
        //    if (UserNumber3 == 1)
        //    {
        //        Console.WriteLine(UserNumber + UserNumber2);
        //    }

        //    else if (UserNumber3 == 2)
        //    {
        //        Console.WriteLine(UserNumber - UserNumber2);
        //    }
        //    else if (UserNumber3 == 3)
        //    {
        //        Console.WriteLine(UserNumber * UserNumber2);
        //    }
        //    else if (UserNumber3 == 4)
        //    {
        //        Console.WriteLine(UserNumber / UserNumber2);
        //    }




        //}

        //catch (FormatException) { Console.WriteLine("Error You entered incorrect format"); }
        //catch (DivideByZeroException e) { Console.WriteLine("Error" + e.Message); }
        //catch (Exception) { Console.WriteLine("Something go wrong "); }

        //int[] Array = { 1, 2, 3, 4, 5, 6, 8, 9, 10, 71 };
        //int UserNumber;
        //try
        //{
        //    UserNumber = Convert.ToInt32(Console.ReadLine());
        //    for (int i = 0; i < Array.Length; i++)
        //    {

        //     if (UserNumber == Array[i])
        //        {
        //            Console.WriteLine(i);

        //            break;
        //        }

        //    }
        //    throw new Exception("Error");







        //}
        //catch (Exception) { Console.WriteLine(); }


        //string password;
        //try
        //{
        //    password = Convert.ToString(Console.ReadLine());
        //    if (password.Length <= 8) { throw new Exception("Lenght in your password less then 8"); }
        //    Console.WriteLine(password.Length);
        //}
        //catch (Exception e) { Console.WriteLine(e.Message); }
        //int x;
        //int y;
        //try
        //{
        //    x = Convert.ToInt32(Console.ReadLine());
        //    y = Convert.ToInt32(Console.ReadLine());
        //    if (x == 0 || y == 0)
        //    {
        //        throw new DivideByZeroException("You cant divide by zero");



        //    }
        //    else
        //    {

        //        Console.WriteLine(x/y);
        //    }


        //}


        //int u;
        //try
        //{
        //    u = Convert.ToInt32(Console.ReadLine());
        //    if (u == 0)
        //    {
        //        throw new DivideByZeroException("You cant divide by zero");



        //    }
        //if (u%2!=0)
        //{
        //    throw new Exception("You enter not twin number");


        //}
        //Console.WriteLine(u / 2);



        //}
        //catch (DivideByZeroException e) { Console.WriteLine(e.Message); }
        //catch (Exception ) { Console.WriteLine("Error"); }

        //int x;
        ////  int y = Convert.ToInt32(Console.ReadLine());

        //int[] arr = new int[5];
        //for(int i = 0;i < arr.Length; i++)
        //{

        //    x = Convert.ToInt32(Console.ReadLine());
        //    arr[i] = x;
        //    if (arr[i] == 0)
        //    {
        //        throw new Exception("Value in Array can not be zero");
        //    }

        //int x ;
        //try
        //{
        //    x = 10;

        //    if (x == 0)
        //    {
        //        throw new ArgumentNullException("X cen not be zero");
        //    }
        //    if (x < 10)
        //    {
        //        throw new ArgumentException("ArgumentException");
        //    }


        //}
        //catch (ArgumentNullException e)
        //{
        //    Console.WriteLine("Error : " + e.Message);
        //}
        //catch (ArgumentException e)
        //{
        //    Console.WriteLine("Error : " + e.Message);
        //}
        //finally
        //{
        //    Console.WriteLine("Program is ended");
        //}
        //Console.WriteLine(" 1 ");
        //if (y == 0)
        //{

        //    throw new Exception("You can not divide by zero");
        //}
        //else
        //{
        //    Console.WriteLine(x / y);
        //}
        //{
        //    User user = new User("Max", 17, "Max2007@gmail.com");
        //    rahynok rahynok = new rahynok(123456789,570);













        //    corustyvach corus = new corustyvach(1998,"Harry Potter","John");
        //    corus.Print();


        //double x = Convert.ToDouble(Console.ReadLine());
        //double y = Convert.ToDouble(Console.ReadLine());
        //Calculator calculator = new Calculator();
        //Console.WriteLine( calculator.add(x, y));
        //Console.WriteLine( calculator.minus(x, y));
        //Console.WriteLine( calculator.divide(x, y));
        //Console.WriteLine( calculator.miltiply(x, y));

        //  Console.WriteLine();
        //  rectangle rectan = new rectangle();
        ////  rectan.Print(6,3);

        //Employee emp1 = new Employee { FirstName = "Mark", LastName = "bob" };
        //Employee emp2 = new Employee();
        //emp2.FirstName = "Markus";

        //emp2.age = 10;

        //Console.WriteLine(emp1.Print());
        //Console.WriteLine(emp2.Print());

        //int spped = 90;
        //Car student = new Car("BMW", "Ukraine", 2021,spped);

        //student.print();
        //Console.WriteLine(student.UpSpeed(spped));




    }


}
