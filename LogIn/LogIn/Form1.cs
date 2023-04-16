using LogIn.Models;
using LogIn.Services;
namespace LogIn
{
    public partial class Form1 : Form
    {
        // Se utiliza para lograr saber si el boton ha sido tocado
        bool[] btnClickShowPassword = { false, false, false };
        // Posiciones: 0 = password login, 1 = password register y 2 = password repeat.
        public Form1()
        {
            InitializeComponent();
        }
        // Metodo generico para mostrar y no mostrar la contraseña
        public void ShowPassword(TextBox textbox, int btn)
        {
            if (!btnClickShowPassword[btn])
            {
                textbox.UseSystemPasswordChar = false;
                btnClickShowPassword[btn] = true;
                return;
            }
            textbox.UseSystemPasswordChar = true;
            btnClickShowPassword[btn] = false;
        }

        private void BtnShowPassword_Click(object sender, EventArgs e)
        {
            ShowPassword(TxtPasswordLogin,0);
        }
        private void BtnShowpasswordRegister_Click(object sender, EventArgs e)
        {
            ShowPassword(TxtPasswordRegister, 1);
        }
        private void BtnShowpasswordRepeat_Click(object sender, EventArgs e)
        {
            ShowPassword(TxtPasswordRegisterRepeated, 2);
        }

        // Metodo para validar entrada de datos en el login
        public bool LoginVerificaitons()
        {
            if (TxtUserLogin.Text.Length == 0 || TxtPasswordLogin.Text.Length == 0)
            {
                MessageBox.Show("Complete todos los espacios en blanco para el Login");
                return false;
            }
            return true;
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            bool canContinue = LoginVerificaitons();
            // Detiene la ejecion del metodo
            if (!canContinue) { return; }

            // Creacion objeto para utilizar base de datos
            UserInput aUser = new UserInput(TxtUserLogin.Text, TxtPasswordLogin.Text);
            DB dB = new DB(aUser);
            dB.DBSearch();
            string mensaje = dB.ComparePassword();
            MessageBox.Show(mensaje);

            CleanTextBox();
        }

        // Metodo para validad entrada de datos en el register
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

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            bool canContinue = RegisterVerifications();
            if (!canContinue) { return; }

            // Creacion objeto para utilizar base de datos
            UserInput aUser = new UserInput(TxtUserRegister.Text, TxtPasswordRegister.Text);
            DB db = new DB(aUser);
            db.DBSearch();
            string mensaje = db.AddUser();
            MessageBox.Show(mensaje);
            CleanTextBox();
        }

        // Metodo para limpiar todas las text box
        public void CleanTextBox()
        {
            TxtUserLogin.Text = string.Empty;
            TxtPasswordLogin.Text = string.Empty;
            TxtUserRegister.Text = string.Empty;
            TxtPasswordRegister.Text = string.Empty;
            TxtPasswordRegisterRepeated.Text = string.Empty;
        }

    }
}