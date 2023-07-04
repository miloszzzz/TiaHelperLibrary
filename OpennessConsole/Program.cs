using Siemens.Engineering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Siemens.Engineering.HW;
using Siemens.Engineering.HW.Features;
using Siemens.Engineering.SW;
using Siemens.Engineering.SW.Tags;
using Siemens.Engineering.SW.Blocks;
using OpennessConsole.Models;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using OpennessConsole.Models.Elements;
using System.Collections;
using System.CodeDom.Compiler;
using System.Globalization;

namespace OpennessConsole
{
    internal class Program
    {

        [STAThread]
        static void Main(string[] args)
        {
            TiaHandling tiaProject = new TiaHandling();

            TiaPortal tiaPortal = tiaProject.process.Attach();

            PlcSoftware plcSoftware = tiaProject.GetPlcSoftware(tiaPortal);

            //tiaProject.ShowAllTags(plcSoftware);

            //tiaProject.ShowAllElements(plcSoftware);

            //tiaProject.showProgramStructure(plcSoftware);

            //CreatePlcTagTableUserGroup(plcSoftware);

            //PlcBlockUserGroup sequencesGroup = tiaProject.GetDefaultGroup(plcSoftware.BlockGroup, Enums.DefGroup.Sequences);

            Collection<PlcBlock> sequencesBlocks = tiaProject.GetSequencesBlocks(plcSoftware.BlockGroup);

            /*
            // Exporting file
            FolderBrowserDialog b = new FolderBrowserDialog();

            if (b.ShowDialog() == DialogResult.OK)
            {
                string folderName = b.SelectedPath;

                foreach (PlcBlock sequence in sequences)
                {                    
                    sequence.Export(new FileInfo($"{folderName}\\{sequence.Name}.xml"), ExportOptions.WithDefaults);
                }
            }*/

            List<XElement> sequencesXml = new List<XElement>();

            foreach (PlcBlock sequence in sequencesBlocks)
            {
                string tempFilePath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString(), sequence.Name, ".xml");
                FileInfo tempFileInfo = new FileInfo(tempFilePath);

                sequence.Export(tempFileInfo, ExportOptions.WithDefaults);

                sequencesXml.Add(XElement.Load(tempFilePath));

                tempFileInfo.Delete();
            }

            //XmlSeq.RecursivePrintTexts(sequencesXml[0]);

            List<CultureInfo> cultures = tiaProject.GetProjectCultures();
            List<XElement> sequenceTexts = new List<XElement>();

            sequenceTexts = XmlSeq.GetSequenceTexts(sequencesXml[0], cultures);
            
            foreach (XElement sequenceText in sequenceTexts)
            {
                XmlSeq.RecursivePrintTexts(sequenceText);
            }
            
            //string tabs = "";
            //XmlSeq.RecursivePrintXmlElements(sequencesXml[0], tabs);

            /*List<Sequence> sequences = new List<Sequence>();

            for (int i = 0; i < sequencesXml.Count; i++)
            {
                Sequence seq = new Sequence();
                sequences.Add(seq);

                sequencesXml[i].Descendants("SW.Blocks.FC").
            }*/
            /*foreach (XElement seqXml in sequencesXml)
            {
                foreach (XElement xElement in seqXml.Elements())
                {
                    Console.WriteLine(xElement.Name);

                    foreach (XElement subElement in xElement.Elements())
                    {
                        Console.WriteLine("\t" + subElement.Name);

                        
                    }
                }
            }*/
        }

        
    }
}
