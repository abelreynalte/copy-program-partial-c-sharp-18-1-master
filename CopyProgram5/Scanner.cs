using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyProgram4
{
    public abstract class Scanner: Read
    {
        public override string Lectura()
        {
            Console.WriteLine("Scanner - Enter String:");
            return Console.ReadLine();
        }
    }
}
