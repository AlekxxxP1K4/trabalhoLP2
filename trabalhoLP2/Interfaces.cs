//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace trabalhoLP2
//{
//    interface IQ
//    {
//        bool Reserva();
//        bool Reserva(Empregado p, string reserva, Adicoes add);
//        Check CheckIn(string chegada);

//    }

//    interface IHotel
//    {
//        bool EfetuarCheckIn(string check, int num);
//        Registo RemoverRegistoQuarto(int num);
//        Registo AddRegistoQuarto(Empregado c, string Reserva, int num, Adicoes add);
//        double EfetuarPagamento(int num, double precoDia);
//    }

//    interface IClientes
//    {
//        int GetCode(Empregado c);
//        bool RemoveCliente(Empregado c);
//        bool GuardaCliente(Empregado c);
//        int ProcuraCliente(Empregado c, DateTime time);
//    }
//}
