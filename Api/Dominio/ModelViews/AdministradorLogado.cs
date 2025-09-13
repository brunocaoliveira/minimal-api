using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimal_api.Dominio.ModelViews
{
    public class AdministradorLogado
    {
        public string Token { get; set; }
        public string Email { get; set; }  
        public string Perfil { get; set; }
    }
}