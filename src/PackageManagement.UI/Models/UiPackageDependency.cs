﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using NuGet.Versioning;
using NuGet.PackagingCore;

namespace NuGet.PackageManagement.UI
{
    public class UiPackageDependency
    {
        public UiPackageDependency()
        {

        }

        public UiPackageDependency(PackageDependency serverData)
        {
            Id = serverData.Id;
            Range = serverData.VersionRange;
        }

        public string Id
        {
            get;
            private set;
        }

        public VersionRange Range
        {
            get;
            private set;
        }

        public UiPackageDependency(string id, VersionRange range)
        {
            Id = id;
            Range = range;
        }

        public override string ToString()
        {
            if (Range == null)
            {
                return Id;
            }
            else
            {
                return String.Format(
                    CultureInfo.InvariantCulture,
                    "{0} {1}",
                    Id, Range.PrettyPrint());
            }
        }
    }
}
