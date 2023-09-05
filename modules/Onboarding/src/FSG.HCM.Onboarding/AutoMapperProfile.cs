using Aspose.Pdf.Drawing;
using AutoMapper;
using FSG.HCM.Onboarding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSG.HCM.Onboarding
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<EmpInput, Emp>();
        }
    }
}
