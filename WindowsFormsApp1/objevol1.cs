using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class objevol1
    {
        public int x, y,z,w,j,k, ancho, alto,ancho2,alto2,ancho3,alto3;
        public objevol1()
        {
            ancho = 200;
            alto = 50;

        }

        public Boolean choque(objevol1 o)
        {
            int difx = Math.Abs(this.x - o.x);
            int dify = Math.Abs(this.y - o.y);

            if (difx >= 0 && difx < ancho && dify >= 0 && dify < alto)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
    }
}

