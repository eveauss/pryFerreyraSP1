namespace pryFerreyraSP1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void gbLogin_Enter(object sender, EventArgs e)
        {



        }
        int intentos = 0;
        private void btnIngresar_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text == "Hola" && txtContraseña.Text == "chau")
            {
                this.Hide();
                frmInicio f = new frmInicio();
                f.Text = txtUsuario.Text;
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos");
                intentos++;
                if (intentos == 3)
                {
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
