using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Start_a_Travel
{
    public partial class SplashScreen : Form
    {
        int r = 244;
        int g = 65;
        int b = 65;

        public SplashScreen()
        {
            InitializeComponent();

        }


        private void timerR_Tick(object sender, EventArgs e)
        {
            if (b >= 244)
            {
                r -= 1;
                this.BackColor = Color.FromArgb(r, g, b);
                lbl.BackColor = Color.FromArgb(r, g, b);
                if (r <= 65)
                {
                    timerR.Stop();
                    timerG.Start();

                    
                }
            }

            if (b <= 65)
            {
                r += 1;
                this.BackColor = Color.FromArgb(r, g, b);
                lbl.BackColor = Color.FromArgb(r, g, b);
                if (r >= 244)
                {
                    timerR.Stop();
                    timerG.Start();

                }

               

            }
        }

        private void timerG_Tick(object sender, EventArgs e)
        {
            if (r <= 65)
            {
                g += 1;
                this.BackColor = Color.FromArgb(r, g, b);
                lbl.BackColor = Color.FromArgb(r, g, b);
                if (g >= 244)
                {
                    timerG.Stop();
                    timerB.Start();

                 
                }
            }

            if (r >= 244)
            {
                g -= 1;
                this.BackColor = Color.FromArgb(r, g, b);
                lbl.BackColor = Color.FromArgb(r, g, b);
                if (g <= 65)
                {
                    timerG.Stop();
                    timerB.Start();

               
                }
            }
        }

        private void timerB_Tick(object sender, EventArgs e)
        {
            if (g <= 65)
            {
                b += 1;
                this.BackColor = Color.FromArgb(r, g, b);
                lbl.BackColor = Color.FromArgb(r, g, b);
                if (b >= 244)
                {
                    timerB.Stop();
                    timerR.Start();


                }
            }

            if (g >= 244)
            {
                b -= 1;
                this.BackColor = Color.FromArgb(r, g, b);
                lbl.BackColor = Color.FromArgb(r, g, b);
                if (b <= 65)
                {
                    timerB.Stop();
                    timerR.Start();

             
                }
            }
        }

        private void SplashScreenA(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(244, 66, 66);
            lbl.BackColor = Color.FromArgb(r, g, b);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


