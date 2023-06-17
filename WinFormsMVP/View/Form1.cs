using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsMVP.View
{
    public partial class Form1 : Form, IView
    {
        public event EventHandler StartProcess;
        public event EventHandler StopActiveProcesses;
        


        public Form1()
        {
            InitializeComponent();

            button1.Click += (sender, e) => {
                var handler = StartProcess;
                if (handler != null) handler(sender, e);
            };

            dataGridView1.CellClick += (sender, e) => {
                var handler = StartProcess;
                if (handler != null) handler(sender, e);
            };

            this.FormClosing += (o,e) =>
            {
                var handler = StopActiveProcesses;
                if (handler != null) handler(o,e);
            };
        }

        
        
    }
}
