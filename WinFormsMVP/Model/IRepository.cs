using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMVP.Model
{
    public interface IRepository
    {
        Process process { get;}
        void executeLongProcess();
        void shutDown();
    }
}
