using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;

namespace Pdf2JpgGui
{
    public class AsmUtility
    {
        public const int MeasureVersion = 1;
        public const int MinorVersion = 0;
        public const int PatchVersion = 0;
        public const string VersionSurfix = "";
        public static string GetAssemblyDirectoryName()
        {
            string location = Assembly.GetEntryAssembly().Location;
            return Path.GetDirectoryName(location);
        }
        public static string GetAssemblyFileNameWithoutExtension()
        {
            string location = Assembly.GetEntryAssembly().Location;
            return Path.GetFileNameWithoutExtension(location);
        }
        public static string GetAssemblyVersion()
        {
            return string.Concat(new object[]
            {
                MeasureVersion.ToString(),
                '.',
                MinorVersion.ToString("d2"),
                '.',
                PatchVersion.ToString("d2"),
                VersionSurfix
            });
        }
    }
}