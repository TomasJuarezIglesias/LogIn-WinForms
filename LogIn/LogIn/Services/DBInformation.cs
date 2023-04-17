using LogIn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogIn.Services
{
    public  class DBInformation
    {

        public  UserInput? UserInput{ get; protected set; }

        public User? TheUser { get; protected set; }

        public bool IsHere { get; protected set; }

        public int IncrementId { get; protected set; }

    }
}
