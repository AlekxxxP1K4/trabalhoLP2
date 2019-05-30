using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public enum Adicoes
    {
        LimpezaDiaria = 5,
        Bar = 10,
        LimpezaBar = 14,
    }
    public enum Status
    {
        Reserved,
        NotReserved
    }
    public enum Check
    {
        Efetuado = 1,
        NaoEfetuado = -1
    }
    public enum TipoTrabalho
    {
        Recessao,
        Bar,
        Limpeza,
        Seguranca,
        Staff,

    }
    public enum Registo
    {
        Efetuado,
        NaoEfetuado,
    }
}
