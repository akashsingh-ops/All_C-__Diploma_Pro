using System;

namespace StudentDemo
{
    class Students
    {
       
        public int ID { get; set; } 
        public string Name { get; set; }
        public string Type { get; set; }


        public Students() // Empty constructor
        { }

        public Students(int id, string name, string type)
        {

            ID =id;
            Name =name; // Work with Age as it is a field
            Type = type; // OK: accessing a private setter
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Student ID: ");          //Input by User
            int id = int.Parse(Console.ReadLine());       //ID input store in id var

            Console.Write("Enter Student Name: ");         //Input by User
            string name = Console.ReadLine();             // Name input store in Name var

            Console.Write("Enter Student type (Undergraduate, graduate, part-time, full-time): ");      //Input by User for Type 
            string type = Console.ReadLine();                                                           // Type input store in Type var                                                  

            Students S1 = new Students(id, name, type);       //Creating the object of Students class with some parameter

            Console.WriteLine("The Student ID is: {0}", S1.ID);           //print Id  on console 
            Console.WriteLine("The Student Name is: {0}",S1.Name);       //print Name on console
            Console.WriteLine("The Student Type is: {0}", S1.Type);       //print Type on console

            //Set value by setter 
            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("Set the value By Setter 102,Jalish,Undergraudate");
            S1.ID = 102;
            S1.Name = "Jalish";
            S1.Type = "Undergraudate";

            Console.WriteLine("The Student ID is: {0}", S1.ID);      //print Id  on console 
            Console.WriteLine("The Student Name is: {0}",S1.Name);  //print Name on console
            Console.WriteLine("The Student Type is: {0}", S1.Type);   //print Type on console
        }
    }
}

