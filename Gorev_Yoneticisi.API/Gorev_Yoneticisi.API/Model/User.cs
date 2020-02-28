using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gorev_Yoneticisi.API.Model
{
    public class User
    {
        public User()
        {
            //Works=new List<Work>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }

        //public List<Work> Works { get; set; }

    }
}
