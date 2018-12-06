using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _501FinalProject
{
    class Semester
    {
        private List<Section> sections;
        private string season;
        private int year;

        public Semester(List<Section> sec, string s, int y)
        {
            sections = sec;
            season = s;
            year = y;
        }
        public Semester()
        {
            sections = new List<Section>();
            season = "DEFAULT";
            year = 0;
        }
        public List<Section> Sections
        {
            get => sections;
        }

        public Section this[int index]
        {
            get => sections[index];
        }

        public override bool Equals(object obj)
        {
            Semester sem = obj as Semester;

            if (this.sections.Count != sem.sections.Count) return false;
            return true;
            
        }
    }
}
