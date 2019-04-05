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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void BtnPersonas_Click(object sender, EventArgs e)
        {
            frmPersona formPersona = new frmPersona();
            formPersona.Visible = true;
        }
    }
}
