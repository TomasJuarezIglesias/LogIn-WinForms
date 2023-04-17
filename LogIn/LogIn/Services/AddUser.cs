using LogIn.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogIn.Services
{
    public class AddUser : DBInformation
    {

        public AddUser(DBSearch information)
        {
            UserInput = information.UserInput;
            TheUser = information.TheUser;
            IsHere = information.IsHere;
            IncrementId = information.IncrementId;

        }

        public string Add()
        {
            if (IsHere)
            {
                return "El nombre de usuario elegido ya esta en uso";
            }
            using (var context = new LoginContext())
            {
                var newUser = new User
                {
                    Id = IncrementId,
                    Username = UserInput.UserName,
                    Password = UserInput.Password
                };

                context.Users.Add(newUser);
                context.SaveChanges();
            }

            return "Te haz registrado correctamente";
        }

    }
}
