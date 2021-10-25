using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WindowsServicePlantilla
{
    public partial class Service1 : ServiceBase
    {
        Timer timer { get; set; }
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            timer = new Timer();
            //Equibale a un minuto
            timer.Interval = 60000;
            timer.Elapsed += Saludar;
            timer.Enabled = true;
            timer.Start();
        }

        protected override void OnStop()
        {
            timer.Stop();
        }

        private void Saludar(object sender, EventArgs e) {
            Console.WriteLine("Greetings World From Colombia)))");
        }
    }
}
