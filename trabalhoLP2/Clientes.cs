//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Runtime.Serialization.Formatters.Binary;//using System.IO;
//using System.Text;

//namespace trabalhoLP2
//{
//    [Serializable]
//    class Clientes : IClientes
//    {
//        #region ESTADO
//         Dictionary<int,List<Empregado>> clientes;
//        int totalClientes;
//        #endregion

//        #region METODOS
//        #region CONSTRUTORES
//        /// <summary>
//        /// Construtor Clientes
//        /// </summary>
//        public Clientes()
//        {
//            clientes = new Dictionary<int,List<Empregado>>();
//            totalClientes = 0;
//        }
//        #endregion

//        #region PROPRIEDADES
//        /// <summary>
//        /// Devolve o total de Clientes
//        /// </summary>
//        public int TotalClientes
//        {
//            set { }
//            get { return totalClientes; }
//        }

//        #endregion

//        /// <summary>
//        /// Devolve o codigo na hashtable
//        /// </summary>
//        /// <param name="c">Empregado para devolver o codigo onde vai ser inserido</param>
//        /// <returns></returns>
//        public int GetCode(Empregado c)
//        {
//            return c.NumeroCliente;
//        }

//        /// <summary>
//        /// Inserir o cliente na hashTable
//        /// </summary>
//        /// <param name="c">Empregado</param>
//        /// <returns></returns>
//        public bool GuardaCliente(Empregado c)
//         {

//            int key = GetCode(c);
//            c.Atualizacao = DateTime.Now;
//            if (!clientes.ContainsKey(key))
//            {
                
//                clientes.Add(key, null);
//                clientes[key].Add(c);
//                totalClientes++;
//                return true;
//            }
//            else
//            {
//                //c.Atualizacao = DateTime.Now;
//                clientes[key].Add(c);
//                totalClientes++;
//                return true;
//            }
//        }

//        /// <summary>
//        /// Procura o registo selecionado do cliente
//        /// </summary>
//        /// <param name="c">Empregado a procurar</param>
//        /// <param name="time">Tempo (DATA) para indicar o local na Lista</param>
//        /// <returns></returns>
//        public int ProcuraCliente(Empregado c,DateTime time)
//        {
//            int key = GetCode(c);
//            List<Empregado> a = clientes[key];
//            if (a.Contains(c) == true)
//            {
//                int i = 0;
//                foreach(Empregado cli in a) {
//                    if (a[i].Atualizacao.Date == time.Date)
//                    {
//                        return i;
//                    }
//                    i++;
//                }
//                return 0;
//            }
//            else return 0;
//        }

//        /// <summary>
//        /// Remover o Empregado
//        /// </summary>
//        /// <param name="c">Empregado a Remover</param>
//        /// <returns></returns>
//        public bool RemoveCliente(Empregado c)
//        {
            
//                int key = GetCode(c);
//                ((List<Empregado>)(clientes[key])).Clear();
//                totalClientes--;
//            Save("@");
//            return true;
//        }

//        private bool Save(string fileName)
//        {
//            try
//            {
//                Stream stream = File.Open(fileName, FileMode.Create);
//                BinaryFormatter bin = new BinaryFormatter();
//                bin.Serialize(stream, clientes);
//                stream.Close();
//                return true;
//            }
//            catch (IOException e)
//            {
//                return false;
//            }
//        }
       
//        #region DEST
//        ~Clientes()
//        {

//        }
//        #endregion
//        #endregion
//    }
//}
