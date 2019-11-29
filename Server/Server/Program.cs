using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            ServerStartForms form = new ServerStartForms();
            ServerControl server = new ServerControl();
            form.m_server = server;
            form.ShowDialog();
        }
    }
}
