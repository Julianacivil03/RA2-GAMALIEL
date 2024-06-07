using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juliana_RA2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer el sueldo del empleado
                decimal sueldoBruto = decimal.Parse(txtSueldo.Text);

                // Leer el número de hijos
                int numeroHijos = int.Parse(txtHijos.Text);

                // Calcular incentivos
                decimal incentivos = numeroHijos * 500;

                // Calcular sueldo bruto más incentivos
                decimal sueldoConIncentivos = sueldoBruto + incentivos;

                // Calcular descuentos
                decimal descuentoAFP = sueldoConIncentivos * 0.0287m;
                decimal descuentoSFS = sueldoConIncentivos * 0.0304m;
                decimal totalDescuentos = descuentoAFP + descuentoSFS;

                // Calcular sueldo neto
                decimal sueldoNeto = sueldoConIncentivos - totalDescuentos;

                // Mostrar los resultados
                txtIncentivos.Text = incentivos.ToString("C");
                txtSueldoBrutoIncentivos.Text = sueldoConIncentivos.ToString("C");
                txtDescuentoAFP.Text = descuentoAFP.ToString("C");
                txtDescuentoSFS.Text = descuentoSFS.ToString("C");
                txtTotalDescuentos.Text = totalDescuentos.ToString("C");
                txtSueldoNeto.Text = sueldoNeto.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
    }

