using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsaweryWawrzyniakLab3Zadanie
{
    class Rook:Piece
    {
        public Rook(bool[,] pos, string named)
        {
            position = pos;
            name = named;
        }
    }
}
