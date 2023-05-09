using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class aves : objevol1
    {
        int v = 8;
        public aves(int x, int y,int z,int w,int j,int k)
        {

            this.x = generar(78);
            this.y = 10;



            ancho = 10;
            alto = 25;

            ancho2 = 30;
            alto2 = 6;

            ancho3 = 5;
            alto3 = 5;

            


        }
        public void dibujar(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.RosyBrown), this.x, this.y, this.ancho, this.alto);
            g.FillRectangle(new SolidBrush(Color.RosyBrown), this.z, this.w, this.ancho2, this.alto2);
            g.FillRectangle(new SolidBrush(Color.Yellow), this.j, this.k, this.ancho3, this.alto3);


        }

        public void setxyzwjk(int x, int y,int z,int w,int j,int k)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
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
        public int verz()
        {
            return this.z;

        }
        public int verw()
        {
            return this.w;

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
            int num = random.Next(0, n) * 5;
            return num;
        }
        public void colocar()
        {

            this.x = generar(200);
            this.y = 10;
            this.z = generar(2);


        }
    }
}
