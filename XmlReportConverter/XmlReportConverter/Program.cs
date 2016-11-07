using XmlReportConverter.Entities;

namespace XmlReportConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var cases = XMLReader.GetAttributeFromXml(args[0]);

            foreach (var testCase in cases)
            {
                XMLCreator.XMLFileCreator(testCase.CaseName, testCase.Result, testCase.Duration, testCase.TimeStamp);
            }
        }
    }
}

