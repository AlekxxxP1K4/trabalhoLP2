using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using BO;


namespace trabalhoLP2
{
    class Program
    {
        static void InsertTime(string time,out DateTime finTime)
        {
            DateTime aux;
            bool a = false;
            do
            {
                try
                {
                    aux = DateTime.Parse(time);
                    Console.WriteLine("Data= " + aux.ToString());
                    finTime = aux;
                    a = true;
                }
                catch (FormatException f)
                {

                    Console.WriteLine("ERRO= " + f.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERRO= " + ex.Message);
                }
                finTime = DateTime.Parse("01-01-2000 00:00:00");
            } while (a == false);
           
        }
        static void Main(string[] args)
        {
            DateTime time;
            InsertTime("12-12-2012", out time);
            Cliente p = new Cliente();
            p.NIF = 123456789;
            Empregado a = new Empregado();
            a.Work = TipoTrabalho.Staff;
            ControlClients.AddCliente(p,a);
            Cliente c = new Cliente();
            //Clientes a = new Clientes();
            //c.Nome = "Ana";
            //c.NumeroCliente = a.TotalClientes;
            //a.GuardaCliente(c);

            //Hotel FiveStars = new Hotel();

            //FiveStars.AddRegistoQuarto(c, "01-02-2012", 10,Adicoes.LimpezaBar);

            //Quarto Num12 = new Quarto();

            
            


            //Console.WriteLine(p.NIF);

            Console.ReadKey();
           
        }
    }
}
