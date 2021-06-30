using System.Collections.Generic;
using static System.Console;

namespace Student_Management_System
{
    public class Student : Entity
    {   
        public void Add(Entity et, List<Entity> ls) 
        {
            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i]!=null) {
                    ls[i] = et;
                    break;
                }   
            }
            foreach (Entity item in ls)
            {
                WriteLine(item.ToString());
            }
        }
        public void EditStudent(int sId,  string name, string gender, int age, double score, Class Class, List<Entity> ls)
        {
            bool check = false;
            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i] != null)
                {
                    if (ls[i].ID == sId)
                    {
                        check = false;
                        ls[i].Name = name;
                        ls[i].Gender = gender;
                        ls[i].Age = age;
                        ls[i].AvgScore = score;
                        ls[i].Class = Class;
                        break;
                    }
                    else
                    {
                        check = true;
                    }
                }
            }
            if (check)
            {
                WriteLine ("The system cannot modify this student number!");
            }
            foreach (Entity item in ls)
            {
                WriteLine();
                WriteLine("Modified:" + item.ToString());
            }
        }
        //Delete
        public void RemoveStudent(int sid, List<Entity> ls)
        {
            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i] == null)
                {
                    continue;
                }
                if (ls[i] != null)
                {
                    if (ls[i].ID == sid)
                    {
                        ls[i] = ls[i + 1];
                        ls[i + 1] = null;
                        WriteLine();
                        WriteLine("The student is successfully deleted!");
                        WriteLine();
                    }
                }
            }
            foreach (Entity item in ls)
            {
                if (item != null)
                {
                    WriteLine(item.ToString());
                }
            } 
        }
    }
}
