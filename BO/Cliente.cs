using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    [Serializable]
    public class Cliente : Pessoa
    {
        #region ESTADO
        int numeroCliente;
        double totalPagar;
        DateTime ultimaAtualizcao;
        #endregion

        #region METODOS
        /// <summary>
        /// POR DEFEITO
        /// </summary>
        public Cliente() : base()
        {
            numeroCliente = 0;
            totalPagar = 0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idade">IDADE</param>
        /// <param name="nome">NOME</param>
        /// <param name="nif">NIF</param>
        /// <param name="num">NUM</param>
        public Cliente(int idade, string nome, int nif, int num) : base(idade, nome, nif)
        {
            numeroCliente = num;
        }


        #region Propriedades
        /// <summary>
        ///Numero CLiente
        /// </summary>
        public int NumeroCliente
        {
            get { return numeroCliente; }
            set { numeroCliente = value; }
        }

        /// <summary>
        /// Colocar a data do registo
        /// </summary>
        public DateTime Atualizacao
        {
            get { return ultimaAtualizcao; }
            set
            {
                if (ultimaAtualizcao == null)
                    ultimaAtualizcao = value;
            }
        }

        #endregion

        #region OVERRIDES

        public override bool Equals(Object obj)
        {
            Cliente aux = (Cliente)obj;
            return (this.numeroCliente == aux.numeroCliente ? true : false);
        }
        #endregion
        #region OPER
        public static bool operator ==(Cliente x, Cliente y)
        {
            return (x.Equals(y));
        }

        public static bool operator !=(Cliente x, Cliente y)
        {
            return (!(x == y));
        }
        #endregion

        /// <summary>
        /// Total a pagar
        /// </summary>
        /// <param name="fim">Ultimo Dia da RESERVA</param>
        /// <param name="reserva">INICIO DA RESERVA</param>
        /// <param name="precoDia">PRECO POR DIA</param>
        /// <param name="add">ADICIOES NO QUARTO</param>
        /// <returns></returns>
        public double TotalPagar(DateTime fim, DateTime reserva, double precoDia, Adicoes add)
        {
            int tempo;
            tempo = fim.Day - reserva.Day;
            if (numeroCliente < 1000)
            {
                totalPagar = (precoDia * tempo) - (precoDia * tempo) * 1 / 4;
            }
            if (numeroCliente < 10000)
            {
                totalPagar = (precoDia * tempo) - (precoDia * tempo) * 1 / 5;
            }
            else totalPagar = (precoDia * tempo);

            return (totalPagar + (int)add * tempo);
        }


        #endregion

        #region DEST
        ~Cliente()
        {

        }
        #endregion
    }
}
