//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace trabalhoLP2
//{
//    enum Registo
//    {
//        Efetuado,
//        NaoEfetuado,
//    }
//    [Serializable]
//    class Hotel:IHotel
//    {
//        static int MAX = 300;

//        #region ESTADO
//        Quarto[] quartos;
//        string nome;
//        string morada;
//        int quartosMax;

//        #endregion

//        #region METODOS

//        #region CONSTRUTORES
//        /// <summary>
//        /// Construtor Por defeito
//        /// </summary>
//        public Hotel()
//        {
//            quartos =new Quarto[MAX];
//            nome = "";
//            morada = "";
//            quartosMax = 0;
//        }
//        /// <summary>
//        /// Construtor atraves de fora
//        /// </summary>
//        /// <param name="a">Nome do Hotel</param>
//        /// <param name="b">Morada do Hotel</param>
//        /// <param name="c">Quartos Maximos</param>
//        public Hotel(string a, string b,int c)
//        {
//            quartos = new Quarto[c];
//            nome = a;
//            morada = b;
//            quartosMax = c;
//        }

//        #endregion

//        #region PROPRIEDADES
//        /// <summary>
//        /// Define o nome do Hotel
//        /// </summary>
//        public string Nome
//        {
//            get { return nome; }
//            set { nome = value; }
//        }
//        /// <summary>
//        /// Define a Morada do hotel
//        /// </summary>
//        public string Morada
//        {
//            get { return morada; }
//            set { morada = value; }
//        }
//        /// <summary>
//        /// Define os quartos maximos
//        /// </summary>
//        public int QuartosMax
//        {
//            get { return quartosMax; }
//            set { if (value > 0) quartosMax = value; }
//        }


//        #endregion

//        //private void AnulaReservas()
//        //{
//        //    for (int i = 0; i < quartosMax; i++)
//        //    {
//        //quartos[i].Reserva()
//        //    }
//        //}

//        /// <summary>
//        /// Adiciona Registo de um Quarto
//        /// </summary>
//        /// <param name="c">Empregado</param>
//        /// <param name="reserva">DIA DA RESERVA</param>
//        /// <param name="num">NUMERO DO QUARTO</param>
//        /// <param name="add">ADICIOES</param>
//        /// <returns>Se foi efetuado ou nao</returns>
//        public Registo AddRegistoQuarto(Empregado c,string reserva,int num,Adicoes add)
//        {
//            if (quartos[num].Reserva() == true)
//            {
//                quartos[num].Reserva(c, reserva,add);
//                return Registo.Efetuado;
                
//            }
//            else
//            {
//                return Registo.NaoEfetuado;
//            }

//        }
//        /// <summary>
//        /// REMOVE O REGISTO DO QUARTO
//        /// </summary>
//        /// <param name="num">NUMERO DO QUARTO</param>
//        /// <returns></returns>
//        public Registo RemoverRegistoQuarto(int num)
//        {
//            if (quartos[num].Reserva() == false)
//            {
//                quartos[num] = new Quarto();
//                return Registo.Efetuado;
//            }
//            else return Registo.NaoEfetuado;
//        }
//        /// <summary>
//        /// Efetuar checkIn
//        /// </summary>
//        /// <param name="check">tempo do CheckIn</param>
//        /// <param name="num">Numero do quarto</param>
//        /// <returns></returns>
//        public bool EfetuarCheckIn(string check,int num)
//        {
//            if (quartos[num].Reserva() == false)
//            {
//                if (quartos[num].CheckIn(check) == Check.Efetuado)
//                    return true;
//                else return false;
//            }
//            else return false;
//        }

//        /// <summary>
//        /// Efetuar o Pagamento do Alojamento do Quarto
//        /// </summary>
//        /// <param name="num">Numero do Quarto a pagar</param>
//        /// <param name="precoDia">Preco por dia</param>
//        /// <returns></returns>
//        public double EfetuarPagamento(int num,double precoDia)
//        {
//            double valor=quartos[num].Custo(DateTime.Today,precoDia);
//            Console.WriteLine("Quarto Numero - {0} ", num);
//            if (num <= quartosMax* 1 / 4)
//            {
//                Console.WriteLine("Quarto Basico");
//            }
//            if (quartosMax*1/4<num && num <= quartosMax * 2 / 4)
//            {
//                Console.WriteLine("Quarto Medio");
//                valor = valor + 15;
//            }
//            if (quartosMax*2/4<num && num <= quartosMax * 3 / 4)
//            {
//                Console.WriteLine("Quarto Up");
//                valor = valor + 30;
//            }
//            if (num > quartosMax * 3 / 4)
//            {
//                Console.WriteLine("Quarto Elite");
//                valor = valor + 100;
//            }
//            return valor;
//        }


        
//        #region DEST
//       ~Hotel()
//        {

//        }
//        #endregion

//        #endregion
//    }
//}
