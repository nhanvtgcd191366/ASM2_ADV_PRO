using System;
using System.Collections.Generic;
using static System.Console;

namespace Student_Management_System
{
    public class Manage
    {
        private List<Entity> ls = new List<Entity>();
        private Student sd = new Student();
        private Entity e = new Entity();
        private Class class1 = new Class("GCD0806");
        private Class class2 = new Class("GCD0807");
        private ISelection iSel = null;
        public void Initial()
        {
            for (int i = 0; i < 5; i++)
            {
                Entity e = new Entity();
                e.ID = i;
                e.Name = "student" + i;
                if (i % 2 == 0)
                {
                    e.Gender = "Male";
                    e.Class = class1;
                }
                else
                {
                    e.Gender = "Female";
                    e.Class = class2;
                }
                e.Age = i + 18;
                if ((60 + i) > 100)
                {
                    e.AvgScore = 100;
                }
                else
                {
                    e.AvgScore = 80 + i;
                }
                ls.Add(e);
            }
            WriteLine();
            WriteLine("\t**********                                                                 **********");            
            WriteLine("\t Student information list");
            WriteLine("\t**********                                                                 **********");
            foreach (Entity item in ls)
            {
                WriteLine(item.ToString());
            }
            ShowMain();
        }
        public void ShowMain()
        {
            int i = 0;
            do {
            WriteLine();
            WriteLine("\t**********                                                                 **********");            
            WriteLine("\t Welcome to Student Management System");
            WriteLine("\t**********                                                                 **********");
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("\t 1. View student information");
            WriteLine("\t 2. Add new student");
            WriteLine("\t 3. Change student information ");
            WriteLine("\t 4. Remove student");
            WriteLine("\t 5. Exit student management system");
            ForegroundColor = ConsoleColor.White;
            WriteLine();
            Write("Enter your option here:");
            i = int.Parse(ReadLine());
            switch (i)
            {
                case 1:
                    FindStudent();
                    break;

                case 2:
                    Student newstu = new Student();
                    EntityBuilder builder;
                    AddStudent aStudent = new AddStudent();
                    builder = new NewEntity();
                    aStudent.Construct(builder);
                    newstu.Add(builder.Entity, ls);
                    break;
                case 3:
                    Student stu1 = new Student();
                    Write("Enter the student ID: ");
                    int id = Int32.Parse(ReadLine());
                    Write("Enter the new name: ");
                    string name = ReadLine();
                    Write("Enter the new gender: ");
                    string gender = ReadLine();
                    Write("Enter the new age: ");
                    int age = Int32.Parse(ReadLine());
                    Write("Enter the new grade: ");
                    double avgScore = double.Parse(ReadLine());
                    Write("Enter new class (1 for GCD0806 and 2 for GCD0807): ");
                    int answers = Convert.ToInt32(ReadLine());
                    if(answers == 1) stu1.EditStudent(id, name, gender, age, avgScore, class1, ls);
                    else if(answers == 2) stu1.EditStudent(id, name, gender, age, avgScore, class2, ls);
                    break;
                case 4:
                    Student stu2 = new Student();
                    Write("Enter the student ID: ");
                    id = Int32.Parse(ReadLine()); 
                    stu2.RemoveStudent(id, ls);
                    break;
                case 5:
                    WriteLine("Exit program successfully!");
                    Environment.Exit(0);
                    break;
                default:
                    WriteLine("Exceeded the selection range, please re-enter!!");
                    break;
            }
            }
            while (i < 5);
            ReadKey();
        }
        public void FindStudent()
        {
            WriteLine();
            WriteLine("\t**********                                                                 **********");
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("\t 1. View individual student information");
            WriteLine("\t 2. View all student information");
            WriteLine("\t 3. Return to previous menu");
            ForegroundColor = ConsoleColor.White;
            WriteLine("\t**********                                                                 **********");
            WriteLine();
            Write("Enter your option here: ");
            try
            {
                int i1 = int.Parse(ReadLine());
                switch (i1)
                {

                    case 1://view individual
                        FindOneStudent();
                        break;
                    case 2://View all
                        FindStudents();
                        break;
                    case 3: //Return to the previous menu
                        ShowMain();
                        break;
                    default:
                        WriteLine("Exceeded the selection range, please re-enter!");
                        FindStudent();
                        break;
                }   
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
                FindStudent();
                throw;
            }
        }
        public void FindOneStudent()
        {
            int selection = 0;
            do {
            WriteLine();
            WriteLine("\t**********                                                                 **********");
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("\t 1. View according to the student number");
            WriteLine("\t 2. View the highest score student");
            WriteLine("\t 3. View the lowest score student");
            WriteLine("\t 4. Return to the previous menu");
            ForegroundColor = ConsoleColor.White;
            WriteLine("\t**********                                                                 **********");
            Write("Enter your option here: ");
            try
            {
                selection = int.Parse(ReadLine());
                switch(selection)
                {
                    case 1://View by student number
                        iSel = new FindStudentByID();
                        iSel.ChooseOption(ls);
                        break;
                    case 2://View the highest score
                        iSel = new FindMaxScoreStudent();
                        iSel.ChooseOption(ls);
                        break;
                    case 3: //view the lowest score
                        iSel = new FindMinScoreStudent();
                        iSel.ChooseOption(ls);
                        break;
                    case 4: //Return to the previous menu
                        FindStudent();
                        break;
                    default:
                        WriteLine("Exceeded the selection range, please re-enter!!!");
                        break;
                }
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
                FindOneStudent();
                throw;
            }
            }
            while (selection != 4);
        }
        public void FindStudents()
        {
            int choice = 0;
            do {
            WriteLine();
            WriteLine("\t**********                                                                 **********");
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("\t1. Sort by age");
            WriteLine("\t2. Sort by score");
            WriteLine("\t3. Sort by student number");
            WriteLine("\t4. View average score");
            WriteLine("\t5. View number of students in a class");
            WriteLine("\t6. Return to previous menu ");
            ForegroundColor = ConsoleColor.White;
            WriteLine("\t**********                                                                 **********");
            Write("Enter your option here: ");
            try
            {
                choice = int.Parse(ReadLine());
                switch (choice)
                {
                        case 1://sorted by age
                        iSel = new SortAge();
                        iSel.ChooseOption(ls);
                        break;
                        case 2:// sorted by score
                        iSel = new SortScore();
                        iSel.ChooseOption(ls);
                        break;
                        case 3:// sorted by student number
                        iSel = new SortID();
                        iSel.ChooseOption(ls);
                        break;
                        case 4://View average score
                        iSel = new CalAvgScore();
                        iSel.ChooseOption(ls);
                        break;
                        case 5:
                        iSel = new NumberOfStudent();
                        iSel.ChooseOption(ls);
                        break;
                        case 6: //return to the previous menu
                        FindOneStudent();
                        break;
                        default:
                        WriteLine("Exceeded the selection range, please re-enter!!!");
                        break;
                }
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
                FindStudents();
                throw;
            }
            }
                while (choice != 6);
        }  
    }
}