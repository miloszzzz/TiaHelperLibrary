﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpennessConsole.Models.Elements
{
    public class Sequence : ProjectElement
    {
        public List<Step> Steps = new List<Step>();
        public string Language { get; set; }
    }
}