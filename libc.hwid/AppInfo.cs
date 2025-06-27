using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;

namespace libc.hwid
{
    /// <summary>
    ///     Helper for OS, Application and Registry
    /// </summary>
    internal static class AppInfo
    {
        /// <summary>
        ///     e.g: C:\
        /// </summary>
        public static string WindowsInstallationDirectory => Path.GetPathRoot(Environment.SystemDirectory);

        public static bool Is64 => Environment.Is64BitOperatingSystem;
        public static string OsArch => Is64 ? "64" : "32";
        public static bool IsInDesignMode => LicenseManager.UsageMode == LicenseUsageMode.Designtime;
    }
}