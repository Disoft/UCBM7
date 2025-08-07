using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAnalysis
{
    public class LoginService
    {
        private string usuario = "admin";
        private string contraseña = "*****";

        public bool Autenticar(string u, string c)
        {
            return u == usuario && c == contraseña;
        }
    }
}
