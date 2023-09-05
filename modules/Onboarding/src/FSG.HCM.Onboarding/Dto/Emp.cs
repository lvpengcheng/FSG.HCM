using FSG.HCM.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSG.HCM.Onboarding
{
    public class Emp : BaseEntity<Emp>
    {
        public string? Name { get; set; }
    }
    public class EmpInput : BaseInput
    {
        public string? Name { get; set; }
    }
}
