using LogIn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogIn.Services
{
    public class ComparePassword : DBInformation
    {

        public ComparePassword(DBSearch information)
        {
            UserInput = information.UserInput;
            TheUser = information.TheUser;
            IsHere = information.IsHere;
            IncrementId = information.IncrementId;
        }

        // Metodo para comparar si la contraseña coincide
        public string Compare()
        {
            if (!IsHere)
            {
                return "Usuario no encontrado";
            }
            if (UserInput?.Password != TheUser?.Password)
            {
                return "La Contraseña es incorrecta";
            }

            return "Te haz logeado correctamente";
        }

    }
}
