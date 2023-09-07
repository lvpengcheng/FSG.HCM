using FSG.HCM.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSG.HCM.FlowManagement { 
    public class EmpTest : BaseEntity<EmpTest>
    {
        public string? Name { get; set; }
    }
    public class EmpTestInput : BaseInput
    {
        public string? Name { get; set; }
    }
}
