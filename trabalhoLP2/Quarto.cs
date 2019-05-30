//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace trabalhoLP2
//{
//    enum Adicoes
//    {
//        LimpezaDiaria=5,
//        Bar=10,
//        LimpezaBar=14,
//    }
//    enum Status
//    {
//        Reserved,
//        NotReserved
//    }
//    enum Check
//    {
//        Efetuado=1,
//        NaoEfetuado=-1
//    }
//    [Serializable]
//    class Quarto:IQ
//    {
//        #region ESTADO
//        Status status;
//        Empregado cli;
//        DateTime reserva;
//        Adicoes adicoes;
//        Check check;

//        #endregion

//        #region CONSTRUTORES
//        public Quarto()
//        {
//            status = Status.NotReserved;
//            cli = new Empregado();
//        }
//        public Quarto(Empregado p, string a)
//        {
//            cli = p;
//            reserva = DateTime.Parse(a);
//            status = Status.Reserved;
//        }
//        #endregion

//        #region METODOS
//        /// <summary>
//        /// Devolve se o quarto esta reservado
//        /// </summary>
//        /// <returns></returns>
//        public bool Reserva()
//        {
//            if (status == Status.NotReserved)
//            {
//                return true;
//            }
//            else return false;
//        }
//        /// <summary>
//        /// Devolve se reservou o quarto <true> se nao <false>
//        /// </summary>
//        /// <param name="p">Empregado</param>
//        /// <param name="Reserva">Dia da Reserva</param>
//        /// <param name="add">Adicioes</param>
//        /// <returns></returns>
//        public bool Reserva(Empregado p,string reserva,Adicoes add)
//        {
//            if (cli.NIF != 0 && status==Status.NotReserved)
//            {
//                cli = p;
//                DateTime.TryParse(reserva,out this.reserva);
                
//                status= Status.Reserved;
//                adicoes = add;
//                return true;
//            }
//            else
//            {
//                return false;
//            }
            
//        }
//        /// <summary>
//        /// Efetua CheckIn
//        /// </summary>
//        /// <param name="chegada">TEMPO da Chegada</param>
//        /// <returns>Se efetuou ou nao</returns>
//        public Check CheckIn(string chegada)
//        {
//            DateTime cheg = DateTime.Parse(chegada);
//            if (cheg.Hour <= reserva.Hour - 1)
//            {
//                check = Check.Efetuado;
//                return check;
//            }
//            else
//            {
//                return Check.NaoEfetuado;
//            }
//        }
//        /// <summary>
//        /// Clacula o Custo do quarto
//        /// </summary>
//        /// <param name="fim">TEMPO QUANDO SAI</param>
//        /// <param name="precoDia">PRECO POR DIA DO QUARTO</param>
//        /// <returns></returns>
//        public double Custo(DateTime fim,double precoDia)
//        {
//            return cli.TotalPagar(fim, reserva,precoDia,adicoes);
//        }
//        /// <summary>
//        /// Retrona Empregado
//        /// </summary>
//        /// <returns></returns>
//        public Empregado CliReservado()
//        {
//            return cli;
//        }
//        #endregion


//        #region DEST
//        ~Quarto()
//        {

//        }
//        #endregion
        
//    }
//}
