using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class gasolina
    {
        public int x,y,ancho,alto,ydor,alti;
        
        public gasolina (int x,int y)
        {
            
            
            ancho = 100;
            alti = 10;
            this.x = x;
            this.y = y;
            

        }

        public void dibujar(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Green), x, this.y, this.ancho, this.alti);
        }

        public void minus()
        {
            ancho=ancho-5;

          

        }

        public void magnus()
        {
            ancho = ancho + 20;
        }

        

    }
}
