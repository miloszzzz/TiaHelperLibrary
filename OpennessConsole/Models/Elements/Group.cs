using Siemens.Engineering.SW.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpennessConsole.Models.Elements
{
    public class Group : ProjectElement
    {
        public object Data;
        public Group(PlcBlockSystemGroup plcBlockSystemGroup) => Data = plcBlockSystemGroup;

        public Group(PlcBlockUserGroup plcBlockUserGroup) => Data = plcBlockUserGroup;

    }
}
