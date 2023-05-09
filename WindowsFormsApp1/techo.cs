using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class techo : objevol1
    {
        public techo(int x, int y)
        {
            this.x = x;
            this.y = y;
            ancho = 777;
            alto = 10;

        }
        public void dibujar(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.White), this.x, this.y, this.ancho, this.alto);
        }

        public void setxy(int x, int y)
        {
            this.x = x;
            this.y = y;



        }
    }
}