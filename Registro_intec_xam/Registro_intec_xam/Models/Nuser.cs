using System;
using System.Collections.Generic;
using System.Text;

namespace Registro_intec_xam.Models
{
    public class Nuser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password1 { get; set; }
        public string Password2 { get; set; }

        public Nuser() { }
        public Nuser(string Name, string Email, string Password, string Password2)
        {
            this.Name = Name;
            this.Email = Email;
            this.Password1 = Password1;
            this.Password2 = Password2;
        }

        public bool CheckNinfo()
        {
            if (!string.IsNullOrEmpty(this.Name) || (!string.IsNullOrEmpty(this.Email) || (!string.IsNullOrEmpty(this.Password1) || (!string.IsNullOrEmpty(this.Password2)))))
                return true;
            else
                return false;
        }
    }
}
