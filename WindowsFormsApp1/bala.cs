using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class bala : objevol1
    {

        public bala(int x, int y)
        {
            this.x = x;
            this.y = y ;


            ancho = 15;
            alto = 10;

        }

        public void dibujar(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Red), this.x, this.y, this.ancho, this.alto);
        }



        public void setxy(int x, int y)
        {
            this.x = x;
            this.y = y;
            

        }
        public int verx()
        {
            return this.x;


        }
        public int very()
        {
            return this.y;
        }
      
        public void colocar()
        {
            this.x = 0;
            this.y = 0;


        }
    }
}
