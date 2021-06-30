namespace Student_Management_System
{
    public class Class
    {
       private string _className;
        public string ClassName 
        {
            get {return _className;}
            set {_className = value;}
        }
        public Class() {}
        public Class(string _className)
        {
            this._className = _className;
        }
        public override string ToString()
        {
            return $"{_className}";
        }
    }
}