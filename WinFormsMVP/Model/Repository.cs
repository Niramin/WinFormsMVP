using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMVP.Model
{
    public class Repository : IRepository
    {
        public Process process { get; set; }

        public Repository() { 
            
        }

        public void executeLongProcess()
        {
            if (process != null) return;
            process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = true;
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            //startInfo.RedirectStandardOutput = false;
            //startInfo.RedirectStandardError = true;
            startInfo.FileName =
              Properties.Settings.Default.longTask;    
            process.StartInfo = startInfo;
            process.Start();


        }

        public void shutDown()
        {

            if (process != null )
            {
                if(process.HasExited == false)
                process.Kill();
            }
            foreach (var proc in Process.GetProcessesByName("timeconsumingprocess")) {
                if (proc.HasExited == false)
                {
                    proc.Kill();
                }
            }
        }

    }
}
