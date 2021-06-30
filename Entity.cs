namespace Student_Management_System
{
    public class Entity
    {
         private int _id;
        private string _name;
        private string _gender;
        private int _age;
        private double _avgScore;
        private Class _class;
        public int ID 
        {
            get {return _id;}
            set {_id = value;}
        }
        public string Name
        {
            get {return _name;}
            set {_name = value;}
        }
        public string Gender
        {
            get {return _gender;}
            set {_gender = value;}
        }
        public int Age
        {
            get{return _age;}
            set{_age = value;}
        }
        public double AvgScore
        {
            get{return _avgScore;}
            set{_avgScore = value;}
        }
        public Class Class 
        {
            get{return _class;}
            set{_class = value;}
        }
        public Entity()
        {
        }
        public Entity(int _id, string _name, string _gender, int _age, double _avgScore, Class _class)
        {
            this._id = _id;
            this._name = _name;
            this._gender = _gender;
            this._age = _age;
            this._avgScore = _avgScore;
            this._class = _class;
        }
        public override string ToString()
        {
            return "Student ID:" + ID + "\tName:" + Name + "\tGender:" + Gender + "\tAge: " + Age + "\tAverage score: " + AvgScore  + "\tClass: " + _class.ClassName;
        }
        public string DefineClassName()
        {
            return $"{_class.ClassName}";
        }
    }
}