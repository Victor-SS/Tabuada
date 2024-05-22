using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
{
    public partial class frmTabuada : Form
    {
        public frmTabuada()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            nudNumero.Value = 0;
            txtResultado.Clear();
            nudNumero.Focus();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private string Calcular(int numero)
        {
            string tabuada = string.Empty;
            int contador = 0;
            int resultado = 0;

            for (contador =1; contador <= 10; contador++)
            {
                resultado = numero * contador;
                tabuada += string.Format("{0} X {1} = {2} \r\n",
                    numero,contador,resultado);
                //tabuada += $"{numero} X {contador} = {resultado} \r\n";
            }

            return tabuada;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Calcular((int)nudNumero.Value);
        }
    }
}
