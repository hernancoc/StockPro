using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Inventario.Entidades
{
    internal class Usuarios
    {
        public string _UserName {  get; set; }
        public string _Password { get; set; }
        public bool _UserActive { get; set; }

    }
}
