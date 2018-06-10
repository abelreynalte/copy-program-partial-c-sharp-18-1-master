using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyProgram4
{
    class Copier
    {
        //Es transparente, si se descomenta empieza usar el mismo método por abstracción.

            /*1era prueba*/
        static Write write = new Database();
        static Read read = new Keyboard();

        /*2da prueba*/
        //static Write write = new System();
        //static Read read = new Scanner();

        /*3era prueba*/
        //static Write write = new Printer();
        //static Read read = new Scanner();

        public static void Copy()
        {
            string value;
            while ((value = (read.Lectura())) != "-1")
            {
                write.Escribe(value);
            }
        }
    }
}
