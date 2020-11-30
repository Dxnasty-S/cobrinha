using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cobrinha
{
    class Entrada
    {
        public static Hashtable tabelaDeTeclas = new Hashtable();

        public static bool PressionarTecla(Keys tecla)
        {
            if (tabelaDeTeclas[tecla] == null)
            {
                return false;
            }

            return (bool)tabelaDeTeclas[tecla];
        }

        public static void MudarEstado (Keys tecla, bool estado)
        {
            tabelaDeTeclas[tecla] = estado;
        }
    }
}
