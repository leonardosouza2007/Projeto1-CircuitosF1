using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Projeto1LP_CircuitosF1
{
    public partial class CircuitosF1 : Form
    {
        public CircuitosF1()
        {
            InitializeComponent();
            textbox_rsltdCombustivel.Enabled = false;
            textbox_rsltdKMs.Enabled = false;
        }
        private void btnAddCircuitos_Click(object sender, EventArgs e)
        {
            lstboxCircuitos.Items.Add(txtboxNome.Text);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            lstboxCircuitos.Items.Remove(txtboxNome.Text);
        }
        private void btn_AddMarcas_Click(object sender, EventArgs e)
        {
            if (checkBoxMclaren.Checked)
                lstboxMarcas.Items.Add(checkBoxMclaren.Text);

            if (checkBox_Mercedes.Checked)
                lstboxMarcas.Items.Add(checkBox_Mercedes.Text);

            if (checkBox_Ferrari.Checked)
                lstboxMarcas.Items.Add(checkBox_Ferrari.Text);

            if (checkBoxRedbull.Checked)
                lstboxMarcas.Items.Add(checkBoxRedbull.Text);

            if (checkBoxAlpine.Checked)
                lstboxMarcas.Items.Add(checkBoxAlpine.Text);

            if (checkBox_Williams.Checked)
                lstboxMarcas.Items.Add(checkBox_Williams.Text);
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            checkBoxAlpine.Checked = false;
            checkBoxRedbull.Checked = false;
            checkBoxMclaren.Checked = false;
            checkBox_Ferrari.Checked = false;
            checkBox_Mercedes.Checked = false;
            checkBox_Williams.Checked = false;
        }
        private void btnRemover2_Click(object sender, EventArgs e)
        {
            lstboxMarcas.Items.Remove(checkBox_Williams.Text);
            lstboxMarcas.Items.Remove(checkBox_Mercedes.Text);
            lstboxMarcas.Items.Remove(checkBox_Ferrari.Text);
            lstboxMarcas.Items.Remove(checkBoxRedbull.Text);
            lstboxMarcas.Items.Remove(checkBoxMclaren.Text);
            lstboxMarcas.Items.Remove(checkBoxAlpine.Text);
        }

        private void btnConsumo_Click(object sender, EventArgs e)
        {
            if (radiobtnGasolina.Checked)
            {
                textbox_rsltdCombustivel.Text = radiobtnGasolina.Text;
            }
            if (radiobtnGasoleo.Checked)
            {
                textbox_rsltdCombustivel.Text = radiobtnGasoleo.Text;
            }
            textbox_rsltdKMs.Text = ($"{float.Parse(txtboxCombustivel.Text) / float.Parse(txtboxKms.Text)}km/l");
        }


    }
}
