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
    }
}