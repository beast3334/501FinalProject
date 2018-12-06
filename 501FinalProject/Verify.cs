using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _501FinalProject
{
    class Verify
    {
        public List<String> DoAction(Semester localFileInput, string KSISFilePath)
        {
            Load loadObject = new Load();
            List<String> finalOutput = new List<String>();
            Semester KSISFileInput = loadObject.DoAction(KSISFilePath);

            List<Section> nfSections = FindDifferences(KSISFileInput, localFileInput);
            List<Section> newSections = FindDifferences(localFileInput, KSISFileInput);

            foreach (Section section in nfSections)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Section ");
                sb.Append(section.Subject);
                sb.Append(" ");
                sb.Append(section.CatalogNum);
                sb.Append(" Section ");
                sb.Append(section.SectionIdentifier);
                sb.Append(" not found in current semester!");
                finalOutput.Add(sb.ToString());
            }
            foreach (Section section in newSections)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Section ");
                sb.Append(section.Subject);
                sb.Append(" ");
                sb.Append(section.CatalogNum);
                sb.Append(" Section ");
                sb.Append(section.SectionIdentifier);
                sb.Append(" is new in current semester!");
                finalOutput.Add(sb.ToString());
            }

            return finalOutput;
        }

        private List<Section> FindDifferences(Semester checkFor, Semester checkAgainst)
        {
            List<Section> differences = new List<Section>();
            List<Section> checkForSections = checkFor.Sections;
            List<Section> checkAgainstSections = checkAgainst.Sections;

            // Try to find a section in alternate file.
            foreach(Section checkForSec in checkForSections)
            {
                bool found = false;
                foreach(Section checkAgainstSec in checkAgainstSections)
                {
                    // Found section.
                    if(checkAgainstSec.Equals(checkForSec))
                    {
                        found = true;
                        continue;
                    }
                }

                // Unable to find the section in the check against.
                if(!found)
                {
                    differences.Add(checkForSec);
                }
            }

            return differences;
        }
    }
}
