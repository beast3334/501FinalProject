using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace _501FinalProject
{
    class Load
    {
        public Semester DoAction(string fileInput)
        {
            string subject; string catalogNum; string classDescription; string sectionIdentifier; Instructor instructor;
            string consent; int enrollCap; string topicDescription; string meetingStartDt; string meetingEndDt; string meetingStartTime; string meetingEndTime; string facilityId;  bool[] days = new bool[7]; int unitsMin; int unitsMax;
            string classAssnComp;
            List<Section> SectionList = new List<Section>();
            StreamReader reader = new StreamReader(fileInput);
            string [] name = reader.ReadLine().Split(' ');
            string season = name[0];
            int year = Convert.ToInt32(name[1].Replace(',', ' '));
            reader.ReadLine();
            
            while(!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] values = line.Split(',');
                subject = values[0];
                catalogNum = values[1];
                classDescription = values[2];
                sectionIdentifier = values[3];
                Regex rgx = new Regex("[^a-zA-Z' ]");
                instructor = new Instructor(rgx.Replace(values[5] + " " + values[4], ""));
                consent = values[6];
                enrollCap = Convert.ToInt32(values[7]);
                topicDescription = values[8];
                meetingStartDt = values[9];
                meetingEndDt = values[10];
                meetingStartTime = values[11];
                meetingEndTime = values[12];
                facilityId = values[13];
                int count = 0;
                for (int i = 14; i < 20; i++)
                {

                    days[count] = values[i] == "Y" ? true : false;
                    count++;
                }
                count = 0;
                unitsMin = Convert.ToInt32(values[21]);
                unitsMax = Convert.ToInt32(values[22]);
                classAssnComp = values[23];
                SectionList.Add(new Section(subject, catalogNum, classDescription, sectionIdentifier, instructor, consent, enrollCap, topicDescription, meetingStartDt, meetingEndDt, meetingStartTime, meetingEndTime, facilityId, days, unitsMin, unitsMax, classAssnComp));
            }
            return new Semester(SectionList,season,year);
        }
    }
}
