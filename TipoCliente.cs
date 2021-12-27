using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourBank
{
    
    internal class TipoCliente
    {
        //public int Comum = 0;
        //public int Super = 1;
        //public int Premium = 2;
        public static int DefineTipoCliente(decimal saldo)
        {
            int tipoCliente = 0;

            if (saldo < 5000)
            {
                tipoCliente = 0;
            }
            else if (saldo < 15000)
            {
                tipoCliente = 1;
            }
            else if (saldo >= 15000)
            {
                tipoCliente = 2;
            }

            return tipoCliente;


        }
    }
}