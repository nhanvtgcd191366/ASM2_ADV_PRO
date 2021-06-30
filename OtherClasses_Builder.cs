using static System.Console;
using System;
using System.Collections.Generic;

namespace Student_Management_System
{
    public abstract class EntityBuilder
    {
        protected Entity entity;
        public Entity Entity
        {
            get{return entity;}
        }
        public abstract void AddId();
        public abstract void AddName();
        public abstract void AddAge();
        public abstract void AddGender();
        public abstract void AddScore();
        public abstract void AddClass();
    }
    class AddStudent
    {
        public void Construct(EntityBuilder builder)
        {
            builder.AddId();
            builder.AddName();
            builder.AddAge();
            builder.AddGender();
            builder.AddScore();
            builder.AddClass();
        }
    }
    public class NewEntity : EntityBuilder
    {
        public NewEntity()
        {
            entity = new Entity();
        }
        public override void AddId()
        {
            Write("Enter ID of the student: ");
            entity.ID = Int32.Parse(ReadLine());
        }
        public override void AddAge()
        {
            Write("Enter age of the student: ");
            entity.Age = Int32.Parse(ReadLine());
        }
        public override void AddGender()
        {
            Write("Enter gender of the student: ");
            entity.Gender = ReadLine();
        }

        public override void AddName()
        {
            Write("Enter name of the student: ");
            //newstudent.Name = ReadLine();
            entity.Name = ReadLine();
        }

        public override void AddScore()
        {
            Write("Enter score of the student: ");
            //newstudent.AvgScore = Double.Parse(ReadLine());
            entity.AvgScore = Double.Parse(ReadLine());
        }
        public override void AddClass()
        {
            Class class1 = new Class("GCD0806");
            Class class2 = new Class("GCD0807");
            Write("Enter class (1 for GCD0806 and 2 for GCD0807): ");
            int answer = Convert.ToInt32(ReadLine());
            if(answer == 1) entity.Class = class1;
            else if(answer == 2) entity.Class = class2;
        }
    }
}