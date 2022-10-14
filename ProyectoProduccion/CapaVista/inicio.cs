using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool abierto = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Recetas")
                {
                    abierto = true;
                    f.Focus();
                    break;
                }
            }
            if (abierto == false)
            {
                Recetas rep = new Recetas();
                rep.MdiParent = this;
                rep.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool abierto = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "ordenes")
                {
                    abierto = true;
                    f.Focus();
                    break;
                }
            }
            if (abierto == false)
            {
                ordenes rep = new ordenes();
                rep.MdiParent = this;
                rep.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool abierto = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "proceso_de_produccion")
                {
                    abierto = true;
                    f.Focus();
                    break;
                }
            }
            if (abierto == false)
            {
                proceso_de_produccion rep = new proceso_de_produccion();
                rep.MdiParent = this;
                rep.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
