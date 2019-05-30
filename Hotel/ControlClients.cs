using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using BaseL;

namespace BL
{
    public class ControlClients
    {
        public static bool AddCliente(Cliente c,Empregado a)
        {
            if (a.Work == TipoTrabalho.Staff)
            {
                Clientes.GuardaCliente(c);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool RemoveCliente(Cliente c, Empregado a)
        {
            if (a.Work == TipoTrabalho.Staff)
            {
                Clientes.RemoveCliente(c);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
