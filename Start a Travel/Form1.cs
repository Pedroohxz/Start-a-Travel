using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Start_a_Travel
{
    public partial class Form1 : Form
    {
        bool Hided;
        string pasta_img = "";
        string pasta_imagens = "";
        SplashScreen screen = new SplashScreen();

        string Paises;

        public Form1()

            

        {

         



            InitializeComponent();
            screen.ShowDialog();

            panel_bottom.Visible = false;

            

            sidemenu.Height = 50;

            MenuStrip.Visible = false;

            pasta_img = Application.StartupPath + @"/img/";
            pasta_imagens = Application.StartupPath + @"/images/";

            Paises = null;
            MnuStrip_Top.Visible = false;

            Hided = true;

           



        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

           
        

        private void btn_continentes_Click(object sender, EventArgs e)
        {
           
           

            if (MenuStrip.Visible == true)
            {
               
                MenuStrip.Visible = false;
                MenuStrip.SendToBack();
                
               
            }
          else
            {
               
                MenuStrip.Visible = true;
                MenuStrip.BringToFront();

            }

            
       


          
          
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void glaciarPeritoMorenoArgentinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paises = "Glaciar";
            panel_bottom.Width = picboxBottom0.Width;
            panel_bottom.Left = picboxBottom0.Left;
            panel_bottom.Visible = true;

            picboxBottom0.BringToFront();
            picboxBottom3.BringToFront();

            //imagem Central
            string FilePath = pasta_imagens + @"Glaciar.jpg";
            picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxCentral.Image = Image.FromFile(FilePath);

            //primeira imagem de baixo
            string FilePath0 = pasta_imagens + @"Glaciar.jpg";
            picboxBottom0.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom0.Image = Image.FromFile(FilePath0);

            //Segunda imagem de baixo
            string FilePath1 = pasta_imagens + @"Glaciar2.jpg";
            picboxBottom1.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom1.Image = Image.FromFile(FilePath1);

            //Terceira imagem de baixo
            string FilePath2 = pasta_imagens + @"Glaciar3.jpg";
            picboxBottom2.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom2.Image = Image.FromFile(FilePath2);

            //Quarta imagem de baixo
            string FilePath4 = pasta_imagens + @"Glaciar4.jpg";
            picboxBottom3.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom3.Image = Image.FromFile(FilePath4);
        }

        private void picboxBottom1_Click(object sender, EventArgs e)
        {
            panel_bottom.Width = picboxBottom1.Width;
            panel_bottom.Left = picboxBottom1.Left;

            switch (Paises)
            {
                case "Egito":
                    string FilePath_E = pasta_imagens + "Egito 2.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath_E);
                    break;

                case "Maldivas":
                    string FilePath_M = pasta_imagens + "Maldivas2.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath_M);
                    break;

                case "Glaciar":

                    string FilePath1 = pasta_imagens + "Glaciar2.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath1);
                    break;

                case "Jeri":

                    string FilePath2 = pasta_imagens + "Jeri2.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath2);
                    break;

                case "Machu":

                    string FilePath3 = pasta_imagens + "Machu.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath3);
                    break;

                case "Salar":

                    string FilePath4 = pasta_imagens + "Salar.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath4);
                    break;

                case "Cataratas":
                    string FilePath5 = pasta_imagens + "Iguaçu.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath5);
                    break;

                case "Pascoa":
                    string FilePath6 = pasta_imagens + "Pascoa.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath6);
                    break;

                case "Lençoes":
                    string FilePath7 = pasta_imagens + "Lenço2.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath7);
                    break;

                case "Orlando":
                    string FilePath8 = pasta_imagens + "Orlando.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath8);
                    break;

                case "Toronto":
                    string FilePath9 = pasta_imagens + "Toronto.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath9);
                    break;

                case "Whistler":
                    string FilePath10 = pasta_imagens + "black.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath10);
                    break;

                case "Carrick":
                    string FilePath11 = pasta_imagens + "Carrick.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath11);
                    break;

                case "Menorca":
                    string FilePath12 = pasta_imagens + "Menorca2.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath12);
                    break;

                case "Coliseu":
                    string FilePath13 = pasta_imagens + "Coliseu.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath13);
                    break;

                case "Trolltunga":
                    string FilePath14 = pasta_imagens + "Trolltunga2.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath14);
                    break;

                case "Noruega":
                    string FilePath15 = pasta_imagens + "Noruega.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath15);
                    break;

                case "Vaadhoo":
                    string FilePath16 = pasta_imagens + "Vaadhoo.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath16);
                    break;

                case "Phuket":
                    string FilePath17 = pasta_imagens + "Phuket.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath17);
                    break;

                case "SiemReap":

                    string FilePath18 = pasta_imagens + "Siem2.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath18);
                    break;



            }
        }

        private void picboxBottom0_Click(object sender, EventArgs e)
        {
            panel_bottom.Width = picboxBottom0.Width;
            panel_bottom.Left = picboxBottom0.Left;

            switch (Paises)
            {
                case "Maldivas":
                    string FilePath_M = pasta_imagens + "Maldivas.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath_M);
                    break;

                case "Glaciar":
                    string FilePath = pasta_imagens + "Glaciar.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath);
                    break;

                case "Jeri":
                    string FilePath2 = pasta_imagens + "Jeri.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath2);
                    break;

                case "Lençoes":
                    string FilePath3 = pasta_imagens + "Lenço.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath3);
                    break;

                case "Menorca":
                    string FilePath4 = pasta_imagens + "Menorca.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath4);
                    break;

                case "Trolltunga":
                    string FilePath5 = pasta_imagens + "Trolltunga.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath5);
                    break;

                case "SiemReap":

                    string FilePath6 = pasta_imagens + "Siem.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath6);
                    break;



            }

        }

        private void picboxBottom2_Click(object sender, EventArgs e)
        {
            panel_bottom.Width = picboxBottom2.Width;
            panel_bottom.Left = picboxBottom2.Left;

            switch (Paises)
            {
                case "Egito":
                    string FilePath_E = pasta_imagens + "Egito.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath_E);
                    break;

                case "Maldivas":
                    string FilePath_M = pasta_imagens + "Maldivas3.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath_M);
                    break;

                case "Glaciar":
                 
                    string FilePath = pasta_imagens + "Glaciar3.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath);
                    break;

                case "Jeri":
                    
                    string FilePath2 = pasta_imagens + "Jeri3.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath2);
                    break;

                case "Machu":
           
                    string FilePath3 = pasta_imagens + "Machu2.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath3);
                    break;

                case "Salar":
                   
                    string FilePath4 = pasta_imagens + "Salar2.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath4);
                    break;

                case "Cataratas":
                    

                    string FilePath5 = pasta_imagens + "Iguaçu2.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath5);
                    break;

                case "Pascoa":
                   

                    string FilePath6 = pasta_imagens + "Pascoa2.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath6);
                    break;

                case "Lençoes":
                    string FilePath7 = pasta_imagens + "Lenço3.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath7);
                    break;

                case "Orlando":
                    string FilePath8 = pasta_imagens + "Orlando2.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath8);
                    break;

                case "Toronto":
                    string FilePath9 = pasta_imagens + "Toronto2.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath9);
                    break;

                case "Whistler":
                    string FilePath10 = pasta_imagens + "black2.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath10);
                    break;

                case "Carrick":
                    string FilePath11 = pasta_imagens + "Carrick2.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath11);
                    break;

                case "Menorca":
                    string FilePath12 = pasta_imagens + "Menorca3.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath12);
                    break;

                case "Coliseu":
                    string FilePath13 = pasta_imagens + "Coliseu2.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath13);
                    break;

                case "Trolltunga":
                    string FilePath14 = pasta_imagens + "Trolltunga3.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath14);
                    break;
                case "Noruega":
                    string FilePath15 = pasta_imagens + "Noruega2.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath15);
                    break;

                case "Vaadhoo":
                    string FilePath16 = pasta_imagens + "Vaadhoo2.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath16);
                    break;

                case "Phuket":
                    string FilePath17 = pasta_imagens + "Phuket2.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath17);
                    break;

                case "SiemReap":

                    string FilePath18 = pasta_imagens + "Siem3.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath18);
                    break;



            }
        }

        private void picboxBottom3_Click(object sender, EventArgs e)
        {
            panel_bottom.Width = picboxBottom3.Width;
            panel_bottom.Left = picboxBottom3.Left;


            switch (Paises)
            {
                case "Maldivas":
                    string FilePath_M = pasta_imagens + "Maldivas4.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath_M);
                    break;

                case "Glaciar":

                    string FilePath = pasta_imagens + "Glaciar4.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath);
                    break;

                case "Jeri":
                    string FilePath2 = pasta_imagens + "Jeri4.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath2);
                    break;

                case "Machu":
                    string FilePath3 = pasta_imagens + "Machu2.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath3);
                    break;

                case "Lençoes":
                    string FilePath4 = pasta_imagens + "Lenço4.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath4);
                    break;

                case "Menorca":
                    string FilePath5 = pasta_imagens + "Menorca4.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath5);
                    break;

                case "Trolltunga":
                    string FilePath6 = pasta_imagens + "Trolltunga4.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath6);
                    break;

                case "SiemReap":

                    string FilePath7 = pasta_imagens + "Siem4.jpg";
                    picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
                    picboxCentral.Image = Image.FromFile(FilePath7);
                    break;

            }
            


        }

        private void jericoacoraBrasilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paises = "Jeri";
            panel_bottom.Width = picboxBottom0.Width;
            panel_bottom.Left = picboxBottom0.Left;


            picboxBottom0.BringToFront();
            picboxBottom3.BringToFront();

            panel_bottom.Visible = true;

            //imagem Central
            string FilePath = pasta_imagens + @"Jeri.jpg";
            picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxCentral.Image = Image.FromFile(FilePath);

            //primeira imagem de baixo
            string FilePath0 = pasta_imagens + "Jeri.jpg";
            picboxBottom0.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom0.Image = Image.FromFile(FilePath0);

            //Segunda imagem de baixo
            string FilePath1 = pasta_imagens + "Jeri2.jpg";
            picboxBottom1.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom1.Image = Image.FromFile(FilePath1);

            //Terceira imagem de baixo
            string FilePath2 = pasta_imagens + "Jeri3.jpg";
            picboxBottom2.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom2.Image = Image.FromFile(FilePath2);

            //Quarta imagem de baixo
            string FilePath4 = pasta_imagens + "Jeri4.jpg";
            picboxBottom3.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom3.Image = Image.FromFile(FilePath4);

        }

        private void panel_bottom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void machuPichuPeruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paises = "Machu";
            panel_bottom.Width = picboxBottom1.Width;
            panel_bottom.Left = picboxBottom1.Left;
            panel_bottom.Visible = true;

            picboxBottom0.SendToBack();
            picboxBottom3.SendToBack();

            //imagem Central
            string FilePath = pasta_imagens + "Machu.jpg";
            picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxCentral.Image = Image.FromFile(FilePath);

            //Segunda imagem de baixo
            string FilePath1 = pasta_imagens + "Machu.jpg";
            picboxBottom1.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom1.Image = Image.FromFile(FilePath1);

            //Terceira imagem de baixo
            string FilePath2 = pasta_imagens + "Machu2.jpg";
            picboxBottom2.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom2.Image = Image.FromFile(FilePath2);
        }

        private void salarDeUyuniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paises = "Salar";
            panel_bottom.Width = picboxBottom1.Width;
            panel_bottom.Left = picboxBottom1.Left;


            panel_bottom.Visible = true;

            picboxBottom0.SendToBack();
            picboxBottom3.SendToBack();

            //imagem Central
            string FilePath = pasta_imagens + "Salar.jpg";
            picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxCentral.Image = Image.FromFile(FilePath);

            //Segunda imagem de baixo
            string FilePath1 = pasta_imagens + "Salar.jpg";
            picboxBottom1.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom1.Image = Image.FromFile(FilePath1);

            //Terceira imagem de baixo
            string FilePath2 = pasta_imagens + "Salar2.jpg";
            picboxBottom2.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom2.Image = Image.FromFile(FilePath2);
        }

        private void cataratasDoIguaçuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paises = "Cataratas";
            panel_bottom.Width = picboxBottom1.Width;
            panel_bottom.Left = picboxBottom1.Left;
            panel_bottom.Visible = true;

            picboxBottom0.SendToBack();
            picboxBottom3.SendToBack();

            //imagem Central
            string FilePath = pasta_imagens + "Iguaçu.jpg";
            picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxCentral.Image = Image.FromFile(FilePath);

            //Segunda imagem de baixo
            string FilePath1 = pasta_imagens + "Iguaçu.jpg";
            picboxBottom1.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom1.Image = Image.FromFile(FilePath1);

            //Terceira imagem de baixo
            string FilePath2 = pasta_imagens + "Iguaçu2.jpg";
            picboxBottom2.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom2.Image = Image.FromFile(FilePath2);
        }

        private void ilhaDaPascoaChileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paises = "Pascoa";
            panel_bottom.Width = picboxBottom1.Width;
            panel_bottom.Left = picboxBottom1.Left;

            panel_bottom.Visible = true;

            picboxBottom0.SendToBack();
            picboxBottom3.SendToBack();

            //imagem Central
            string FilePath = pasta_imagens + "Pascoa.jpg";
            picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxCentral.Image = Image.FromFile(FilePath);

            //Segunda imagem de baixo
            string FilePath1 = pasta_imagens + "Pascoa.jpg";
            picboxBottom1.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom1.Image = Image.FromFile(FilePath1);

            //Terceira imagem de baixo
            string FilePath2 = pasta_imagens + "Pascoa2.jpg";
            picboxBottom2.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom2.Image = Image.FromFile(FilePath2);
        }

        private void lençoesMaranhensesBrasilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paises = "Lençoes";
            panel_bottom.Width = picboxBottom0.Width;
            panel_bottom.Left = picboxBottom0.Left;
            panel_bottom.Visible = true;

            picboxBottom0.BringToFront();
            picboxBottom3.BringToFront();

            //imagem Central
            string FilePath = pasta_imagens + "Lenço.jpg";
            picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxCentral.Image = Image.FromFile(FilePath);

            //primeira imagem de baixo
            string FilePath0 = pasta_imagens + "Lenço.jpg";
            picboxBottom0.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom0.Image = Image.FromFile(FilePath0);

            //Segunda imagem de baixo
            string FilePath1 = pasta_imagens + "Lenço2.jpg";
            picboxBottom1.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom1.Image = Image.FromFile(FilePath1);

            //Terceira imagem de baixo
            string FilePath2 = pasta_imagens + "Lenço3.jpg";
            picboxBottom2.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom2.Image = Image.FromFile(FilePath2);

            //Quarta imagem de baixo
            string FilePath4 = pasta_imagens + "Lenço4.jpg";
            picboxBottom3.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom3.Image = Image.FromFile(FilePath4);
        }

        private void orlandoEUAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paises = "Orlando";
            panel_bottom.Width = picboxBottom1.Width;
            panel_bottom.Left = picboxBottom1.Left;
            panel_bottom.Visible = true;

            picboxBottom0.SendToBack();
            picboxBottom3.SendToBack();

            //imagem Central
            string FilePath = pasta_imagens + "Orlando.jpg";
            picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxCentral.Image = Image.FromFile(FilePath);

            //Segunda imagem de baixo
            string FilePath1 = pasta_imagens + "Orlando.jpg";
            picboxBottom1.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom1.Image = Image.FromFile(FilePath1);

            //Terceira imagem de baixo
            string FilePath2 = pasta_imagens + "Orlando2.jpg";
            picboxBottom2.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom2.Image = Image.FromFile(FilePath2);
        }

        private void torontoCanadáToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Paises = "Toronto";
            panel_bottom.Width = picboxBottom1.Width;
            panel_bottom.Left = picboxBottom1.Left;
            panel_bottom.Visible = true;

            picboxBottom0.SendToBack();
            picboxBottom3.SendToBack();

            //imagem Central
            string FilePath = pasta_imagens + "Toronto.jpg";
            picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxCentral.Image = Image.FromFile(FilePath);

            //Segunda imagem de baixo
            string FilePath1 = pasta_imagens + "Toronto.jpg";
            picboxBottom1.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom1.Image = Image.FromFile(FilePath1);

            //Terceira imagem de baixo
            string FilePath2 = pasta_imagens + "Toronto2.jpg";
            picboxBottom2.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom2.Image = Image.FromFile(FilePath2);
        }

        private void whistlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paises = "Whistler";
            panel_bottom.Width = picboxBottom1.Width;
            panel_bottom.Left = picboxBottom1.Left;
            panel_bottom.Visible = true;

            picboxBottom0.SendToBack();
            picboxBottom3.SendToBack();

            //imagem Central
            string FilePath = pasta_imagens + "black.jpg";
            picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxCentral.Image = Image.FromFile(FilePath);

            //Segunda imagem de baixo
            string FilePath1 = pasta_imagens + "black.jpg";
            picboxBottom1.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom1.Image = Image.FromFile(FilePath1);

            //Terceira imagem de baixo
            string FilePath2 = pasta_imagens + "black2.jpg";
            picboxBottom2.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom2.Image = Image.FromFile(FilePath2);
        }

       

        private void carrickBridgeIrlandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paises = "Carrick";
            panel_bottom.Width = picboxBottom1.Width;
            panel_bottom.Left = picboxBottom1.Left;
            panel_bottom.Visible = true;

            picboxBottom0.SendToBack();
            picboxBottom3.SendToBack();

            //imagem Central
            string FilePath = pasta_imagens + "Carrick.jpg";
            picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxCentral.Image = Image.FromFile(FilePath);

            //Segunda imagem de baixo
            string FilePath1 = pasta_imagens + "Carrick.jpg";
            picboxBottom1.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom1.Image = Image.FromFile(FilePath1);

            //Terceira imagem de baixo
            string FilePath2 = pasta_imagens + "Carrick2.jpg";
            picboxBottom2.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom2.Image = Image.FromFile(FilePath2);
        }

        private void menorcaIlhasBalearesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paises = "Menorca";
            panel_bottom.Width = picboxBottom0.Width;
            panel_bottom.Left = picboxBottom0.Left;
            panel_bottom.Visible = true;

            picboxBottom0.BringToFront();
            picboxBottom3.BringToFront();

            //imagem Central
            string FilePath = pasta_imagens + "Menorca.jpg";
            picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxCentral.Image = Image.FromFile(FilePath);

            //primeira imagem de baixo
            string FilePath0 = pasta_imagens + "Menorca.jpg";
            picboxBottom0.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom0.Image = Image.FromFile(FilePath0);

            //Segunda imagem de baixo
            string FilePath1 = pasta_imagens + "Menorca2.jpg";
            picboxBottom1.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom1.Image = Image.FromFile(FilePath1);

            //Terceira imagem de baixo
            string FilePath2 = pasta_imagens + "Menorca3.jpg";
            picboxBottom2.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom2.Image = Image.FromFile(FilePath2);

            //Quarta imagem de baixo
            string FilePath4 = pasta_imagens + "Menorca4.jpg";
            picboxBottom3.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom3.Image = Image.FromFile(FilePath4);
        }

        private void coliseuDeRomaRomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paises = "Coliseu";
            panel_bottom.Width = picboxBottom1.Width;
            panel_bottom.Left = picboxBottom1.Left;
            panel_bottom.Visible = true;

            picboxBottom0.SendToBack();
            picboxBottom3.SendToBack();

            //imagem Central
            string FilePath = pasta_imagens + "Coliseu.jpg";
            picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxCentral.Image = Image.FromFile(FilePath);

            //Segunda imagem de baixo
            string FilePath1 = pasta_imagens + "Coliseu.jpg";
            picboxBottom1.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom1.Image = Image.FromFile(FilePath1);

            //Terceira imagem de baixo
            string FilePath2 = pasta_imagens + "Coliseu2.jpg";
            picboxBottom2.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom2.Image = Image.FromFile(FilePath2);
        }

        private void trolltungaNoruegaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Paises = "Trolltunga";
            panel_bottom.Width = picboxBottom0.Width;
            panel_bottom.Left = picboxBottom0.Left;
            panel_bottom.Visible = true;

            picboxBottom0.BringToFront();
            picboxBottom3.BringToFront();

            //imagem Central
            string FilePath = pasta_imagens + "Trolltunga.jpg";
            picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxCentral.Image = Image.FromFile(FilePath);

            //primeira imagem de baixo
            string FilePath0 = pasta_imagens + "Trolltunga.jpg";
            picboxBottom0.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom0.Image = Image.FromFile(FilePath0);

            //Segunda imagem de baixo
            string FilePath1 = pasta_imagens + "Trolltunga2.jpg";
            picboxBottom1.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom1.Image = Image.FromFile(FilePath1);

            //Terceira imagem de baixo
            string FilePath2 = pasta_imagens + "Trolltunga3.jpg";
            picboxBottom2.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom2.Image = Image.FromFile(FilePath2);

            //Quarta imagem de baixo
            string FilePath4 = pasta_imagens + "Trolltunga4.jpg";
            picboxBottom3.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom3.Image = Image.FromFile(FilePath4);
        }

        private void noruegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paises = "Noruega";
            panel_bottom.Width = picboxBottom1.Width;
            panel_bottom.Left = picboxBottom1.Left;
            panel_bottom.Visible = true;

            

            picboxBottom0.SendToBack();
            picboxBottom3.SendToBack();

            //imagem Central
            string FilePath = pasta_imagens + "Noruega.jpg";
            picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxCentral.Image = Image.FromFile(FilePath);

            //Segunda imagem de baixo
            string FilePath1 = pasta_imagens + "Noruega.jpg";
            picboxBottom1.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom1.Image = Image.FromFile(FilePath1);

            //Terceira imagem de baixo
            string FilePath2 = pasta_imagens + "Noruega2.jpg";
            picboxBottom2.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom2.Image = Image.FromFile(FilePath2);


        }

        private void ilhaDeVaadhooMaldivasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paises = "Vaadhoo";
            panel_bottom.Width = picboxBottom1.Width;
            panel_bottom.Left = picboxBottom1.Left;
            panel_bottom.Visible = true;



            picboxBottom0.SendToBack();
            picboxBottom3.SendToBack();

            //imagem Central
            string FilePath = pasta_imagens + "Vaadhoo.jpg";
            picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxCentral.Image = Image.FromFile(FilePath);

            //Segunda imagem de baixo
            string FilePath1 = pasta_imagens + "Vaadhoo.jpg";
            picboxBottom1.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom1.Image = Image.FromFile(FilePath1);

            //Terceira imagem de baixo
            string FilePath2 = pasta_imagens + "Vaadhoo2.jpg";
            picboxBottom2.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom2.Image = Image.FromFile(FilePath2);
        }

        private void phuketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paises = "Phuket";
            panel_bottom.Width = picboxBottom1.Width;
            panel_bottom.Left = picboxBottom1.Left;
            panel_bottom.Visible = true;



            picboxBottom0.SendToBack();
            picboxBottom3.SendToBack();

            //imagem Central
            string FilePath = pasta_imagens + "Phuket.jpg";
            picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxCentral.Image = Image.FromFile(FilePath);

            //Segunda imagem de baixo
            string FilePath1 = pasta_imagens + "Phuket.jpg";
            picboxBottom1.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom1.Image = Image.FromFile(FilePath1);

            //Terceira imagem de baixo
            string FilePath2 = pasta_imagens + "Phuket2.jpg";
            picboxBottom2.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom2.Image = Image.FromFile(FilePath2);
        }

        private void siemReapCambojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paises = "SiemReap";
            panel_bottom.Width = picboxBottom0.Width;
            panel_bottom.Left = picboxBottom0.Left;
            panel_bottom.Visible = true;

            picboxBottom0.BringToFront();
            picboxBottom3.BringToFront();

            //imagem Central
            string FilePath = pasta_imagens + "Siem.jpg";
            picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxCentral.Image = Image.FromFile(FilePath);

            //primeira imagem de baixo
            string FilePath0 = pasta_imagens + "Siem.jpg";
            picboxBottom0.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom0.Image = Image.FromFile(FilePath0);

            //Segunda imagem de baixo
            string FilePath1 = pasta_imagens + "Siem2.jpg";
            picboxBottom1.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom1.Image = Image.FromFile(FilePath1);

            //Terceira imagem de baixo
            string FilePath2 = pasta_imagens + "Siem3.jpg";
            picboxBottom2.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom2.Image = Image.FromFile(FilePath2);

            //Quarta imagem de baixo
            string FilePath4 = pasta_imagens + "Siem4.jpg";
            picboxBottom3.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom3.Image = Image.FromFile(FilePath4);
        }

        private void maldivasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paises = "Maldivas";
            panel_bottom.Width = picboxBottom0.Width;
            panel_bottom.Left = picboxBottom0.Left;
            panel_bottom.Visible = true;

            picboxBottom0.BringToFront();
            picboxBottom3.BringToFront();

            //imagem Central
            string FilePath = pasta_imagens + "Maldivas.jpg";
            picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxCentral.Image = Image.FromFile(FilePath);

            //primeira imagem de baixo
            string FilePath0 = pasta_imagens + "Maldivas.jpg";
            picboxBottom0.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom0.Image = Image.FromFile(FilePath0);

            //Segunda imagem de baixo
            string FilePath1 = pasta_imagens + "Maldivas2.jpg";
            picboxBottom1.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom1.Image = Image.FromFile(FilePath1);

            //Terceira imagem de baixo
            string FilePath2 = pasta_imagens + "Maldivas3.jpg";
            picboxBottom2.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom2.Image = Image.FromFile(FilePath2);

            //Quarta imagem de baixo
            string FilePath4 = pasta_imagens + "Maldivas4.jpg";
            picboxBottom3.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom3.Image = Image.FromFile(FilePath4);
        }

        private void nécropoleDeGizéEgitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paises = "Egito";
            panel_bottom.Width = picboxBottom1.Width;
            panel_bottom.Left = picboxBottom1.Left;
            panel_bottom.Visible = true;

            picboxBottom0.SendToBack();
            picboxBottom3.SendToBack();

            //imagem Central
            string FilePath = pasta_imagens + "Egito 2.jpg";
            picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxCentral.Image = Image.FromFile(FilePath);

            //Segunda imagem de baixo
            string FilePath1 = pasta_imagens + "Egito 2.jpg";
            picboxBottom1.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom1.Image = Image.FromFile(FilePath1);

            //Terceira imagem de baixo
            string FilePath2 = pasta_imagens + "Egito.jpg";
            picboxBottom2.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom2.Image = Image.FromFile(FilePath2);
        }

        private void btn_Top_Click(object sender, EventArgs e)
        {
            MenuStrip.Visible = false;
            MnuStrip_Top.Visible = true;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Paises = "Machu";
            panel_bottom.Width = picboxBottom1.Width;
            panel_bottom.Left = picboxBottom1.Left;
            panel_bottom.Visible = true;

            picboxBottom0.SendToBack();
            picboxBottom3.SendToBack();

            //imagem Central
            string FilePath = pasta_imagens + "Machu.jpg";
            picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxCentral.Image = Image.FromFile(FilePath);

            //Segunda imagem de baixo
            string FilePath1 = pasta_imagens + "Machu.jpg";
            picboxBottom1.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom1.Image = Image.FromFile(FilePath1);

            //Terceira imagem de baixo
            string FilePath2 = pasta_imagens + "Machu2.jpg";
            picboxBottom2.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom2.Image = Image.FromFile(FilePath2);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Paises = "Salar";
            panel_bottom.Width = picboxBottom1.Width;
            panel_bottom.Left = picboxBottom1.Left;


            panel_bottom.Visible = true;

            picboxBottom0.SendToBack();
            picboxBottom3.SendToBack();

            //imagem Central
            string FilePath = pasta_imagens + "Salar.jpg";
            picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxCentral.Image = Image.FromFile(FilePath);

            //Segunda imagem de baixo
            string FilePath1 = pasta_imagens + "Salar.jpg";
            picboxBottom1.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom1.Image = Image.FromFile(FilePath1);

            //Terceira imagem de baixo
            string FilePath2 = pasta_imagens + "Salar2.jpg";
            picboxBottom2.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom2.Image = Image.FromFile(FilePath2);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Paises = "Lençoes";
            panel_bottom.Width = picboxBottom0.Width;
            panel_bottom.Left = picboxBottom0.Left;
            panel_bottom.Visible = true;

            picboxBottom0.BringToFront();
            picboxBottom3.BringToFront();

            //imagem Central
            string FilePath = pasta_imagens + "Lenço.jpg";
            picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxCentral.Image = Image.FromFile(FilePath);

            //primeira imagem de baixo
            string FilePath0 = pasta_imagens + "Lenço.jpg";
            picboxBottom0.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom0.Image = Image.FromFile(FilePath0);

            //Segunda imagem de baixo
            string FilePath1 = pasta_imagens + "Lenço2.jpg";
            picboxBottom1.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom1.Image = Image.FromFile(FilePath1);

            //Terceira imagem de baixo
            string FilePath2 = pasta_imagens + "Lenço3.jpg";
            picboxBottom2.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom2.Image = Image.FromFile(FilePath2);

            //Quarta imagem de baixo
            string FilePath4 = pasta_imagens + "Lenço4.jpg";
            picboxBottom3.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom3.Image = Image.FromFile(FilePath4);
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Paises = "Orlando";
            panel_bottom.Width = picboxBottom1.Width;
            panel_bottom.Left = picboxBottom1.Left;
            panel_bottom.Visible = true;

            picboxBottom0.SendToBack();
            picboxBottom3.SendToBack();

            //imagem Central
            string FilePath = pasta_imagens + "Orlando.jpg";
            picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxCentral.Image = Image.FromFile(FilePath);

            //Segunda imagem de baixo
            string FilePath1 = pasta_imagens + "Orlando.jpg";
            picboxBottom1.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom1.Image = Image.FromFile(FilePath1);

            //Terceira imagem de baixo
            string FilePath2 = pasta_imagens + "Orlando2.jpg";
            picboxBottom2.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom2.Image = Image.FromFile(FilePath2);
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            Paises = "Whistler";
            panel_bottom.Width = picboxBottom1.Width;
            panel_bottom.Left = picboxBottom1.Left;
            panel_bottom.Visible = true;

            picboxBottom0.SendToBack();
            picboxBottom3.SendToBack();

            //imagem Central
            string FilePath = pasta_imagens + "black.jpg";
            picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxCentral.Image = Image.FromFile(FilePath);

            //Segunda imagem de baixo
            string FilePath1 = pasta_imagens + "black.jpg";
            picboxBottom1.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom1.Image = Image.FromFile(FilePath1);

            //Terceira imagem de baixo
            string FilePath2 = pasta_imagens + "black2.jpg";
            picboxBottom2.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom2.Image = Image.FromFile(FilePath2);
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            Paises = "Carrick";
            panel_bottom.Width = picboxBottom1.Width;
            panel_bottom.Left = picboxBottom1.Left;
            panel_bottom.Visible = true;

            picboxBottom0.SendToBack();
            picboxBottom3.SendToBack();

            //imagem Central
            string FilePath = pasta_imagens + "Carrick.jpg";
            picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxCentral.Image = Image.FromFile(FilePath);

            //Segunda imagem de baixo
            string FilePath1 = pasta_imagens + "Carrick.jpg";
            picboxBottom1.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom1.Image = Image.FromFile(FilePath1);

            //Terceira imagem de baixo
            string FilePath2 = pasta_imagens + "Carrick2.jpg";
            picboxBottom2.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom2.Image = Image.FromFile(FilePath2);
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            Paises = "Trolltunga";
            panel_bottom.Width = picboxBottom0.Width;
            panel_bottom.Left = picboxBottom0.Left;
            panel_bottom.Visible = true;

            picboxBottom0.BringToFront();
            picboxBottom3.BringToFront();

            //imagem Central
            string FilePath = pasta_imagens + "Trolltunga.jpg";
            picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxCentral.Image = Image.FromFile(FilePath);

            //primeira imagem de baixo
            string FilePath0 = pasta_imagens + "Trolltunga.jpg";
            picboxBottom0.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom0.Image = Image.FromFile(FilePath0);

            //Segunda imagem de baixo
            string FilePath1 = pasta_imagens + "Trolltunga2.jpg";
            picboxBottom1.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom1.Image = Image.FromFile(FilePath1);

            //Terceira imagem de baixo
            string FilePath2 = pasta_imagens + "Trolltunga3.jpg";
            picboxBottom2.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom2.Image = Image.FromFile(FilePath2);

            //Quarta imagem de baixo
            string FilePath4 = pasta_imagens + "Trolltunga4.jpg";
            picboxBottom3.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom3.Image = Image.FromFile(FilePath4);
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            Paises = "Noruega";
            panel_bottom.Width = picboxBottom1.Width;
            panel_bottom.Left = picboxBottom1.Left;
            panel_bottom.Visible = true;



            picboxBottom0.SendToBack();
            picboxBottom3.SendToBack();

            //imagem Central
            string FilePath = pasta_imagens + "Noruega.jpg";
            picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxCentral.Image = Image.FromFile(FilePath);

            //Segunda imagem de baixo
            string FilePath1 = pasta_imagens + "Noruega.jpg";
            picboxBottom1.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom1.Image = Image.FromFile(FilePath1);

            //Terceira imagem de baixo
            string FilePath2 = pasta_imagens + "Noruega2.jpg";
            picboxBottom2.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom2.Image = Image.FromFile(FilePath2);
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            Paises = "Menorca";
            panel_bottom.Width = picboxBottom0.Width;
            panel_bottom.Left = picboxBottom0.Left;
            panel_bottom.Visible = true;

            picboxBottom0.BringToFront();
            picboxBottom3.BringToFront();

            //imagem Central
            string FilePath = pasta_imagens + "Menorca.jpg";
            picboxCentral.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxCentral.Image = Image.FromFile(FilePath);

            //primeira imagem de baixo
            string FilePath0 = pasta_imagens + "Menorca.jpg";
            picboxBottom0.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom0.Image = Image.FromFile(FilePath0);

            //Segunda imagem de baixo
            string FilePath1 = pasta_imagens + "Menorca2.jpg";
            picboxBottom1.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom1.Image = Image.FromFile(FilePath1);

            //Terceira imagem de baixo
            string FilePath2 = pasta_imagens + "Menorca3.jpg";
            picboxBottom2.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom2.Image = Image.FromFile(FilePath2);

            //Quarta imagem de baixo
            string FilePath4 = pasta_imagens + "Menorca4.jpg";
            picboxBottom3.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBottom3.Image = Image.FromFile(FilePath4);
        }
    }

       
    }


