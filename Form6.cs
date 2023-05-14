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
    public partial class FormInventario : Form
    {
        public FormInventario()
        {
            InitializeComponent();
        }

        private void btnGestionArticulos_Click(object sender, EventArgs e)
        {
            FormArticulos frm = new FormArticulos();
            frm.ShowDialog();
        }
    }
}
