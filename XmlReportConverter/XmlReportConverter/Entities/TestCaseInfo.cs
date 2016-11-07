using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlReportConverter.Entities
{
    public class TestCaseInfo
    {
        public string caseName;
        public string result;
        public string duration;
        public string timeStamp;


        public TestCaseInfo(string caseName, string result, string duration, string timeStamp)
        {
            this.caseName = caseName;
            this.result = result;
            this.duration = duration;
            this.timeStamp = timeStamp;
        }


        public TestCaseInfo(string caseName)
        {
            this.caseName = caseName;
        }

        public string CaseName
        {
            get { return caseName; }
            set { caseName = value; }
        }

        public string Result
        {
            get { return result; }
            set
            {
                if (Result == "Passed")
                {
                    result = "Ok";
                }
            }
        }

        public string Duration
        {
            get { return duration; }
            set { duration = value; }
        }
        public string TimeStamp
        {
            get { return timeStamp; }
            set { timeStamp = value; }
        }
    }
}
