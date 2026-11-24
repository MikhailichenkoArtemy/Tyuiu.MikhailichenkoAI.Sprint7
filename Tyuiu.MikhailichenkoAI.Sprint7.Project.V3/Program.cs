using System;
using System.Windows.Forms;

namespace Tyuiu.MikhailichenkoAI.Sprint7.Project.V3
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize(); 
            Application.Run(new FormMain_MAI());
        }
    }
}
