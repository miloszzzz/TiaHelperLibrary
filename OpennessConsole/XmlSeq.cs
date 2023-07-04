using OpennessConsole.Models.Elements;
using Siemens.Engineering;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OpennessConsole
{
    public class XmlSeq
    {
        public static void RecursivePrintXmlElements(XElement xElement, string tabs)
        {
            string tempTabs = tabs + "\t";
            foreach (XElement subXelement in xElement.Elements())
            {
                Console.WriteLine(tabs + subXelement.Name);

                RecursivePrintXmlElements(subXelement, tempTabs);
            }
        }

        public static void RecursivePrintTexts(XElement xElement)
        {
            foreach (XElement subXelement in xElement.Elements())
            {
                if (subXelement.Name == "Text") Console.WriteLine(subXelement.Value);

                RecursivePrintTexts(subXelement);

            }
        }

        public static List<Sequence> GetSequenceTexts(XElement element, List<CultureInfo> cultures) 
        {
            List<XElement> sequenceTextElements = new List<XElement>();
            List<Sequence> sequenceTexts = new List<Sequence>(cultures.Count);

            GetElementsWithTexts(element, ref sequenceTextElements);

            foreach (XElement seqText in sequenceTextElements)
            {
                XElement objectList = seqText.Element("ObjectList");

                foreach (XElement multiTextItem in objectList.Elements())
                {
                    for (int i = 0; i < cultures.Count; i++)
                    {
                        if (cultures[i].Name != multiTextItem.Attribute("Culture").Value)
                        {
                            Step step = new Step();
                            step.Name = multiTextItem.Attribute("Text").Value;
                            sequenceTexts[i].Steps.Add(step);
                        }
                    }
                }
            }
            
            return sequenceTexts;
        }


        private static void GetElementsWithTexts(XElement element, ref List<XElement> texts)
        {
            DigThroughElements(element, "MultilingualText", ref texts);
        }

        private static void DigThroughElements(XElement element, string elementToFind, ref List<XElement> texts)
        {
            foreach (XElement subelement in element.Descendants())
            {
                if (subelement.Name == elementToFind) texts.Add(subelement);

                DigThroughElements(subelement, elementToFind, ref texts);
            }
        }

        private string checkStepName(string stepName)
        {
            string pattern = @"Step \d * - [0 - 9a - zA - Z /]{ 0,30}:";
            Regex regex = new Regex(pattern, RegexOptions.Compiled);
        }
    }
}
