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
using Entidades;

namespace C
{
    public partial class Form1 : Form
    {
        //Thread t;
        Temporizador temp;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //t = new Thread(updateTime);

            //t.Start();
            temp = new Temporizador();
            temp.Intervalo = 1000;
            temp.EventoTiempo += TemporizadorHandler;
            temp.Activo = true;
        }
        //public void TemporizadorHandler()
        //{
        //    if(this.InvokeRequired
        //        this.lblHora.Text = DateTime.Now.ToLongTimeString();

        //}
        delegate void Callback();
        public void TemporizadorHandler()
        {
            if (this.lblHora.InvokeRequired)
            {
                Callback d = new Callback(this.TemporizadorHandler);
                this.Invoke(d);
            }
            else
            {
                this.lblHora.Text = DateTime.Now.ToLongTimeString();

            }
        }

        /*void updateTime()
        {
            do
            {
                AsignarHora();
                Thread.Sleep(1000);
            } while (true);
        }*/

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.temp.Activo = false;
            //if (this.t.IsAlive)
            //{
            //    this.t.Abort();
            //}
        }
    }
}
