using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mygame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Panel player;
        Panel engel = new Panel();
        Panel engel1 = new Panel();
        Panel engel2 = new Panel();
        Panel engel3 = new Panel();
        Panel engel4 = new Panel();
        Panel engel5 = new Panel();
        Panel engel6 = new Panel();
        Panel engel7 = new Panel();
        Panel yemek = new Panel();
        string direction_right = "right";
        string direction_top = "top";
        string direction_left = "left";
        string direction_down = "down";

        private void exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            yandin();
            yemekyedi();

            //soldan gelen engel
            int loca1x = engel1.Location.X;
            int loca1y = engel1.Location.Y;
            if (direction_right == "right")
            {
                if (loca1x < 520 )
                {
                    loca1x += 20;
                   
                }
                else
                {
                    loca1x = 0;
                    Random r1 = new Random();
                    int sayi1 = r1.Next(380);
                    sayi1 -= sayi1 % 20;
                    loca1y = sayi1;
       
                }
                engel1.Location = new Point(loca1x, loca1y);

            }

            int loca11x = engel4.Location.X;
            int loca11y = engel4.Location.Y;
            if(direction_right == "right")
            {
                if(loca11x < 520)
                {
                    loca11x += 20;
                }
                else
                {
                    loca11x = 0;
                    Random r11 = new Random();
                    int sayi11 = r11.Next(380);
                    sayi11 -= sayi11 % 20;
                    loca11y = sayi11;
                }
                engel4.Location = new Point(loca11x,loca11y);
            }

            // yukarıdan gelen engel
            int loca2x = engel.Location.X;
            int loca2y = engel.Location.Y;
            if (direction_top == "top")
            {
                if (loca2y < 380)
                {
                    loca2y += 20;
                }
                else
                {
                    loca2y = 0;
                    Random r2 = new Random();
                    int sayi2 = r2.Next(520);
                    sayi2 -= sayi2 % 20;
                    loca2x = sayi2;
                }
                engel.Location = new Point(loca2x, loca2y);
            }

            int loca22x = engel5.Location.X;
            int loca22y = engel5.Location.Y;
             if(direction_top == "top")
            {
                if (loca22y<380)
                {
                    loca22y += 20;
                }
                else
                {
                    loca22y = 0;
                    Random r22 = new Random();
                    int sayi22 = r22.Next(520);
                    sayi22 -= sayi22 % 20;
                    loca22x = sayi22;
                }
                engel5.Location =  new Point(loca22x, loca22y);
            }

            ///////////////// buranın altındaki engellerin hepsi doğru sonuna kadar gidiyor
            // aşşağıdan gelen engel
            int loca3x = engel2.Location.X;
            int loca3y = engel2.Location.Y;
            if (direction_down == "down")
            {
                if (loca3y > 0)
                {
                    loca3y -= 20;
                }
                else
                {
                    loca3y = 360;
                    Random r3 = new Random();
                    int sayi3 = r3.Next(520);
                    sayi3 -= sayi3 % 20;
                    loca3x = sayi3;
                }
                engel2.Location = new Point(loca3x, loca3y);
            }

            int loca33x = engel6.Location.X;
            int loca33y = engel6.Location.Y;
            if (direction_down == "down")
            {
                if(loca33y > 0)
                { 
                    loca33y -= 20; 
                }
                else
                {
                    loca33y = 360;
                    Random r33 = new Random();
                    int sayi33 = r33.Next(520);
                    sayi33 -= sayi33 % 20;
                    loca33x = sayi33;
                }
                engel6.Location = new Point(loca33x, loca33y);
            }


            //soldan gelen engel
            int loca4x = engel3.Location.X;
            int loca4y = engel3.Location.Y;
            if(direction_left == "left")
            {
                if(loca4x > 0)
                {
                    loca4x -= 20;
                }
                else
                {
                    loca4x = 500;
                    Random r4 = new Random();
                    int sayi4 = r4.Next(380);
                    sayi4 -= sayi4 % 20;
                    loca4y = sayi4;
                }
                engel3.Location = new Point( loca4x, loca4y);
            }

            int loca44x = engel7.Location.X;
            int loca44y = engel7.Location.Y;
            if (direction_left == "left")
            {
                if (loca44x > 0)
                { 
                    loca44x -= 20; 
                }
                else
                {
                    loca44x = 500;
                    Random r44 = new Random();
                    int sayi44 = r44.Next(380);
                    sayi44 -= sayi44 % 20;
                    loca44y =  sayi44;
                }
                engel7.Location = new Point( loca44x, loca44y);
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            // playerin hareketleri
            int x = player.Location.X;
            int y = player.Location.Y;
            

            if(e.KeyCode == Keys.Right)
            {
                if (x < 500) 
                { 
                     x += 20;
                }
            }
            if (e.KeyCode == Keys.Left)
            {
                if(x>0)
                    x -= 20;
            }
            if (e.KeyCode == Keys.Up)
            {
                if(y>0)
                    y -= 20;
            }
            if (e.KeyCode == Keys.Down)
            {
                if(y<360)
                    y += 20;
                
            }
            player.Location = new Point(x,y);
        }
        
        void engeloldu()
        {
            // UST ENGEL 1
            Random rnd = new Random();
            int engelx1 = rnd.Next(520);
            int engely1 = rnd.Next(20);

            engelx1 -= engelx1 % 20;
            engely1 -= engely1 % 20;

            engel.Size = new Size(20, 20);
            engel.BackColor = Color.Brown;
            engel.Location = new Point(engelx1, engely1);
            panel1.Controls.Add(engel);
            // UST ENGEL 2
            Random rnd00 = new Random();
            int engelx11 = rnd00.Next(520);
            int engely11 = rnd00.Next(20);

            engelx11 -= engelx11 % 20;
            engely11 -= engely11 % 20;

            engel6.Size = new Size(20, 20);
            engel6.BackColor = Color.Brown;
            engel6.Location = new Point(engelx11, engely11);
            panel1.Controls.Add(engel6);
            //////////////////////////// SOL ENGEL 1
            Random rnd1 = new Random();
            int engelx2 = rnd1.Next(20);
            int engely2 = rnd1.Next(380);

            engelx2 -= engelx2 % 20;
            engely2 -= engely2 % 20;
                
            engel1.Size = new Size(20, 20);
            engel1.BackColor = Color.Brown;
            engel1.Location = new Point(engelx2, engely2);
            panel1.Controls.Add(engel1);
            //SOL ENGEL 2
            Random rnd11 = new Random();
            int engelx22 = rnd11.Next(20);
            int engely22 = rnd11.Next(380);

            engelx22 -= engelx22 % 20;
            engely22 -= engely22 % 20;

            engel7.Size = new Size(20, 20);
            engel7.BackColor = Color.Brown;
            engel7.Location = new Point(engelx22, engely22);
            panel1.Controls.Add(engel7);
            ////////////////////////// ALT ENGEL 1
            Random rnd2 = new Random();
            int engelx3 = rnd2.Next(520);
            int engely3 = rnd2.Next(360,380);

            engelx3 -= engelx3 % 20;
            engely3 -= engely3 % 20;

            engel2.Size = new Size(20, 20);
            engel2.BackColor = Color.Brown;
            engel2.Location = new Point(engelx3, engely3);
            panel1.Controls.Add(engel2);
            // ALT ENGEL 2
            Random rnd22 = new Random();
            int engelx33 = rnd22.Next(520);
            int engely33 = rnd22.Next(360, 380);

            engelx33 -= engelx33 % 20;
            engely33 -= engely33 % 20;

            engel5.Size = new Size(20, 20);
            engel5.BackColor = Color.Brown;
            engel5.Location = new Point(engelx33, engely33);
            panel1.Controls.Add(engel5);
            ///////////////////////////// SAG ENGEL 1
            Random rnd3 = new Random();
            int engelx4 = rnd3.Next(500,520);
            int engely4 = rnd3.Next(380);

            engelx4 -= engelx4 % 20;
            engely4 -= engely4 % 20;

            engel3.Size = new Size(20, 20);
            engel3.BackColor = Color.Brown;
            engel3.Location = new Point(engelx4, engely4);
            panel1.Controls.Add(engel3);
            //  SAG ENGEL 2
            Random rnd33 = new Random();
            int engelx44 = rnd33.Next(500, 520);
            int engely44 = rnd33.Next(380);

            engelx44 -= engelx44 % 20;
            engely44 -= engely44 % 20;

            engel4.Size = new Size(20, 20);
            engel4.BackColor = Color.Brown;
            engel4.Location = new Point(engelx44, engely44);
            panel1.Controls.Add(engel4);

        }
        void yandin()
        {
             if (player.Location.X == engel.Location.X && player.Location.Y == engel.Location.Y || player.Location == engel1.Location || player.Location == engel2.Location
                || player.Location == engel3.Location || player.Location == engel4.Location || player.Location == engel5.Location || player.Location == engel6.Location || player.Location == engel7.Location)
            {
                timer1.Stop();
                label2.Visible = true;
                label2.Text = "game over";
                player.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            player = new Panel();
            player.Location = new Point(200, 200);
            player.Size = new Size(20, 20);
            player.BackColor = Color.Black;
            panel1.Controls.Add(player);
            engeloldu();
            timer1.Start();
            label2.Visible = false;
            yemekf();
            label4.Text = "0";

        }

        void yemekf()
        {
            Random ry = new Random();
            int yemekx, yemeky;
            yemekx = ry.Next(520);
            yemeky = ry.Next(380);

            yemekx -= yemekx % 20;
            yemeky -= yemeky % 20;

            yemek.Size = new Size(20, 20);
            yemek.BackColor = Color.Yellow;
            yemek.Location = new Point(yemekx,yemeky);
            panel1.Controls.Add(yemek);
        }

        void yemekyedi()
        {
            int puan = int.Parse(label4.Text);
            if (player.Location.X == yemek.Location.X && player.Location.Y == yemek.Location.Y) 
            {
                panel1.Controls.Remove(yemek);
                puan += 1;
                label4.Text = puan.ToString();
                yemekf();
            }
        }
        
    }
}
