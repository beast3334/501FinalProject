using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _501FinalProject
{
    class Instructor
    {
        string name;
        public Instructor(string n)
        {
            this.Name = n;
        }

        public override bool Equals(object obj)
        {
            Instructor i = obj as Instructor;
            return i.Name.ToLower().Equals(this.Name.ToLower());
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public string Name
        {
            get => name;
            set => name = value;
        }
    }
}