using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Inventario
{
    public partial class FormRecCont : Form
    {
        public FormRecCont()
        {
            InitializeComponent();
        }

        private void labSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("desea regresar?",
                    "consulta",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormLogin frm = new FormLogin ();
                frm.Show();
                this.Hide();
               
            }

        }
    }
}
