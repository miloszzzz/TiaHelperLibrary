using Siemens.Engineering.SW.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OpennessConsole.Models.Group
{
    public class GroupOperations
    {
        public bool ContainsGroup(PlcBlockGroup group) => group.Groups != null;

        public bool ContainsBlock(PlcBlockGroup group) => group.Blocks != null;

        

    }
}
