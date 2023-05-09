using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
     

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int tanque=100;
        int p=0;
        int a;
        int m;
        int puntos=0;
        enemig enemig;
        galon galon;
        gasolina gasol;
        bala balin;
        aves chulo;
        piso pisin;
        techo techi;
        ghost punta;
        int xdir = 0;
        int xdir1;
        int ydir = 0;
        int cuadro=40;

        nubo1 nube;
        parede2 pared2;
        pareder pared1;
        nubo2 nube2;
        Graphics g;
        public Form1()
        {
            
          
            InitializeComponent();
           
            gasol = new gasolina(10, 15);
            galon = new galon(50, 0);
            enemig = new enemig(0, 200,0,200,100,200);
            chulo = new aves(0, 0,0,0,0,0);
            techi = new techo(0, 0);
            punta = new ghost(397, 270,280,370,383,300);
            nube = new nubo1(0, 0);
            nube2 = new nubo2(0, 0);
            pared1 = new pareder(0, 00);
            pisin = new piso(0, 310);
            pared2 = new parede2(777, 00);
            balin = new bala(397, 270);
            g = tablero.CreateGraphics();
        }
        public void perder()
        {
            gasol = new gasolina(0, 0);
            galon = new galon(50, 0);
            enemig = new enemig(0, 200,0,200,0,0);
            chulo = new aves(0, 0,0,0,0,0);
            techi = new techo(0, 0);
            punta = new ghost(400, 280,400,280,100,100);
            nube = new nubo1(0, 0);
            balin = new bala(397, 270);
            nube2 = new nubo2(0, 0);
            pared1 = new pareder(0, 00);
            pisin = new piso(0, 310);
            pared2 = new parede2(777, 00);
            
            bucle.Stop();
            MessageBox.Show("GAME_OVER ;c");
  

        }
        
        public void movimiento()
        {
            punta.setxwj(punta.verx() + xdir, punta.verw() + xdir, punta.verj() +xdir) ;
            enemig.setxywzjk(enemig.verx() + (7), enemig.very() + 3, enemig.verx() - (12), enemig.very() + 15, enemig.verx() - (20), enemig.very() + 10);
            nube.setxy(nube.verx()+ (0), nube.very()+8);
            galon.setxy(galon.verx() + (0), galon.very() + 8);
            nube2.setxy(nube2.verx() + (0), nube2.very() + 7);
            chulo.setxyzwjk(chulo.verx() -1, chulo.very() +2,chulo.verx() -12, chulo.very()  + 10,chulo.verx()+ -0, chulo.very() -2);
            balin.setxy(balin.verx() + xdir1, balin.very() -ydir);
            xdir = 0;
            xdir1 = 0;
        }
        private void Bucle_Tick(object sender, EventArgs e) 
        {
            gasolina.Enabled = true;
           
            g.Clear(Color.AliceBlue);
            punta.dibujar(g);
            movimiento();
            pisin.dibujar(g);
            pared1.dibujar(g);
            pared2.dibujar(g);
            nube.dibujar(g);
            nube2.dibujar(g);
            techi.dibujar(g);
            enemig.dibujar(g);
            chulo.dibujar(g);
            balin.dibujar(g);
            gasol.dibujar(g);
            galon.dibujar(g);


            if (enemig.choque(punta))
            {
                perder();
               
            }
            if (chulo.choque(punta))
            {
                perder();


            }
            if (punta.choque(galon))
            {
                gasol.magnus();
                tanque = tanque + 20;
                galon.colocar();
            }
            if (galon.choque(punta))
            {
                gasol.magnus();
                tanque = tanque + 20;
                galon.colocar();
            }




            if (enemig.choque(balin))
            {
                enemig.colocar();
                a = 0;
                balin.setxy(punta.x, punta.y);
                ydir = 0;
                puntos=puntos+ 10;
                point.Text = puntos.ToString();


            }

            if (pisin.choque(nube))
                {
                    nube.colocar();
                }
            if (pisin.choque(galon))
            {
                galon.colocar();
            }

            if (pisin.choque(nube2))
                {
                    nube2.colocar();
                }
                if (pisin.choque(enemig))
                {
                    enemig.colocar();

                }
                if (pisin.choque(chulo))
                {
                    chulo.colocar();
                    

                }
                if(pared1.choque(chulo))
                {
                    chulo.colocar();
                }
            if (balin.choque(chulo))
            {
                chulo.colocar();
                a = 0;
                balin.setxy(punta.x, punta.y);
                ydir = 0;
                puntos = puntos + 5;
                point.Text = puntos.ToString();

            }
            if (balin.choque(enemig))
            {
                enemig.colocar();
                a = 0;
                balin.setxy(punta.x, punta.y);
                ydir = 0;
                puntos =puntos + 10;
                point.Text = puntos.ToString();


            }

            if (techi.choque(balin))
            {
                
                a = 0;
                balin.setxy(punta.x, punta.y);
                ydir = 0;
               

            }
           




        }

        private void Tablero_Click(object sender, EventArgs e)
        {

        }

         void Table_KeyDown(object sender, KeyEventArgs e)
        {
            //if (ejex)
            {
                if (techi.choque(balin))
                {

                    a = 0;
                    balin.setxy(punta.x, punta.y);
                    ydir = 0;
                }



                    if (e.KeyCode == Keys.Right)
                    {


                        xdir = cuadro;
                    
                    }

                    if (e.KeyCode == Keys.Left)
                    {
                        xdir = -cuadro;
                    
                    }
            }
              //  if (ejey)
                {
                    if (e.KeyCode == Keys.Down)
                    {


                        ydir = 10;
                        a = 1;

                    }
                    else
                    {
                        
                    }
                    if (a == 1)
                    {
                        xdir1 = 0;
                    }
                    else
                    {
                        xdir1 = xdir;

                    }


                }
                

            
        }

        public void Gasolina_Tick(object sender, EventArgs e)
        {

            
            gasol.minus();
            tanque=tanque-5;
            if (tanque==0)
            {
                perder();

            }


        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
 
    //escribir_leer();
    //printf('A',%d);
    //if(A=FFFFFA)
    //  {

    //})
}
