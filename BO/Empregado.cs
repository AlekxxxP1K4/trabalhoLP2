using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    [Serializable]
    public class Empregado : Pessoa
    {
        #region ESTADO
        TipoTrabalho work;
        DateTime inicioTrabalho;
        string morada;
        double vencimento;
        int numEmpregado=0;
        DateTime ultimaAtualizcao;

        #endregion

        #region METODOS

        #region CONSTRUTORES
        /// <summary>
        /// por defenição
        /// </summary>
        public Empregado() : base()
        {
            inicioTrabalho = DateTime.Parse("01/01/2000");
            vencimento = 0;
            morada = "";
            work = TipoTrabalho.Limpeza;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="i">Idade</param>
        /// <param name="n">Nome</param>
        /// <param name="nif">NIF</param>
        /// <param name="venc">Vencimento</param>
        public Empregado(int i, string n, int nif, float venc) : base(i, n, nif)
        {
            vencimento = venc;
        }

        #endregion

        #region PROPRIEDADES
        public DateTime InicioTrabalho
        {
            get { return inicioTrabalho; }
            set
            {
                DateTime aux;
                if (DateTime.TryParse(value.ToString(), out aux) == true)
                {
                    inicioTrabalho = value;
                }
            }
        }

        public DateTime Atualizacao
        {
            get { return ultimaAtualizcao; }
            set
            {
                if (ultimaAtualizcao == null)
                    ultimaAtualizcao = value;
            }
        }
        /// <summary>
        /// Defenir morada
        /// </summary>
        public string Morada
        {
            get { return morada; }
            set { morada = value; }
        }
        /// <summary>
        /// define o trabalho
        /// </summary>
        public TipoTrabalho Work
        {
            get { return work; }
            set { work = value; }
        }
        public int NumEmpregado
        {
            get { return numEmpregado; }
            set { if (numEmpregado == 0) numEmpregado = value; }
        }
        /// <summary>
        /// Defenir  vencimento
        /// </summary>
        public double Vencimento
        {
            get
            {
                if (CodPessoa() == true)
                {
                    return vencimento;
                }
                else
                {
                    Console.WriteLine("Codigo Incorreto");
                    return 0000;
                }
            }
            set
            {
                vencimento = value - value * 0.23;
                switch (work)
                {
                    case TipoTrabalho.Limpeza:
                        {
                            vencimento = vencimento + 10;
                            break;
                        }
                    case TipoTrabalho.Bar:
                        {
                            vencimento = vencimento + 50;
                            break;
                        }
                    case TipoTrabalho.Recessao:
                        {
                            vencimento = vencimento + 250;
                            break;
                        }
                    case TipoTrabalho.Seguranca:
                        {
                            vencimento = vencimento + 100;
                            break;
                        }
                    case TipoTrabalho.Staff:
                        {
                            vencimento = vencimento + 3 * value * 0.25;
                            break;
                        }
                }
            }
        }

        /// <summary>
        /// Privado para vereficar o codigo de pessoa NIF
        /// </summary>
        /// <returns></returns>
        private bool CodPessoa()
        {
            int c = Convert.ToInt32(Console.ReadLine());
            if (c == base.nif)
            {
                return true;
            }
            else return false;
        }

        #endregion
        #region DEST
        ~Empregado()
        {

        }
        #endregion
        #endregion
    }
}
