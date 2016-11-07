using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using XmlReportConverter.Entities;

namespace XmlReportConverter
{
    public static class XMLReader
    {
        public static List<TestCaseInfo> GetAttributeFromXml(string pathToXML)
        {
            List<TestCaseInfo> result = new List<TestCaseInfo>();

            var xdoc = XElement.Load(pathToXML);
            foreach (XElement XMLElement in xdoc.Element("test-suite").Elements("test-suite").Elements("test-suite").Elements("test-case"))
            {
                XAttribute nameAttribute = XMLElement.Attribute("name");
                XAttribute resultAttribute = XMLElement.Attribute("result");
                XAttribute durationAttribute = XMLElement.Attribute("duration");
                XAttribute timeStampAttribute = XMLElement.Attribute("start-time");

                if (nameAttribute != null && resultAttribute != null && durationAttribute != null)
                {
                    Console.WriteLine("Тест Кейс: {0}", nameAttribute.Value);
                    Console.WriteLine("Результат: {0}", resultAttribute.Value);
                    Console.WriteLine("Продолжительность: {0}", durationAttribute.Value);
                    Console.WriteLine("Время начала теста: {0}", timeStampAttribute.Value);
                    result.Add(new TestCaseInfo(nameAttribute.Value, resultAttribute.Value, durationAttribute.Value, timeStampAttribute.Value)
                    {
                        CaseName = nameAttribute.Value,
                        Result = resultAttribute.Value,
                        Duration = durationAttribute.Value,
                        TimeStamp = timeStampAttribute.Value
                    });
                }
                Console.WriteLine();
            }
            return result;
        }
    }
  }
