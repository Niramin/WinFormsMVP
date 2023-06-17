using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMVP.Model;
using WinFormsMVP.View;

namespace WinFormsMVP.Presenter
{
    public class Presenter
    {
        readonly IRepository model;
        readonly IView view;

        public Presenter(IRepository model, IView view)
        {
            this.model = model;
            this.view = view;
            this.view.StartProcess += startProc;
            this.view.StopActiveProcesses += shutDown;
            this.view.Show();

        }

        public void startProc(object sender, EventArgs e)
        {
            model.executeLongProcess();
        }

        public void shutDown(object sender, EventArgs e) {
            model.shutDown();
        }

    }
}
