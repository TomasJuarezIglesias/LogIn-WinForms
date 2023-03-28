namespace LogIn
{
    public partial class Form1 : Form
    {
        // Se utiliza para lograr saber si el boton ha sido tocado
        bool btnClickShowPassword = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void BtnShowPassword_Click(object sender, EventArgs e)
        {
            if (!btnClickShowPassword)
            {
                TxtPasswordLogin.UseSystemPasswordChar = false;
                btnClickShowPassword = true;
                return;
            }
            TxtPasswordLogin.UseSystemPasswordChar = true;
            btnClickShowPassword = false;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            bool canContinue = LoginVerificaitons();
            // Detiene la ejecion del metodo
            if (!canContinue) { return; }



            CleanTextBox();
        }

        public bool LoginVerificaitons()
        {
            if (TxtUserLogin.Text.Length == 0 || TxtPasswordLogin.Text.Length == 0)
            {
                MessageBox.Show("Complete todos los espacios en blanco para el Login");
                return false;
            }
            return true;
        }

        public bool RegisterVerifications()
        {
            if (TxtUserRegister.Text.Length == 0 || TxtPasswordRegister.Text.Length == 0 || TxtPasswordRegisterRepeated.Text.Length == 0)
            {
                MessageBox.Show("Complete todos los espacios en blanco para registrarse");
                return false;
            }

            if (TxtPasswordRegister.Text != TxtPasswordRegisterRepeated.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return false;
            }

            return true;

        }



        public void CleanTextBox()
        {
            TxtUserLogin.Text = string.Empty;
            TxtPasswordLogin.Text = string.Empty;
            TxtUserRegister.Text = string.Empty;
            TxtPasswordRegister.Text = string.Empty;
            TxtPasswordRegisterRepeated.Text = string.Empty;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            bool canContinue = RegisterVerifications();
            if (!canContinue) { return; }   






            CleanTextBox();
        }
    }
}