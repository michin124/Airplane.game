using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ghost:objevol1
    {
        
        public ghost(int x, int y,int z,int w,int j,int k)
        {
            
            this.x = x;
            this.y = y;

        
            this.z = z;
            this.w = w;

            this.j = j;
            this.k = k;

            ancho = 15;
            alto = 45;
            ancho2 = 70;
            alto2 = 10;
            ancho3 = 45;
            alto3 = 7;
           
        }
        public void dibujar (Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Gray), this.x, this.y, this.ancho, this.alto);
            g.FillRectangle(new SolidBrush(Color.Gray), this.w, this.z, this.ancho2, this.alto2);
            g.FillRectangle(new SolidBrush(Color.Gray), this.j, this.k, this.ancho3, this.alto3);
         

        }
               
        public void setxwj(int x,int w,int j)
        {
            this.x = x;
            this.w = w;
            this.j = j;

        }
        public int verx()
        {
            return this.x;
           

        }
        public int verw()
        {
            return this.w;
        }
        public int verj()
        {
            return this.j;
        }


    }
}
