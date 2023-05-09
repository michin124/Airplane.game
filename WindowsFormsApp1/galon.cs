using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class galon:objevol1
    { 
        public galon(int x, int y)
        {

       
        this.x = generar(78);
        this.y = generar(0);

            ancho = 25;
            alto = 30;


        }
        public void dibujar(Graphics g)
    {
        g.FillRectangle(new SolidBrush(Color.Magenta), this.x, this.y, this.ancho, this.alto);
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

    public int generar(int n)
    {
        Random random = new Random();
        int num = random.Next(0, n) * 7;
        return num;
    }
    public void colocar()
    {
        this.x = generar(78);
        this.y = generar(0);


    }
}
}
