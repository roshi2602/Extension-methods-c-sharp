using System;
using System.Text;
using ClassLibrary;

//class library is made for this
//extension methods allows additional methods without modifying the original class
//IsGreaterThan() is an extension method for int type
//An extension method is actually a special kind of static method defined in a static class.
//To define an extension method, first of all, define a static class.
//this - is used in it
namespace ExtensionMethod
{
    //create 1 static class
    public static class Lib
    {
        //create static method

        public static void NewMethod(this Myclass ob)  //using this keyword to extend my class library and adding it to my method
        {
            Console.WriteLine("this is extension method");
        }
    }

        class Program
        {

            static void Main()
            {
            //creating instance and calling
                Myclass ob = new Myclass();
                ob.Display1();
                ob.Display2();
                ob.NewMethod();
                Console.ReadLine();

            }
        }

    }
        
   

