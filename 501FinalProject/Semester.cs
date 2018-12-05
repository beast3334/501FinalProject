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

    }
}
