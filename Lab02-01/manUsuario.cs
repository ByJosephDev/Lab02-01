using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class manUsuario : Form
    {
        public manUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text;
            string name = txtNombre.Text;
            string lastname = txtApellido.Text;
            string tel = txtTel.Text;
            string dir = txtDir.Text;
            string dateB = dtpFecNac.Text;
            string email = txtEmail.Text;

            dgvUsuarios.Rows.Add(dni, name, lastname, tel, dir, dateB, email);

        }
    }
}
