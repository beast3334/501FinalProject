using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _501FinalProject
{
    class Section
    {
        Dictionary<int, Object> data;

        /// <summary>
        /// Constructor to be called to initialize a Section object.
        /// </summary>
        /// <param name="subject">Col 0 - </param>
        /// <param name="catalogNum">Col 1 - </param>
        /// <param name="classDescription">Col 2 - </param>
        /// <param name="sectionIdentifier">Col 3 - </param>
        /// <param name="instructor">Col 4 - </param>
        /// <param name="consent">Col 5 - </param>
        /// <param name="enrollCap">Col 6 - </param>
        /// <param name="topicDescription">Col 7 - </param>
        /// <param name="meetingStart">Col 8 - </param>
        /// <param name="meetingEnd">Col 9 - </param>
        /// <param name="days">Col 10 - </param>
        /// <param name="unitsMin">Col 11 - </param>
        /// <param name="unitsMax">Col 12 - </param>
        /// <param name="classAssnComp">Col 13 - </param>
        public Section(string subject, string catalogNum, string classDescription, string sectionIdentifier, Instructor instructor, string consent, int enrollCap, string topicDescription, string meetingStart, string meetingEnd, bool[] days, int unitsMin, int unitsMax, string classAssnComp)
        {
            data = new Dictionary<int, object>();
            data.Add(0, subject);
            data.Add(1, catalogNum);
            data.Add(2, classDescription);
            data.Add(3, sectionIdentifier);
            data.Add(4, instructor);
            data.Add(5, consent);
            data.Add(6, enrollCap);
            data.Add(7, topicDescription);
            data.Add(8, meetingStart);
            data.Add(9, meetingEnd);
            data.Add(10, days);
            data.Add(11, unitsMin);
            data.Add(12, unitsMax);
            data.Add(13, classAssnComp);
        }

        public string Subject {             get => data[0]  as string;      }

        public string CatalogNum {          get => data[1]  as string;      }

        public string ClassDescription {    get => data[2]  as string;      }

        public string SectionIdentifier {   get => data[3]  as string;      }

        public Instructor Instructor {      get => data[4]  as Instructor;  }

        public string Consent {             get => data[5]  as string;      }

        public int EnrollCap {              get => (int)data[6];            }

        public string TopicDescription {    get => data[7]  as string;      }

        public string MeetingStart {        get => data[8]  as string;      }

        public string MeetingEnd {          get => data[9]  as string;      }

        public bool[] Days {                get => data[10] as bool[];      }

        public int UnitsMin {               get => (int)data[11];           }

        public int UnitsMax {               get => (int)data[12];           }

        public string ClassAssnComp {       get => data[13] as string;      }
    }
}