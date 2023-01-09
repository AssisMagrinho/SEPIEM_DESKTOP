using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEPIEM
{
    class Usuarios
    {
        public string BI { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }

        public static string error = "Usuário não cadastrado";


        public static bool IsEqual(Usuarios user1, Usuarios user2)
        {
            if(user1 == null || user2 == null) { return false; }

            if(user1.BI != user2.BI)
            {
                error = "Usuário não cadastrado";
                return false;

            }else if(user1.senha != user2.senha)
            {
                error = "Usuário ou Senha Incorretos";
                return false;
            }

            return true;
        }
    }

   
}
