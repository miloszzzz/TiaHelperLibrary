using OpennessConsole.Models.Elements;
using Siemens.Engineering;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
            List<Sequence> sequenceTexts = new List<Sequence>();

            for (int i = 0; i < cultures.Count; i++)
            {
                sequenceTexts.Add(new Sequence());
            }

            GetElementsWithName(element, "MultilingualText", ref sequenceTextElements);

            foreach (XElement seqText in sequenceTextElements)
            {
                foreach (XElement objectList in seqText.Elements("ObjectList"))
                {
                    //Console.WriteLine(objectList.Value);
                    if (objectList.Elements("MultilingualText") == null) continue; //Console.WriteLine("MultilingualText");

                    foreach (XElement multilingualText in objectList.Elements("MultilingualText"))
                    {
                        Console.WriteLine(multilingualText.Value);
                        int i = 0;
                        foreach (XElement multilingualTextItem in multilingualText.Elements("ObjectList"))
                        {
                            if (multilingualTextItem.Element("AttributeList").Element("Text") != null) continue; //Console.WriteLine(@"Element('AttributeList').Element('Text')");

                            XElement text = multilingualText.Element("AttributeList").Element("Text");

                            if (text != null)
                            {
                                Step step = new Step();
                                step.Name = text.Value;

                                if (checkStepName(step.Name))
                                {
                                    //Console.WriteLine(step.Name);
                                    step = getStepInfoFromName(step.Name);
                                    sequenceTexts[i].Steps.Add(step);
                                }
                            }

                            i++;
                        }
                    }
                }
                
                /*
                for (int i = 0; i < cultures.Count; i++)
                {

                    if (multiTextItem.Element("AttributeList").Element("Culture") != null && multiTextItem.Element("AttributeList").Element("Text") != null)
                    { 
                        Step step = new Step();
                        step.Name = multiTextItem.Element("AttributeList").Element("Text").Value;


                        if (checkStepName(step.Name))
                        {
                            //Console.WriteLine(step.Name);
                            step = getStepInfoFromName(step.Name);
                            sequenceTexts[i].Steps.Add(step);
                        }
                    }
                }*/
            
            }

            return sequenceTexts;
        }

        
        private static void GetElementsWithName(XElement element, string elementToFind, ref List<XElement> texts)
        {
            foreach (XElement subelement in element.Descendants())
            {
                if (subelement.Name == elementToFind) texts.Add(subelement);

                GetElementsWithName(subelement, elementToFind, ref texts);
            }
        }


        private static bool checkStepName(string stepName)
        {
            string pattern = @"Step[\s\S]*:[\s\S]*";

            if (Regex.IsMatch(stepName, pattern)) return true;

            return false;
        }


        private static Step getStepInfoFromName(string stepName)
        {
            Step step = new Step();
            int colonPosition = stepName.IndexOf(':');
            step.Name = ExtractSubstring(stepName);

            List<int> steps = ExtractNumbersFromString(stepName.Substring(0, stepName.Length - colonPosition));
            if (steps.Count > 0)
            {
                step.Id = steps[0];
                steps.Remove(0);

                step.NextSteps = steps;
            }
            return step;
        }


        private static List<int> ExtractNumbersFromString(string input)
        {
            // Wyrażenie regularne do odnalezienia liczb w stringu
            Regex regex = new Regex(@"\d{1,3}");

            // Znajdź wszystkie dopasowania do wyrażenia regularnego
            MatchCollection matches = regex.Matches(input);

            // Zainicjalizuj listę liczb
            List<int> numbers = new List<int>();

            // Dodaj każde dopasowanie do listy jako liczbę całkowitą
            foreach (Match match in matches)
            {
                int number;
                if (int.TryParse(match.Value, out number))
                {
                    numbers.Add(number);
                }
            }

            return numbers;
        }


        public static string ExtractSubstring(string input)
        {
            int startIndex = input.IndexOf(":");
            if (startIndex != -1)
            {
                startIndex += 1; // Przesunięcie o jeden znak po ":".

                int endIndex = input.IndexOf("#", startIndex);
                if (endIndex != -1)
                {
                    return input.Substring(startIndex, endIndex - startIndex);
                }
                else
                {
                    return input.Substring(startIndex);
                }
            }

            return string.Empty; // Zwraca pusty string, jeśli nie znaleziono ":"
        }
    }
}
