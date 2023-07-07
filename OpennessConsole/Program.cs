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
using System.Xml.Serialization;

namespace OpennessConsole
{
    internal class Program
    {

        [STAThread]
        static void Main(string[] args)
        {
            TiaHandling tiaProject = new TiaHandling();

            TiaPortal tiaPortal = tiaProject.process.Attach();

            PlcSoftware plcSoftware = tiaProject.GetPlcSoftware(tiaPortal, true);

            PlcBlockGroup groupWithActuators = tiaProject.GetGroupByBlockName(plcSoftware.BlockGroup, "FC_Actuators");
            if (groupWithActuators == null)
            {
                Console.WriteLine("sadf");
                groupWithActuators = tiaProject.GetGroupByGroupName(plcSoftware.BlockGroup, "!!!Devices");
                Console.WriteLine(groupWithActuators.Name);
                groupWithActuators = tiaProject.GetGroupByGroupName(groupWithActuators, "Actuators");
            }
            else
            {
                PlcBlock actuators = groupWithActuators.Blocks.FirstOrDefault(block => block.Name == "FC_Actuators");
                actuators.Delete();
            }

            if (groupWithActuators != null)
            {
                OpenFileDialog op = new OpenFileDialog();
                if (op.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fileInfo = new FileInfo(op.FileName);
                    groupWithActuators.Blocks.Import(fileInfo, ImportOptions.None, SWImportOptions.IgnoreStructuralChanges);
                }
            }
            



            //tiaProject.ShowAllTags(plcSoftware);

            //tiaProject.ShowAllElements(plcSoftware);

            //tiaProject.showProgramStructure(plcSoftware);

            //CreatePlcTagTableUserGroup(plcSoftware);

            //PlcBlockUserGroup sequencesGroup = tiaProject.GetDefaultGroup(plcSoftware.BlockGroup, Enums.DefGroup.Sequences);

            //Collection<PlcBlock> sequencesBlocks = tiaProject.GetSequencesBlocks(plcSoftware.BlockGroup);


            /*
             Exporting file
            FolderBrowserDialog b = new FolderBrowserDialog();

            if (b.ShowDialog() == DialogResult.OK)
            {
                string folderName = b.SelectedPath;

                foreach (PlcBlock sequence in sequences)
                {                    
                    sequence.Export(new FileInfo($"{folderName}\\{sequence.Name}.xml"), ExportOptions.WithDefaults);
                }
            }*/


            /*List<CultureInfo> cultures = tiaProject.GetProjectCultures();

            List<Sequence> sequences = XmlSeq.GetSequence(sequencesBlocks[0], cultures);*/





            //XmlSeq.RecursivePrintTexts(sequencesXml[0]);

            //List<Sequence> sequenceTexts = XmlSeq.GetSequenceTexts(sequencesXml[0], cultures);

            /*
            foreach (Sequence sequence in sequences)
            {
                Console.Write(sequence.Language);
                foreach (Step step in sequence.Steps)
                {
                    Console.Write($"\n{step.Id}: {step.Name}");
                    if (step.NextSteps.Count > 0)
                    {
                        for (int i = 0; i < step.NextSteps.Count; i++)
                        {
                            if (i == 0) Console.Write(" -> ");
                            Console.Write(step.NextSteps[i]);
                            if (i != step.NextSteps.Count - 1) Console.Write(" / ");
                        }
                    }
                }
                Console.WriteLine();
            }
            Task<Sequence> translateTask = XmlSeq.TranslateSequence(sequences[0], sequences[1].Language);
            translateTask.Wait();
            sequences[1] = translateTask.Result;
            //sequences[1].Steps = sequences[0].Steps;

            foreach (Sequence sequence in sequences)
            {
                Console.Write(sequence.Language);
                foreach (Step step in sequence.Steps)
                {
                    Console.Write($"\n{step.Id}: {step.Name}");
                    if (step.NextSteps.Count > 0)
                    {
                        for (int i = 0; i < step.NextSteps.Count; i++)
                        {
                            if (i == 0) Console.Write(" -> ");
                            Console.Write(step.NextSteps[i]);
                            if (i != step.NextSteps.Count - 1) Console.Write(" / ");
                        }
                    }
                }
                Console.WriteLine();
            }*/

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
