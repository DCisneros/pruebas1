using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrincipalDLL;


    

namespace Capacitacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        validacion validar = new validacion();
        private void btnsuma_Click(object sender, EventArgs e)
        {
            try {
                double x = Double.Parse(txtNumero1.Text);
                double y = Double.Parse(txtNumero2.Text);
                IngresoDatos dll = new IngresoDatos();
                double resultado = dll.suma(x, y);
                label1.Text = Convert.ToString(resultado);
            }
            catch
            {
                MessageBox.Show("Error en la Operacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            try {
                double x = Double.Parse(txtNumero1.Text);
                double y = Double.Parse(txtNumero2.Text);
                IngresoDatos dll = new IngresoDatos();
                double resultado = dll.resta(x, y);
                label1.Text = Convert.ToString(resultado);
            }
            catch
            {
                MessageBox.Show("Error en la Operacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnmultiplicacion_Click(object sender, EventArgs e)
        {
            try {
                double x = Double.Parse(txtNumero1.Text);
                double y = Double.Parse(txtNumero2.Text);
                IngresoDatos dll = new IngresoDatos();

                double resultado = dll.multi(x, y);
                label1.Text = Convert.ToString(resultado);
            }
            catch
            {
                MessageBox.Show("Error en la Operacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            try {
                double x = Double.Parse(txtNumero1.Text);
                double y = Double.Parse(txtNumero2.Text);
                IngresoDatos dll = new IngresoDatos();
                if (y == 0)
                {
                    MessageBox.Show("Division Por 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    double resultado = dll.divi(x, y);

                    label1.Text = Convert.ToString(resultado);
                }
            }
            catch
            {
                //MessageBox.Show("Error en la Operacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_solonumeros(e);
        }

        private void txtNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_solonumeros(e);
        }
    }
}
