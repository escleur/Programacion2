using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private static System.Timers.Timer timer;
        public Form1()
        {
            InitializeComponent();
        }

        public void AsignarHora()
        {
                this.lblHora.Text = DateTime.Now.ToLongDateString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;

        }
        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            
        }
    }
}
