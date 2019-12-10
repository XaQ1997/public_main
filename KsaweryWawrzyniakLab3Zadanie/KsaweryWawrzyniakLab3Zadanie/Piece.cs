using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsaweryWawrzyniakLab3Zadanie
{
    class Piece
    {
        protected bool[,] position = new bool[8, 8];
        protected string name;

        /// <summary>
        /// Metody zwracające argumenty klasy
        /// </summary>
        /// <returns></returns>
        public bool[,] GetPosition()
        {
            return position;
        }

        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// Metoda modyfikująca pozycję bierki
        /// </summary>
        /// <param name="field"></param>
        
        public void SetPosition(int column, int row)
        {
            for(int i=0;i<8;++i)
            {
                for(int j=0;j<8;++j)
                {
                    if (i != column)
                    {
                        position[i, j] = false;
                    }
                    else
                    {
                        if (j != row)
                        {
                            position[i, j] = false;
                        }
                        else
                        {
                            position[i, j] = true;
                        }
                    }
                }
            }
        }
    }
}
