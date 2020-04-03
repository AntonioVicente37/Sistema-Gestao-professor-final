using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Cache
{
    public static class UserLoginCache
    {
        public static int Iduser { get; set; }
        public static int Cargo { get; set; }
        public static string Nome { get; set; }
        public static string Sobrenome { get; set; }
        public static string Email { get; set; }
    }
}
