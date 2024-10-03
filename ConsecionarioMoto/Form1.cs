using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsecionarioMoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string marca = tbMarca.Text;
            int modelo = Convert.ToInt32(numUDModelo.Value);
            int añoACalcular = Convert.ToInt32(numUDAño.Value);
            double valorFabrica = Convert.ToDouble(tbValorFabricación.Text);
            double tasaDepreciacion = Convert.ToDouble(tbTasa.Text);
            
            Moto nuevaMoto = new Moto(marca, modelo, valorFabrica);
            Form2 form2 = new Form2();

            form2.listBox1.Items.Add(nuevaMoto.VerDescripcion());

            double valorAnual = nuevaMoto.CalcularDepreciacionAnual(añoACalcular, tasaDepreciacion);
            form2.listBox1.Items.Add($"Depreciacion anual: ${valorAnual}");

            form2.ShowDialog();
        }
    }
}
