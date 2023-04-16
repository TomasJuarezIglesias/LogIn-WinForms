using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogIn.Models;
using Microsoft.IdentityModel.Tokens;

namespace LogIn.Services
{
    public class DB
    {
        private UserInput userInput;
        private User? theUser = null;
        private bool isHere = false;
        private int incrementId = 0;

        // Se le ingresa el usuario que se desea logear o registrar
        public DB(UserInput aUser)
        {
            userInput = aUser;
        }

        // Busqueda de usuario
        public void DBSearch()
        {
            List<User> userList = new List<User>();
            using (var context = new LoginContext())
            {
                foreach (var user in context.Users)
                {
                    // se utiliza para incrementar el id para luego lograr insertar nuevos usuarios a la tabla
                    incrementId++;
                    userList.Add(user);
                }
            }

            var usuario = userList
                .Where(u => u.Username.Contains(userInput.UserName))
                .Select(u => u);

            // Si llega null or empty es porque no existe ese nombre de usuario
            if (usuario.IsNullOrEmpty())
            {
                return;
            }

            theUser = usuario.First();
            isHere = true;
        }

        // Metodo para comparar si la contraseña coincide
        public string ComparePassword()
        {
            if (!isHere) 
            {
                return "Usuario no encontrado";
            }
            if (userInput.Password != theUser?.Password)
            {
                return "La Contraseña es incorrecta";
            }

            return "Te haz logeado correctamente";
        }

        // Metodo para agregar un nuevo usuario
        public string AddUser()
        {
            if (isHere)
            {
                return "El nombre de usuario elegido ya esta en uso";
            }
            using (var context = new LoginContext())
            {
                var newUser = new User();
                newUser.Id = incrementId;
                newUser.Username = userInput.UserName;
                newUser.Password = userInput.Password;

                context.Users.Add(newUser);
                context.SaveChanges();
            }

            return "Te haz registrado correctamente";
        }


    }
}
