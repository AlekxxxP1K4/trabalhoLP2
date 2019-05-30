using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using BO;

namespace BaseL
{
    [Serializable]
    public class Clientes 
    {
        #region ESTADO
        static Dictionary<int, List<Cliente>> clientes= new Dictionary<int, List<Cliente>>();
        static int totalClientes;
        #endregion

        #region METODOS
       

        #region PROPRIEDADES
        /// <summary>
        /// Devolve o total de Clientes
        /// </summary>
        public static int TotalClientes
        {
            set { }
            get { return totalClientes; }
        }

        #endregion

        /// <summary>
        /// Devolve o codigo na hashtable
        /// </summary>
        /// <param name="c">Cliente para devolver o codigo onde vai ser inserido</param>
        /// <returns></returns>
        public static int GetCode(Cliente c)
        {
            return c.NumeroCliente;
        }

        /// <summary>
        /// Inserir o cliente na hashTable
        /// </summary>
        /// <param name="c">Empregado</param>
        /// <returns></returns>
        public static bool GuardaCliente(Cliente c)
        {

            int key = GetCode(c);
            c.Atualizacao = DateTime.Now;
            if (!clientes.ContainsKey(key))
            {
                clientes.Add(key, new List<Cliente> { });
                clientes[key].Add(c);
                totalClientes++;
                Save(@"C:\IPCA\LP2\trabalhoLP2\Clientes.bin");
                return true;
            }
            else
            {
                //c.Atualizacao = DateTime.Now;
                clientes[key].Add(c);
                return true;
            }
        }

        /// <summary>
        /// Procura o registo selecionado do cliente
        /// </summary>
        /// <param name="c">Empregado a procurar</param>
        /// <param name="time">Tempo (DATA) para indicar o local na Lista</param>
        /// <returns></returns>
        public static int ProcuraCliente(Cliente c, DateTime time)
        {
            int key = GetCode(c);
            List<Cliente> a = clientes[key];
            if (a.Contains(c) == true)
            {
                int i = 0;
                foreach (Cliente cli in a)
                {
                    if (a[i].Atualizacao.Date == time.Date)
                    {
                        return i;
                    }
                    i++;
                }
                return 0;
            }
            else return 0;
        }

        /// <summary>
        /// Remover o Empregado
        /// </summary>
        /// <param name="c">Cliente a Remover</param>
        /// <returns></returns>
        public static bool RemoveCliente(Cliente c)
        {

            int key = GetCode(c);
            clientes[key].Remove(c);
            totalClientes--;
            Save(@"");
            return true;
        }
        /// <summary>
        /// Devolve todos os dados do cliente
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static List<Cliente> PegaDados(int key)
        {
            List<Cliente> a = clientes[key];
            return a;
        }

        private static bool Save(string fileName)
        {
            try
            {
                Stream stream = File.Open(fileName, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, clientes);
                stream.Close();
                return true;
            }
            catch (IOException e)
            {
                Console.Write("ERRO:" + e.Message);
                return false;
            }
        }

        private static bool Load(string fileName)
        {
            if (File.Exists(fileName))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.Open);
                    BinaryFormatter bin = new BinaryFormatter();
                    clientes = (Dictionary<int,List<Cliente>>)bin.Deserialize(stream);
                    stream.Close();
                    return true;
                }
                catch (IOException e)
                {
                    Console.Write("ERRO:" + e.Message);
                    return false;
                }
            }
            return false;
        }


        #endregion
    }
}
