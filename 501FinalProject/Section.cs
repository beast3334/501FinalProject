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

        public Section(string subject, string catalogNum, string classDescription, string sectionIdentifier, Instructor instructor, string consent, int enrollCap, string topicDescription, string meetingStartDt, string meetingEndDt, string meetingTimeStart, string meetingTimeEnd, string facilityId, bool[] days, int unitsMin, int unitsMax, string classAssnComp)
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
            data.Add(8, meetingStartDt);
            data.Add(9, meetingEndDt);
            data.Add(10, meetingTimeStart);
            data.Add(11, meetingTimeEnd);
            data.Add(12, facilityId);
            data.Add(13, days);
            data.Add(14, unitsMin);
            data.Add(15, unitsMax);
            data.Add(16, classAssnComp);
        }

        public object this[int index] { get => data[index]; }

        public string Subject { get => data[0] as string; }

        public string CatalogNum { get => data[1] as string; }

        public string ClassDescription { get => data[2] as string; }

        public string SectionIdentifier { get => data[3] as string; }

        public Instructor Instructor { get => data[4] as Instructor; }

        public string Consent { get => data[5] as string; }

        public int EnrollCap { get => (int)data[6]; }

        public string TopicDescription { get => data[7] as string; }

        public string MeetingStartDate { get => data[8] as string; }

        public string MeetingEndDate { get => data[9] as string; }

        public string MeetingStart { get => data[10] as string; }

        public string MeetingEnd { get => data[11] as string; }
        
        public string FacilityId { get => data[12] as string; }

        public bool[] Days { get => data[13] as bool[]; }

        public int UnitsMin { get => (int)data[14]; }

        public int UnitsMax { get => (int)data[15]; }

        public string ClassAssnComp { get => data[16] as string; }

        public override bool Equals(object obj)
        {
            Section sec = obj as Section;

            for(int i = 0; i < data.Count; i++)
            {
                if (!(this[i].Equals(sec[i]))) return false;
            }

            return true;
        }

        public bool IsSimilar(Section s)
        {
            throw new NotImplementedException();
        }
    }
}

