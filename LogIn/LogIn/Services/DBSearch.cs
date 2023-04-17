using LogIn.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogIn.Services
{
    public class DBSearch : DBInformation
    {
        public DBSearch(UserInput aUser)
        {
            UserInput = aUser;
        }

        public void Search()
        {
            List<User> userList = new();
            using (var context = new LoginContext())
            {
                foreach (var user in context.Users)
                {
                    // se utiliza para incrementar el id para luego lograr insertar nuevos usuarios a la tabla
                    IncrementId++;
                    userList.Add(user);
                }
            }

            var usuario = userList
                .Where(u => u.Username.Contains(UserInput.UserName))
                .Select(u => u);

            // Si llega null or empty es porque no existe ese nombre de usuario
            if (usuario.IsNullOrEmpty())
            {
                return;
            }

            TheUser = usuario.First();
            IsHere = true;
        }

    }
}
