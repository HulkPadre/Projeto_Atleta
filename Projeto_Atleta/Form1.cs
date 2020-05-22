using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Atleta
{
    public partial class frmCalculo : Form
    {
        public frmCalculo()
        {
            InitializeComponent();
        }

        Atleta obj = new Atleta();

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dados Obtidos: " + obj.ImprimeDados() + "\nIMC: " + obj.CalcularIMC().ToString());
            lblCalcImc.Text = obj.CalcularIMC().ToString("0.00");
        }

        private void btnEnviarDados_Click(object sender, EventArgs e)
        {
            try
            {
                obj.Nome = txtNome.Text;
                obj.Altura = double.Parse(txtAltura.Text);
                obj.Idade = int.Parse(txtIdade.Text);
                obj.Peso = double.Parse(txtPeso.Text);
                MessageBox.Show("Dados enviados com sucesso");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Erro de execução.\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
