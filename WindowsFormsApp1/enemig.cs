using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class enemig :objevol1
    {
        int v = 8;
        public enemig(int x, int y,int w,int z,int j,int k)
        {

            this.x = generar(0);
            this.y = generar(40);
            this.z = generar(30);


            ancho = 15;
            alto = 35;
            ancho2 = 45;
            alto2 = 13;
            ancho3 = 10;
            alto3 = 22;
          


             
        }
        public void dibujar(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Black), this.x, this.y, this.ancho, this.alto);
            g.FillRectangle(new SolidBrush(Color.Black), this.w, this.z, this.ancho2, this.alto2);
            g.FillRectangle(new SolidBrush(Color.Black), this.j, this.k, this.ancho3, this.alto3);

        }

        public void setxywzjk(int x, int y,int w,int z,int j,int k)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.z = z;
            this.j = j;
            this.k = k;


        }
        public int verx()
        {
            return this.x;

        }
        public int very()
        {
            return this.y;

        }

        public int verw()
        {
            return this.w;

        }

        public int verz()
        {
            return this.z;

        }

        public int verj()
        {
            return this.j;

        }
        public int verk()
        {
            return this.k;

        }
        public int generar(int n)
        {
            Random random = new Random();
            int num = random.Next(0, n) * 8;
            return num;
        }
        public void colocar()
        {
            this.x = generar(0);
            this.y = generar(40);
       
            

        }
    }
}

