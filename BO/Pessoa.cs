using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    [Serializable]
    public class Pessoa
    {
        #region ESTADO
        string nome;
        int idade;
        int telemovel;
        DateTime dataNasc;
        protected int nif;
        #endregion

        #region METODOS

        #region CONSTRUTORES
        //Métodos usados na criação de novos objectos

        /// <summary>
        /// Construtor com valores por defeito/omissão
        /// </summary>
        public Pessoa()
        {
            idade = -1;
            nome = "";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idade">Idade da Pessoa</param>
        /// <param name="nome">Nome da Pessoa</param>
        public Pessoa(int idade, string nome, int nif)
        {
            this.idade = idade;
            this.nome = nome;
            this.nif = nif;
        }

        #endregion

        #region PROPRIEDADES
        //Métodos usados para manipular atributos do Estado

        /// <summary>
        /// Manipula o atributo "idade"
        /// int idade;
        /// </summary>
        public int Idade
        {
            get { return idade; }
            set { if (value > 0) idade = value; }
        }

        public int Telemovel
        {
            get { return telemovel; }
            set { telemovel = value; }
        }
        /// <summary>
        /// Manipula o atributo "nome"
        /// string nome;
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        /// <summary>
        /// Define data de Nascimento
        /// </summary>
        public DateTime DataNasc
        {
            get { return dataNasc; }
            set
            {
                DateTime aux;
                if (DateTime.TryParse(value.ToString(), out aux) == true)
                {
                    dataNasc = aux;
                }
            }
        }
        /// <summary>
        /// Coloca o NIF
        /// </summary>
        public int NIF
        {
            get { return nif; }
            set
            {
                if (value > 0 && (value.ToString()).Length == 9)
                {
                    nif = value;
                }
            }
        }

        #endregion

        #region OPER
        public static bool operator ==(Pessoa x, Pessoa y)
        {
            return (x.Equals(y));
        }

        public static bool operator !=(Pessoa x, Pessoa y)
        {
            return (!(x == y));
        }
        #endregion

        #region OVERRIDES

        public override bool Equals(Object obj)
        {
            Pessoa aux = (Pessoa)obj;
            return (this.nome == aux.nome && aux.nif == this.nif ? true : false);
        }

        public override string ToString()
        {
            return string.Format("Nome= {0} - Idade= {1}", Nome, Idade);
        }
        #endregion

        #region DEST
        /// <summary>
        /// Destrutor
        /// </summary>
        ~Pessoa()
        {

        }
        #endregion

        #endregion


    }
}
