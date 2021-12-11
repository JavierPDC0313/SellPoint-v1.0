using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private void atsmInventario_Click(object sender, EventArgs e)
        {
            FormAgregarEntidades formAgregar = new FormAgregarEntidades();
            formAgregar.MdiParent = this;
            formAgregar.Show();
        }
    }
}
