using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders5
{
    public static class Liste
    {
        public static List<User> Kullanicilar =new List<User>()
        {
          new User(){Kadi="ahmet",Parola="123456"},
          new User(){Kadi="ali",Parola="asd123"}

        };
    }
}
