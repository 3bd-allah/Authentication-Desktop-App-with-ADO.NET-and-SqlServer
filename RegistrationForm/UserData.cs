﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationForm
{
    public class UserData
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age{ get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int DptId { get; set; }
    }
}
