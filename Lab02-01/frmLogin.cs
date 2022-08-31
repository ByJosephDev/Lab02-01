namespace Lab02_01
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //error
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hola");
        }

        private void btnIniciar_Click_1(object sender, EventArgs e)
        {

            List<Usuario> usuarios = new List<Usuario>();
            usuarios.Add(new Usuario { usuario="joseph", password="123"});
            usuarios.Add(new Usuario { usuario = "admin", password = "admin" });

            string user = txtUsuario.Text;
            string pwd = txtPassword.Text;
            bool auth = false;

            foreach (var u in usuarios)
            {
                if(pwd == u.password && user == u.usuario)
                {
                    MessageBox.Show("Logueado correctamente");
                    PrincipalMDI principal = new PrincipalMDI();
                    principal.Show();
                    this.Hide();
                    auth = true;
                    break;
                }
            }

            if (auth == false)
            {
                MessageBox.Show("Credenciales incorrectas");
            }
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}