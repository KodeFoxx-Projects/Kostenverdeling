using System;
using System.Reflection;

namespace Kostenverdeling.Model
{
    public static class Utils
    {
        public static string RenderVersion(Assembly assembly) {
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            DateTime buildDate = new DateTime(2000, 1, 1)
                .AddDays(version.Build)
                .AddSeconds(version.Revision * 2);

            return $"{version.Major}.{version.Minor}-{buildDate.ToString("yyyyMMdd-HHmm")}";
        }
    }
}
