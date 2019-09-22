using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1POO
{
    public partial class Form1 : Form
    {
        Matematicas matematicas = new Matematicas();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            matematicas.setNumero1(double.Parse(txtnumero1.Text));
            matematicas.setNumero2(double.Parse(txtnumero2.Text));
            lblresultado.Text = matematicas.sumar().ToString();
            lblresultado.Visible = true;
            txtnumero1.Text = "";
            txtnumero2.Text = "";
            txtnumero1.Focus();
        }

        private void btnrestar_Click(object sender, EventArgs e)
        {
            matematicas.setNumero1(double.Parse(txtnumero1.Text));
            matematicas.setNumero2(double.Parse(txtnumero2.Text));
            lblresultado.Text = matematicas.restar().ToString();
            lblresultado.Visible = true;
            txtnumero1.Text = "";
            txtnumero2.Text = "";
            txtnumero1.Focus();
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            matematicas.setNumero1(double.Parse(txtnumero1.Text));
            matematicas.setNumero2(double.Parse(txtnumero2.Text));
            lblresultado.Text = matematicas.multiplicar().ToString();
            lblresultado.Visible = true;
            txtnumero1.Text = "";
            txtnumero2.Text = "";
            txtnumero1.Focus();
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            matematicas.setNumero1(double.Parse(txtnumero1.Text));
            matematicas.setNumero2(double.Parse(txtnumero2.Text));
            lblresultado.Text = matematicas.dividir().ToString();
            lblresultado.Visible = true;
            txtnumero1.Text = "";
            txtnumero2.Text = "";
            txtnumero1.Focus();
        }
    }
}
