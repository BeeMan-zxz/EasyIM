using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dos.ORM;

namespace ClientUser.Database
{
    class DB
    {
        public static readonly DbSession Context = new DbSession("Sqlit");
    }
}
