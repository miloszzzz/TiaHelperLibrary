using DeepL;
using OpennessConsole.Models.Elements;
using Siemens.Engineering;
using Siemens.Engineering.SW.Blocks;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

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


        public static List<Sequence> GetSequence(PlcBlock block, List<CultureInfo> cultures)
        {
            /*List<XElement> sequenceTextElements = new List<XElement>();
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
                */
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
            
            List<Sequence> sequences = new List<Sequence>();

            // Add sequence for each language
            foreach (CultureInfo c in cultures)
            {
                Sequence seq = new Sequence();
                seq.Language = c.Name;
                sequences.Add(seq);
            }

            Document sequenceFc = SequenceXmlDeserialize(block);

            List<object> objectsFromXml = new List<object>();

            // Get sequence items from Document object
            foreach (object item in sequenceFc.SWBlocksFC.ObjectList.Items)
            {
                objectsFromXml.Add(item);
            }

            // For objects found in sequence
            foreach (object obj in objectsFromXml)
            {
                if (obj is DocumentSWBlocksFCObjectListSWBlocksCompileUnit)
                {
                    DocumentSWBlocksFCObjectListSWBlocksCompileUnit compileUnit = obj as DocumentSWBlocksFCObjectListSWBlocksCompileUnit;
                    foreach (DocumentSWBlocksFCObjectListSWBlocksCompileUnitMultilingualText compileUnitText in compileUnit.ObjectList)
                    {
                        foreach (DocumentSWBlocksFCObjectListSWBlocksCompileUnitMultilingualTextMultilingualTextItem textItem in compileUnitText.ObjectList)
                        {
                            foreach (Sequence seq in sequences)
                            {
                                //Console.WriteLine(seq.Language + "\t" + textItem.AttributeList.Culture + "\t" + checkStepName(textItem.AttributeList.Text));
                                if (seq.Language == textItem.AttributeList.Culture
                                    && checkStepName(textItem.AttributeList.Text))
                                {
                                    Step step = getStepInfoFromName(textItem.AttributeList.Text);
                                    seq.Steps.Add(step);
                                }
                            }
                        }
                    }
                }
            }

            return sequences;
        }


        /// <summary>
        /// Function exports xml document using openness function. Then it is read as FileStream and deserialised with standard function.
        /// </summary>
        /// <param name="plcBlock">Sequence block</param>
        /// <returns>Document class from xml</returns>
        private static Document SequenceXmlDeserialize(PlcBlock plcBlock)
        {
            // Create path for temporary file
            string tempFilePath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString(), plcBlock.Name, ".xml");
            FileInfo tempFileInfo = new FileInfo(tempFilePath);

            // Export block with sequence
            plcBlock.Export(tempFileInfo, ExportOptions.WithDefaults);

            // Read temporary file as Stream and create Xml handling class
            FileStream xmlStream = new FileStream(tempFilePath, FileMode.Open);
            var mySerializer = new XmlSerializer(typeof(Document));

            // Return deserialized document as Document object
            return (Document)mySerializer.Deserialize(xmlStream);
        }

        
        private static void GetElementsWithName(XElement element, string elementToFind, ref List<XElement> texts)
        {
            foreach (XElement subelement in element.Descendants())
            {
                if (subelement.Name == elementToFind) texts.Add(subelement);

                GetElementsWithName(subelement, elementToFind, ref texts);
            }
        }


        /// <summary>
        /// Check if it is philogic step name with regular expression
        /// </summary>
        /// <param name="stepName">Step name</param>
        /// <returns>True when step pattern was found</returns>
        private static bool checkStepName(string stepName)
        {
            string pattern = @"Step[\s\S]*:[\s\S]*";

            if (Regex.IsMatch(stepName, pattern)) return true;

            return false;
        }

        /// <summary>
        /// Reads information such as step and next steps from the step name
        /// </summary>
        /// <param name="stepName">Step name</param>
        /// <returns>Step object</returns>
        private static Step getStepInfoFromName(string stepName)
        {
            Step step = new Step();

            step.Name = ExtractSubstring(stepName);

            // Find colon position and find numbers before
            int colonPosition = stepName.IndexOf(':');
            List<int> steps = ExtractNumbersFromString(stepName.Substring(0, stepName.Length - colonPosition));
            if (steps.Count > 0)
            {
                step.Id = steps[0];
                steps.RemoveAt(0);

                step.NextSteps = steps;
            }
            return step;
        }


        /// <summary>
        /// Finds numbers with 1 to 3 digit in string
        /// </summary>
        /// <param name="input">String with numbers</param>
        /// <returns>List of ints</returns>
        private static List<int> ExtractNumbersFromString(string input)
        {
            // Regular expression to find
            Regex regex = new Regex(@"\d{1,3}");

            // Find every match to expression
            MatchCollection matches = regex.Matches(input);

            // Initialize list of numbers
            List<int> numbers = new List<int>();

            // Add every number found to the list
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

        /// <summary>
        /// Extract step information - text between ":" amd "#" or string end
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ExtractSubstring(string input)
        {
            int startIndex = input.IndexOf(":");
            if (startIndex != -1)
            {
                startIndex += 1; // Move one character after ":".

                int endIndex = input.IndexOf("#", startIndex);
                if (endIndex != -1)
                {
                    endIndex--;
                    while (input[endIndex] == ' ') endIndex--;
                    return input.Substring(startIndex, endIndex - startIndex);
                }
                else
                {
                    endIndex = input.Length - 1;
                    while (input[endIndex] == ' ') endIndex--;
                    return input.Substring(startIndex, endIndex - startIndex);
                }
            }

            return string.Empty; // Return empty string if ":" was not found
        }

        /*
        public static Sequence TranslateSequence(Sequence sourceSequence, CultureInfo targetLanguage)
        {
            Sequence translatedSequence = new Sequence();
            translatedSequence.Language = targetLanguage.Name;

            TranslationServiceClient client = TranslationServiceClient.Create();

            foreach (Step step in sourceSequence.Steps)
            {
                TranslateTextRequest request = new TranslateTextRequest
                {
                    Contents = { step.Name },
                    SourceLanguageCode = sourceSequence.Language,
                    TargetLanguageCode = targetLanguage.Name,
                };

                TranslateTextResponse response = client.TranslateText(request);
                Translation translation = response.Translations[0];
                step.Name = translatedSequence.Name;
                translatedSequence.Steps.Add(step);
            }
            
            return translatedSequence;
        }*/

        public static async Task<Sequence> TranslateSequence(Sequence sourceSequence, string targetLanguage)
        {
            Sequence translatedSequence = new Sequence();
            translatedSequence.Language = targetLanguage;

            var authKey = "1afb7c20-b3c3-c8f0-de26-ca48e5b045ac:fx";
            var translator = new Translator(authKey);

            foreach (Step step in sourceSequence.Steps)
            {
                var translatedText = await translator.TranslateTextAsync(
                    step.Name,
                    sourceSequence.Language.Substring(0, 2),
                    targetLanguage.Substring(0, 2)
                    );
                step.Name = translatedText.Text;
                Console.WriteLine( translatedText.Text );
            }

            return translatedSequence;
        }

    }
}
