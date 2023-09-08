﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Reflection;

namespace FSG.HCM.Onboarding.Permissions
{
    public class OnboardingPermissions
    {
        public const string GroupName = "AbpIdentity";

        public static class Onboarding
        {
            public const string Default = GroupName + ".Onboarding";
            public const string Create = Default + ".Create";
            public const string Update = Default + ".Update";
            public const string Delete = Default + ".Delete";
        }

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(OnboardingPermissions));
        }
    }
}
