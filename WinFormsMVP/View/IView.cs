using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMVP.View
{
    public interface IView
    {
        event EventHandler StartProcess;
        event EventHandler StopActiveProcesses;
        void Show();

    }
}
