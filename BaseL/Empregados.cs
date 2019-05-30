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
    public class Empregados
    {
        #region ESTADO
        static Dictionary<int, List<Empregado>> empregados = new Dictionary<int, List<Empregado>>();
        static int totalEmpregados;
        #endregion

        #region METODOS


        #region PROPRIEDADES
        /// <summary>
        /// Devolve o total de Clientes
        /// </summary>
        static public int TotalEmpregados
        {
            set { }
            get { return totalEmpregados; }
        }

        #endregion

        /// <summary>
        /// Devolve o codigo na hashtable
        /// </summary>
        /// <param name="c">Empregado para devolver o codigo onde vai ser inserido</param>
        /// <returns></returns>
        static public int GetCode(Empregado c)
        {
            return c.NumEmpregado;
        }

        /// <summary>
        /// Inserir o cliente na hashTable
        /// </summary>
        /// <param name="c">Empregado</param>
        /// <returns></returns>
        static public bool GuardaEmpregado(Empregado c)
        {
            int key = GetCode(c);
            c.Atualizacao = DateTime.Now;
            if (!empregados.ContainsKey(key))
            {

                empregados.Add(key, null);
                empregados[key].Add(c);
                totalEmpregados++;
                return true;
            }
            else
            {
                //c.Atualizacao = DateTime.Now;
                empregados[key].Add(c);
                return true;
            }
        }

        /// <summary>
        /// Procura o registo selecionado do cliente
        /// </summary>
        /// <param name="c">Empregado a procurar</param>
        /// <param name="time">Tempo (DATA) para indicar o local na Lista</param>
        /// <returns></returns>
        static public int ProcuraEmpregado(Empregado c, DateTime time)
        {
            int key = GetCode(c);
            List<Empregado> a = empregados[key];
            if (a.Contains(c) == true)
            {
                int i = 0;
                foreach (Empregado cli in a)
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
        /// <param name="c">Empregado a Remover</param>
        /// <returns></returns>
        static public bool RemoveEmpregado(Empregado c)
        {

            int key = GetCode(c);
            empregados[key].Remove(c);
            totalEmpregados--;
            Save("@");
            return true;
        }
        /// <summary>
        /// Devolve todos os dados do cliente
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        static public List<Empregado> PegaDados(int key)
        {
            List<Empregado> a = empregados[key];
            return a;
        }

        static private bool Save(string fileName)
        {
            try
            {
                Stream stream = File.Open(fileName, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, empregados);
                stream.Close();
                return true;
            }
            catch (IOException e)
            {
                Console.Write("ERRO:" + e.Message);
                return false;
            }
        }


        #endregion
    }
}
