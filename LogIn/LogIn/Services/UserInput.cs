using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogIn.Services
{
    // Clase para lograr instanciar objetos a partir de los datos ingresados
    public  class UserInput
    {
        public string? UserName { get; private set; }

        public string? Password { get; private set; }


        public UserInput(string username, string password)
        {
            UserName = username;
            Password = password;
        }

    }
}
