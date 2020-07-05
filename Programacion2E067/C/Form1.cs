using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace C
{
    public partial class Form1 : Form
    {
        Thread t;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t = new Thread(updateTime);

            t.Start();
        }

        delegate void Callback();
        public void AsignarHora()
        {
            if (this.lblHora.InvokeRequired)
            {
                Callback d = new Callback(this.AsignarHora);
                this.Invoke(d);
            }
            else
            {
                this.lblHora.Text = DateTime.Now.ToLongTimeString();

            }
        }

        void updateTime()
        {
            do
            {
                AsignarHora();
                Thread.Sleep(1000);
            } while (true);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.t.IsAlive)
            {
                this.t.Abort();
            }
        }
    }
}
