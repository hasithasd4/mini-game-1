using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flying_bird
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 8;
        int gravity = 5;
        int score = 0;
        
        public Form1()
        {
            InitializeComponent();
            groupBox1.Hide();
        }

        private void gametimerevent(object sender, EventArgs e)
        {
         
            bird.Top += gravity;
            pipedown.Left -= pipeSpeed;
            pipetop.Left -= pipeSpeed;
            pipetop2.Left -= pipeSpeed;
            pipedown2.Left -= pipeSpeed;
            scoretext.Text = "Score : " + score;
            label2.Text = " Your Score :  " + score;


            if (pipedown.Left < -150)
            {
                pipedown.Left = 800;
                score++;
            }
            if (pipetop.Left < -180)
            {
                pipetop.Left = 950;
                score++;
            }
            if (pipedown2.Left < -210)
            {
                pipedown2.Left = 1100;
                score++;
            }
            if (pipetop2.Left < -240)
            {
                pipetop2.Left = 1250;
                score++;
            }
            if (bird.Bounds.IntersectsWith(pipedown.Bounds)||
                bird.Bounds.IntersectsWith(pipedown2.Bounds) ||
               bird.Bounds.IntersectsWith(pipetop.Bounds)||
               bird.Bounds.IntersectsWith(pipetop2.Bounds) ||
               bird.Bounds.IntersectsWith(grownd.Bounds))
            {
                endgame();
            }

            if(score > 5)
            {
                pipeSpeed = 10;

                if (score > 15)
                {
                    pipeSpeed = 15;
                }
                if (score > 30)
                {
                    pipeSpeed = 20;
                }
                if (score > 50)
                {
                    pipeSpeed = 30;
                }
            }
            if(bird.Top < -25)
            {
                endgame();
            }
         
        }

        private void gamedown(object sender, KeyEventArgs e)
        {
               if(e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void gameup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void endgame()
        {
            gametimer.Stop();
       
            groupBox1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void restart_Click(object sender, EventArgs e)
        {

       

            Application.Restart();
        }

        private void end_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }

    
}
