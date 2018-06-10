using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyProgram4
{
    public abstract class System: Write
    {
        public override void Escribe(string value)
        {
            Console.WriteLine(" *Database: " + value);
        }
    }
}
