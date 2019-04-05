using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIII_TP1_Winform_Rubinstein
{
    public partial class frmPersona : Form
    {
        private BindingList<frmPersona> listaPersona;
        public frmPersona()
        {
            InitializeComponent();
        }

        private void TxtboxNombre_Checked(object sender, EventArgs e)
        {
            if (txtboxNombre.Text.Trim()  == "")
               txtboxNombre.BackColor = Color.Red;
            else
                txtboxNombre.BackColor = System.Drawing.SystemColors.Control;
        }

        private void TxtboxApellido_Checked(object sender, EventArgs e)
        {
            if (txtboxApellido.Text.Trim() == "")
                txtboxApellido.BackColor = Color.Red;
            else
                txtboxApellido.BackColor = System.Drawing.SystemColors.Control;
        }

        private void DtpNacimiento_Checked(object sender, EventArgs e)
        {
            if (dtpNacimiento.Value > DateTime.Today)
                MessageBox.Show("Pruebe una fecha valida");

            DateTime Fecha = dtpNacimiento.Value;
            int Edad = DateTime.Now.Year - Fecha.Year;

            if (System.DateTime.Now.Subtract(Fecha.AddYears(Edad)).TotalDays < 0)
                lblEdad.Text = Convert.ToString(Edad - 1);

            else
                lblEdad.Text = Convert.ToString(Edad);
                lblEdad.Visible = true;
        }

        private void GboxSexo_Enter(object sender, EventArgs e)
        {
                string sexo = null;
                if (rbtnFemenino.Checked == true)
                    sexo = rbtnFemenino.Text.ToString();
                else if (rbtnMasculino.Checked == true)
                    sexo = rbtnMasculino.Text.ToString();
        }

        private void ClbMusica_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i;
            string music = string.Empty;
            for (i = 0; i <= (clbMusica.Items.Count - 1); i++)
            {
                if (clbMusica.GetItemChecked(i))
                {
                    music = music + clbMusica.Items[i].ToString() + "\n";
                }
            }

        }

        private void BtnAceptarPersona_Click(object sender, EventArgs e)
        {
            if(txtboxNombre.Text.Trim()=="" || txtboxApellido.Text.Trim()=="" || 
                rbtnFemenino.Checked == false && rbtnMasculino.Checked == false ||
                clbMusica.SelectedIndex < 0 || cmbColor.SelectedIndex < 0 )
            {
                MessageBox.Show("Faltan datos por completar");
                return;
            }
            // COLOR
            string color = cmbColor.SelectedItem.ToString();
        }





        private void refreshGrilla()
        {
            listaPersona.ResetBindings();
        }

        private void DgvPersonas_Load(object sender, DataGridViewCellEventArgs e)
        {
            listaPersona = new BindingList<Animal>(listadoAnimales);
            dgvAnimales.DataSource = listaPersona;
        }
    }
}
