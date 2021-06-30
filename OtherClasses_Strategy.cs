using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Student_Management_System
{
    public interface ISelection
    {
        void ChooseOption(List<Entity> ls);
    }
    public class NumberOfStudent : ISelection
    {
        public void ChooseOption(List<Entity> ls)
        {
            int countClass1 = 0;
            int countClass2 = 0;
            foreach (var student in ls)
            {
                if(String.Compare(student.DefineClassName(), "GCD0806", true) == 0)
                    countClass1++;
                if(String.Compare(student.DefineClassName(), "GCD0807", true) == 0)
                    countClass2++;
            }
            Console.WriteLine($"Class GCD0806 has {countClass1} students.");
            Console.WriteLine($"Class GCD0807 has {countClass2} students.");
        }
    }
    public class FindStudentByID : ISelection
    {
        public void ChooseOption(List<Entity> ls)
        {
            WriteLine("Please enter the student number:");
            int id = int.Parse(ReadLine());
            foreach (Entity s in ls)
            {
                if (s.ID == id)
                {
                    WriteLine("Student Information: " + ls[id].ToString());
                    break;
                }
            }
        }
    }
    public class FindMaxScoreStudent : ISelection
    {
        public void ChooseOption(List<Entity> ls)
        {
            double max = 0;
            max = ls[0].AvgScore;
            for (int i = 0; i < ls.Count; i++)
            {
                if (max <= ls[i].AvgScore)
                {
                    max = ls[i].AvgScore;
                }
            }
            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i] != null)
                {
                    if (ls[i].AvgScore == max)
                    {
                        WriteLine("The student with the highest score is: \n" + ls[i].ToString());
                    }
                }
            }
        }
    }
    public class FindMinScoreStudent : ISelection
    {
        public void ChooseOption(List<Entity> ls)
        {
            double min = 0;
            min = ls[0].AvgScore;
            for (int i = 0; i < ls.Count; i++)
            {
                if (min > ls[i].AvgScore)
                {
                    min = ls[i].AvgScore;
                }
            }
            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i].AvgScore == min)
                {

                    WriteLine("The student with the lowest score is: \n" + ls[i].ToString());
                }
            }
        }
    }
    public class SortAge : ISelection
    {
        public void ChooseOption(List<Entity> ls)
        {
            ls.OrderByDescending(x => x.Age).ToList();//ToList() will open up a new memory space
            foreach (Entity item in ls)
            {
                WriteLine(item);
            }
        }    
    }
    public class SortScore : ISelection
    {
        public void ChooseOption(List<Entity> ls)
        {
            ls = ls.OrderByDescending(x => x.AvgScore).ToList();
            foreach (Entity item in ls)
            {
                WriteLine(item);
            }

        }
    }
    public class  SortID : ISelection
    {
        public void ChooseOption(List<Entity> ls)
        {
            ls = ls.OrderByDescending(x => x.ID).ToList();
            foreach (Entity item in ls)
            {
                WriteLine(item);
            }
        }
    }
    public class  CalAvgScore : ISelection
    {
        public void ChooseOption(List<Entity> ls)
        {
            int count = 0;
            double sum = 0;
            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i] == null)
                {
                    break;
                }
                else if (ls[i] != null)
                {
                    sum += ls[i].AvgScore;
                    count++;
                }
            }
            double avg = sum / count;
            WriteLine("Average score: " + avg);
        }
    } 
}