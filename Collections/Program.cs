using System;
using System.Collections;
using System.Collections.Generic;


namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            link1:
            Console.WriteLine("For new student type - 1");
            Console.WriteLine("For new aspirant- 2 ");
            Console.WriteLine("For info- 3 ");
            Console.WriteLine("Type -end- to exit");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateStudent(); goto link1;
                    break;
                case "2":
                    CreateStudent(); goto link1;
                case "3":
                    CreateStudent();goto link1;
                    break;
                case "end":

                    break;
                default:
                    Console.WriteLine("Choose from menu"); goto link1;
                    break;
            }
            Console.ReadKey();

            string CreateStudent()
            {
                
                ArrayList Mixed = new ArrayList();
                LinkedList<int> Snumbers = new LinkedList<int>();
                String surname = null;
                int yearofstudy = 0;
                int number = 0;
                string thesis = null;
                while (choice == "1")
                {

                    Console.WriteLine("type surname");
                    surname = Console.ReadLine();
                    Console.WriteLine("type study year");
                    try
                    {
                        yearofstudy = Convert.ToInt32(Console.ReadLine());
                        if (yearofstudy > 4) { Console.WriteLine("Study year for bachelors cant be more than 4"); yearofstudy = 4; }
                    }
                    catch { Console.WriteLine("Incorrect value for year of study"); }
                    Console.WriteLine("type student number");
                    try
                    {
                        number = Convert.ToInt32(Console.ReadLine());
                    }
                    catch { Console.WriteLine("Incorrect value for student number"); }
                    StudentPerson Student = new StudentPerson(surname, yearofstudy, number);
                    Mixed.Add(Student);
                    Snumbers.AddLast(number);
                    Console.WriteLine("For new student type - 1 \t  For new aspirant- 2 \t For Students information -3 \t Type -end- to exit");
                    choice = Console.ReadLine();
                }

                while (choice == "2")
                {
                    Console.WriteLine("type surname");
                    surname = Console.ReadLine();
                    Console.WriteLine("type study year");
                    try
                    {
                        yearofstudy = Convert.ToInt32(Console.ReadLine());
                        if (yearofstudy > 2) { Console.WriteLine("Study year for Aspirants cant be more than 2"); yearofstudy = 2; }
                    }
                    catch { Console.WriteLine("Incorrect value"); }
                    Console.WriteLine("type student number");
                    try
                    {
                        number = Convert.ToInt32(Console.ReadLine());
                    }
                    catch { Console.WriteLine("Incorrect value"); }
                    Console.WriteLine("type Thesis theme");
                    thesis = Console.ReadLine();
                    AspirantPerson Aspirant = new AspirantPerson(surname, yearofstudy, number, thesis);
                    Mixed.Add(Aspirant);
                    Snumbers.AddLast(number);
                    Console.WriteLine("For new student type - 1 \t  For new aspirant- 2 \t For Student information -3 \t Type -end- to exit ");
                    choice = Console.ReadLine();
                }
                while (choice == "3")
                {
                    foreach (int i in Snumbers)
                    {
                        Console.WriteLine("Student numbers linked list "+i);
                    }
                    foreach (object o in Mixed)
                    { 
                       Console.WriteLine(o.ToString());Console.WriteLine($"Student={surname} Year={yearofstudy} Number={number} Works on { thesis}");
                    }                                 
                    
                    Console.WriteLine("For new student type - 1 \t  For new aspirant- 2 \t For Student information -3 \t Type -end- to exit ");
                    choice = Console.ReadLine();
                }
                
                
                return choice;
            }
            
        }
        abstract public class Person
        {
            public string surname;
            public int yearofstudy;
            public int studentnumber;
            public string Surname
            {
                get { return surname; }
                set { surname = value; }
            }
            public Person(string surname) { Surname = surname; }
            public int YearofStudy
            {
                get { return yearofstudy; }
                set { yearofstudy = value; }
            }
            public int StudentNumber
            {
                get { return studentnumber; }
                set { studentnumber = value; }
            }
            public Person(string surname, int yearstudy, int studentnumber) { Surname = surname; YearofStudy = yearofstudy; StudentNumber = studentnumber; }
            public Person() { }


            abstract public void Display();
        }
        public class StudentPerson : Person
        {
            string surname;
            int yearofstudy;
            int studentnumber;
            public string Surname
            {
                get { return surname; }
                set { surname = value; }
            }

            public int YearofStudy
            {
                get { return yearofstudy; }
                set { yearofstudy = value; }
            }
            public int StudentNumber
            {
                get { return studentnumber; }
                set { studentnumber = value; }
            }
            public StudentPerson(string surname, int yearofstudy, int studentnumber) { Surname = surname; YearofStudy = yearofstudy; StudentNumber = studentnumber; }
            public override void Display()
            {
                Console.WriteLine($"Student={Surname} Year={YearofStudy} Number={StudentNumber} ");
            }

        }
        public class AspirantPerson : Person
        {
            string thesis;
            public string Thesis
            {
                get { return thesis; }
                set { thesis = value; }
            }

            public AspirantPerson(string surname, int yearstudy, int studentnumber, string thesis) : base(surname, yearstudy, studentnumber) { Thesis = thesis; }


            public override void Display() { Console.WriteLine($"Student={Surname} Year={YearofStudy} Number={StudentNumber} Works on { Thesis}"); }
        }

    }
}