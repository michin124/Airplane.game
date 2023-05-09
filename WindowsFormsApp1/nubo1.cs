using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class nubo1 : objevol1
    {
        public nubo1(int x, int y)
        {
            
            this.x = generar(78);
            this.y = generar(2);


        }
        public void dibujar(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.White), this.x, this.y, this.ancho, this.alto);
        }

        public void setxy(int x,int y)
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

        public int generar(int n)
        {
            Random random = new Random();
            int num = random.Next(0, n) * 9;
            return num;
        }
        public void colocar()
        {
            this.x = generar(78);
            this.y = generar(2);
          

        }
    }
}