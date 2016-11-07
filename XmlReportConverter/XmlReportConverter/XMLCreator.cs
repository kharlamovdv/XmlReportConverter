using System.IO;
using System.Xml.Linq;

namespace XmlReportConverter
{
    public static class XMLCreator
    {
        public static void XMLFileCreator(string name, string result, string duration, string timeStamp)
        {
            var os = OSChecker.GetOSFriendlyName();

            XDocument XMLdoc = new XDocument(
         new XElement("test",
               new XAttribute("testName", name),
               new XAttribute("result", result),
               new XAttribute("time", duration),
               new XAttribute("timestamp", duration),
               new XElement("os", os),
               new XElement("product", "ViPNet PKI Client")));
            Directory.CreateDirectory($"C:/auto/reports/{name}");
            XMLdoc.Save($"C:/auto/reports/{name}/report.xml");
        }
    }
}
