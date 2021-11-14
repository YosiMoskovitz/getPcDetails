using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.DirectoryServices;
using System.Collections;
using Microsoft.Win32;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace GetPcDetails
{
    internal class Utils
    {
        public static string RunCmd(string commend)
        {
            ProcessStartInfo psi = new ProcessStartInfo("cmd");
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            psi.CreateNoWindow = true;
            psi.RedirectStandardInput = true;
            var proc = Process.Start(psi);

            proc.StandardInput.WriteLine(commend);
            proc.StandardInput.WriteLine("exit");

            string result = proc.StandardOutput.ReadToEnd();

            return result;
        }

    }
}
