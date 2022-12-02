using System;

namespace Student
{
    class Student
    {
        public int ID;

         public int GetID()
  {
    return ID;
  }

  public void SetID(int id)
  {
    ID = id;
  }
      

        public string Name;

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            
            Name= name;
        }
        public string Type;
        public string GetType()
        {
            return Type;
        }

        public void SetType(string type)
        {

            Type = type;
        }

        public Student() 
        { }

        public Student(int id, string name, string type)
        {

            ID = id;
            Name = name; 
            Type = type; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Student ID: ");         
            int id = int.Parse(Console.ReadLine());       

            Console.Write("Enter Student Name: ");         
            string name = Console.ReadLine();             

            Console.Write("Enter Student type (Undergraduate, graduate, part-time, full-time): ");     
            string type = Console.ReadLine();                                                          

            Student s1 = new Student(id, name, type);       
            Console.WriteLine("Student ID is: {0}", s1.ID);           
            Console.WriteLine("Student Name is: {0}", s1.Name);       
            Console.WriteLine("Student Type is: {0}", s1.Type);      

          s1.ID = 105;
            s1.Name = "Ankit";
            s1.Type = "Part-time";

            Console.WriteLine("Student ID is: {0}", s1.ID);
            Console.WriteLine("Student Name is: {0}", s1.Name);
            Console.WriteLine("Student Type is: {0}", s1.Type);
        }
    }
}
