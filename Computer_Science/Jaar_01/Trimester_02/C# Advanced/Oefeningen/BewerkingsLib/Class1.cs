using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BewerkingsLib
{
    public class Bewerking
    {
        public int Som(int x, int y)
        {
            return x + y;
        }
        public int Min(int x, int y)
        {
            return x - y;
        }
        public int Maal(int x, int y)
        {
            return x * y;
        }
        public int Deel(int x, int y)
        {
            return x / y;
        }   
    }
}
