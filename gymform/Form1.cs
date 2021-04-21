using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Calculo operacion = new Calculo();

        private void btn1_Click(object sender, EventArgs e)
        {
            double resultado = operacion.resultado (Convert.ToDouble(txtpeso.Text),Convert.ToDouble(txtrepeticiones.Text));
            txtresultado.Text = Convert.ToString(resultado);
            txt60.Text = Convert.ToString(resultado * 60 / 100);
            txt65.Text = Convert.ToString(resultado * 65 / 100);
            txt70.Text = Convert.ToString(resultado * 70 / 100);
            txt73.Text = Convert.ToString(resultado * 73 / 100);
            txt75.Text = Convert.ToString(resultado * 75 / 100);
            txt78.Text = Convert.ToString(resultado * 78 / 100);
            txt80.Text = Convert.ToString(resultado * 80 / 100);
            txt83.Text = Convert.ToString(resultado * 83 / 100);
            txt85.Text = Convert.ToString(resultado * 85 / 100);
            txt87.Text = Convert.ToString(resultado * 87 / 100);
            txt89.Text = Convert.ToString(resultado * 89 / 100);
            txt91.Text = Convert.ToString(resultado * 91 / 100);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar.LimpiarControles(this);
        }

        private void txtpeso_TextChanged(object sender, EventArgs e)
        {
            Focus();
        }
    }
}
