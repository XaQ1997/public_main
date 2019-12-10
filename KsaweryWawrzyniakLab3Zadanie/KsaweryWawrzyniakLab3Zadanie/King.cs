using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsaweryWawrzyniakLab3Zadanie
{
    class King:Piece
    {
        public King(bool[,] pos, string named)
        {
            position = pos;
            name = named;
        }
    }
}
