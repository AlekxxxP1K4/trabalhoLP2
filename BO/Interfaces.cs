using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    interface IQ
    {
        bool Reserva();
        bool Reserva(Cliente p, string reserva, Adicoes add);
        Check CheckIn(string chegada);

    }

    interface IHotel
    {
        bool EfetuarCheckIn(string check, int num);
        Registo RemoverRegistoQuarto(int num);
        Registo AddRegistoQuarto(Cliente c, string Reserva, int num, Adicoes add);
        double EfetuarPagamento(int num, double precoDia);
    }

    interface IClientes
    {
        int GetCode(Cliente c);
        bool RemoveCliente(Cliente c);
        bool GuardaCliente(Cliente c);
        int ProcuraCliente(Cliente c, DateTime time);
    }
}
