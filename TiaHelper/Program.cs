using Siemens.Engineering;
using System;
using System.Collections.Generic;
using System.Linq;
using Siemens.Engineering.SW;
using Siemens.Engineering.SW.Tags;
using System.Text.RegularExpressions;
using System.IO;
using Siemens.Engineering.SW.Blocks;

namespace TiaHelperLibrary
{
    internal class Program
    {

        [STAThread]
        static void Main(string[] args)
        {
            
            TiaHelper tiaProject = new TiaHelper(true);

            // Get Tia Portal process
            TiaPortal tiaPortal = tiaProject.process.Attach();

            // Get software in project
            PlcSoftware plcSoftware = tiaProject.GetPlcSoftware(tiaPortal);

        }
    }    
}
