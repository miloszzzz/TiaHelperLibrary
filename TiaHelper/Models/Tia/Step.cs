using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiaHelper.Models.Elements
{
    public class Step : ProjectElement
    {
        public List<int> NextSteps = new List<int>();
    }
}
