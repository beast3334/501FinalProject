using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _501FinalProject
{
    class EventHandler
    {
        About about;
        Reload reload;
        Clear clear;
        Load load;
        Verify verify;

        public string RegisterAbout()
        {
            About aboutObject = new About();
            return aboutObject.DoAction();
        }
        public Semester RegisterLoad(string filePath)
        {
            Load loadObject = new Load();
            return loadObject.DoAction(filePath);
        }
        public List<String> RegisterVerify(Semester localSemester, string filePath)
        {
            Verify verifyObject = new Verify();
            List<String> output = verifyObject.DoAction(localSemester, filePath);
            return output;

        }
    }
}
