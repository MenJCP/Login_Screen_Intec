﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Registro_intec_xam.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        
       
        public User() { }
        public User (string Username,string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }

       
        public bool CheckInfo()
        {
            if (!string.IsNullOrEmpty(this.Username) || (!string.IsNullOrEmpty(this.Password)))
                return true;
            else
                return false;
        }
    }
}
