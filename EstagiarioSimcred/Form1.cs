using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstagiarioSimcred
{
    public partial class calculadoraJuros : Form
    {
        public calculadoraJuros()
        {
            InitializeComponent();
        }

        private void calculadoraJuros_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnCalcular;
            grpValores.Enabled = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double juros = (Convert.ToDouble(txtValorOriginal.Text) * (Convert.ToDouble(txtValorJuros.Text)) / 100 + (Convert.ToDouble(txtValorOriginal.Text))),
                parcelado2x = (juros / 2) + 10, parcelado3x = (juros / 3) + 15, parcelado4x = (juros / 4) + 20, parcelado5x = (juros / 5) + 25;

            
                // Valor de Cada Parcela //
                txtParcelas1X.Text = juros.ToString("C");
                txtParcelas2X.Text = parcelado2x.ToString("C");
                txtParcelas3X.Text = parcelado3x.ToString("C");
                txtParcelas4X.Text = parcelado4x.ToString("C");
                txtParcelas5X.Text = parcelado5x.ToString("C");

                // Valor Total //
                txtTotal1X.Text = juros.ToString("C");
                txtTotal2X.Text = (parcelado2x * 2).ToString("C");
                txtTotal3X.Text = (parcelado3x * 3).ToString("C");
                txtTotal4X.Text = (parcelado4x * 4).ToString("C");
                txtTotal5X.Text = (parcelado5x * 5).ToString("C");
            }
            catch (Exception)
            {
                MessageBox.Show("Insira valores válidos!");
            }            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpar Áreas de Entrada //
            txtValorOriginal.Clear();
            txtValorJuros.Clear();
            txtParcelas1X.Clear();
            txtParcelas2X.Clear();
            txtParcelas3X.Clear();
            txtParcelas4X.Clear();
            txtParcelas5X.Clear();
            txtTotal1X.Clear();
            txtTotal2X.Clear();
            txtTotal3X.Clear();
            txtTotal4X.Clear();
            txtTotal5X.Clear();
        }
    }
}
