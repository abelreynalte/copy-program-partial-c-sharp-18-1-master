using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyProgram4
{
    public class Keyboard: Read
    {
        
        public override string Lectura()
        {
            Console.WriteLine("Keyboard - Enter String:");
            return Console.ReadLine();
        }
    }
}
