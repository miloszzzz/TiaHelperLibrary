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

namespace OpennessConsole
{
    internal class Program
    {

        static void Main(string[] args)
        {
            TiaHandling tiaProject = new TiaHandling(0);

            TiaPortal tiaPortal = tiaProject.process.Attach();

            PlcSoftware plcSoftware = tiaProject.GetPlcSoftware(tiaPortal);

            //tiaProject.ShowAllTags(plcSoftware);

            //tiaProject.ShowAllElements(plcSoftware);

            tiaProject.showProgramStructure(plcSoftware);
        }
    }
}
