﻿using System;
using System.Windows.Forms;

namespace Lesson_01
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6) SetProcessDPIAware();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}