using Siemens.Engineering;
using System;
using System.Collections.Generic;
using System.Linq;
using Siemens.Engineering.SW;
using Siemens.Engineering.SW.Tags;
using TiaXmlGenerator.Models;
using System.Text.RegularExpressions;
using TiaXmlGenerator.Helpers;
using System.IO;
using Siemens.Engineering.SW.Blocks;

namespace ActuatorsGenerator
{
    internal class Program
    {

        [STAThread]
        static void Main(string[] args)
        {
            TiaHelper tiaProject = new TiaHelper(true);

            TiaPortal tiaPortal = tiaProject.process.Attach();

            PlcSoftware plcSoftware = tiaProject.GetPlcSoftware(tiaPortal);

            ActuatorsBlockGenerator(plcSoftware);
        }


        static void ActuatorsBlockGenerator(PlcSoftware plcSoftware)
        {
            List<PlcTag> Tags = new List<PlcTag>();
            List<PlcConstant> Constants = new List<PlcConstant>();

            TiaHelper.GetTagsConstantsLists(plcSoftware, ref Tags, ref Constants);

            string expression = @"^Y\d{1,3}";
            Regex regex = new Regex(expression);
            var ActuatorsConstants = Constants.Where(c => regex.IsMatch(c.Name));


            expression = @"\w*Y\d{1,3}\w*";
            regex = new Regex(expression);

            Dictionary<int, Actuator> Actuators = new Dictionary<int, Actuator>();
            List<PlcTag> ActuatorsTags = Tags.Where(t => regex.IsMatch(t.Name)).ToList();


            foreach (PlcConstant c in ActuatorsConstants)
            {
                //Console.WriteLine(c.Name);
                Actuator actuator = new Actuator();

                actuator.Name = c.Name;
                actuator.Constant = int.Parse(c.Value);

                List<int> numbersInName = TiaHelper.FindNumbersInString(c.Name);

                if (numbersInName.Count > 0) actuator.Number = numbersInName[0];
                else continue;

                //expression = $"^I_ActY\d{1,3}Ret";

                int st = 0;
                int.TryParse(c.Name.Substring(1, 1), out st);
                actuator.Station = st >= 1 ? (EnumStations)st - 1 : 0;
                Actuators.Add(actuator.Number, actuator);
            }


            TiaHelper.AssingTagsToActuators(Actuators, ActuatorsTags);


            // File to export
            string xmlFilePath = Path.GetTempFileName() + ".Xml";
            //string xmlFilePath = Environment.CurrentDirectory + "Actuators.Xml";
            string xmlContant = XmlHelper.Header.Contant;
            string tempConatant = string.Empty;

            // Xml header elements - 11
            int id = 12;

            // ADD NETWORKS
            // Adding actuators

            foreach (KeyValuePair<int, Actuator> act in Actuators)
            {
                tempConatant = XmlHelper.Movement.Contant;

                tempConatant = XmlHelper.InsertActuator(tempConatant, act.Value, ref id);

                xmlContant += tempConatant;
            }


            // Adding comment subnet
            Comment parametersComment = new Comment("--------------------Parameters--------------------");
            tempConatant = XmlHelper.Comment.Contant;
            tempConatant = XmlHelper.InsertComment(tempConatant, parametersComment);
            tempConatant = XmlHelper.InsertIds(tempConatant, ref id);
            xmlContant += tempConatant;


            // Adding safety network
            tempConatant = XmlHelper.Safety.Contant;
            tempConatant = XmlHelper.InsertIds(tempConatant, ref id);
            xmlContant += tempConatant;


            // Adding parameters networks
            foreach (KeyValuePair<int, Actuator> act in Actuators)
            {
                tempConatant = XmlHelper.Parameters.Contant;

                tempConatant = XmlHelper.InsertActuator(tempConatant, act.Value, ref id);

                xmlContant += tempConatant;
            }


            // Adding handling network
            tempConatant = XmlHelper.Handling.Contant;
            tempConatant = XmlHelper.InsertIds(tempConatant, ref id);
            xmlContant += tempConatant;


            // Adding outputs network
            foreach (KeyValuePair<int, Actuator> act in Actuators)
            {
                // Outputs template
                tempConatant = XmlHelper.Outputs.Contant;

                tempConatant = XmlHelper.InsertActuator(tempConatant, act.Value, ref id);

                xmlContant += tempConatant;
            }


            // Adding footer
            xmlContant += XmlHelper.Footer.Contant;

            File.WriteAllText(xmlFilePath, xmlContant);


            // Check if !!!Devices folder exists
            PlcBlockGroup devicesGroup;
            devicesGroup = TiaHelper.GetGroupByGroupName(plcSoftware.BlockGroup, "!!!Devices");
            if (devicesGroup == null)
            {
                devicesGroup = plcSoftware.BlockGroup.Groups.Create("!!!Devices");
            }


            // Check if actuators folder exists
            PlcBlockGroup actuatorsGroup;
            actuatorsGroup = TiaHelper.GetGroupByGroupName(devicesGroup, "Actuators");
            if (actuatorsGroup == null)
            {
                actuatorsGroup = devicesGroup.Groups.Create("Actuators");
            }


            // Import generated block
            SWImportOptions importOptions = SWImportOptions.None;
            actuatorsGroup.Blocks.Import(new FileInfo(xmlFilePath), ImportOptions.Override, importOptions);
        }
    }    
}
