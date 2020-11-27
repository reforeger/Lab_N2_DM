using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_N2
{
    public partial class Form3 : Form
    {
        public PictureBox Picb, Picb2, Picb3, Picb4, Picb5, Picb6, Picb7, Picb8, Picb9, Picb10;
        TextBox textBox1;
        Color colorResult;
        Pen pen;
        TrackBar tr1, tr2, tr3;
        public Form3(string data)
        {
            





            Text = "Colors";
            Icon = new Icon(@"..\..\Properties\test.ico");
            Width =700;
            Height = 700;
            Picb = new PictureBox();
            Picb.Location = new Point(450, 250);
            Picb.BackColor = Color.Black;
            Picb.Size = new Size(150, 150);
            Picb.BorderStyle = BorderStyle.Fixed3D;
           


            Picb2 = new PictureBox();
            Picb2.Location = new Point(80, 75);
            Picb2.Size = new Size(40, 40);
            Picb2.BackColor = Color.Blue;


            Picb3 = new PictureBox();
            Picb3.Location = new Point(180, 75);
            Picb3.Size = new Size(40, 40);
            Picb3.BackColor = Color.Red;


            Picb4 = new PictureBox();
            Picb4.Location = new Point(280, 75);
            Picb4.Size = new Size(40, 40);
            Picb4.BackColor = Color.Yellow;






            Picb5 = new PictureBox();
            Picb5.Location = new Point(80, 160);
            Picb5.Size = new Size(40, 40);
            Picb5.BackColor = Color.Green;


            Picb6 = new PictureBox();
            Picb6.Location = new Point(180, 160);
            Picb6.Size = new Size(40, 40);
            Picb6.BackColor = Color.Violet;


            Picb7 = new PictureBox();
            Picb7.Location = new Point(280, 160);
            Picb7.Size = new Size(40, 40);
            Picb7.BackColor = Color.Orange;





            Picb8 = new PictureBox();
            Picb8.Location = new Point(80, 245);
            Picb8.Size = new Size(40, 40);
            Picb8.BackColor = Color.Cyan;

            Picb9 = new PictureBox();
            Picb9.Location = new Point(180, 245);
            Picb9.Size = new Size(40, 40);
            Picb9.BackColor = Color.Brown;

            Picb10 = new PictureBox();
            Picb10.Location = new Point(280, 245);
            Picb10.Size = new Size(40, 40);
            Picb10.BackColor = Color.DarkKhaki;






            /*Controls.Add(Picb2);
            Controls.Add(Picb3);
            Controls.Add(Picb4);
            Controls.Add(Picb5);
            Controls.Add(Picb6);
            Controls.Add(Picb7);
            Controls.Add(Picb8);
            Controls.Add(Picb9);
            Controls.Add(Picb10);
            */
            Controls.Add(Picb);


            Button btn1 = new Button();
            btn1.Location = new Point(100, 100);
            btn1.Text = "BUTT";
            btn1.Click += btn1_Click;
            Controls.Add(btn1);


            tr1 = new TrackBar();
            tr1.Width = 255;
            tr1.Minimum = 1;
            tr1.Maximum = 255;
            tr1.Location = new Point(100, 220);
            

            tr2 = new TrackBar();
            tr2.Width = 255;
            tr2.Minimum = 1;
            tr2.Maximum = 255;
            tr2.Location = new Point(100, 290);



            tr3 = new TrackBar();
            tr3.Width = 255;
            tr3.Minimum = 1;
            tr3.Maximum = 255;
            tr3.Location = new Point(100, 360);



            tr1.Scroll += tr_Scroll;
            tr2.Scroll += tr2_Scroll;
            tr3.Scroll += tr3_Scroll;





            Controls.Add(tr1);
            Controls.Add(tr2);
            Controls.Add(tr3);

        }

        private void tr_Scroll(object sender, EventArgs e)
        {
            Picb.BackColor = Color.FromArgb(tr1.Value, tr2.Value, tr3.Value);
        }
        private void tr2_Scroll(object sender, EventArgs e)
        {
            Picb.BackColor = Color.FromArgb(tr1.Value, tr2.Value, tr3.Value);
        }
        private void tr3_Scroll(object sender, EventArgs e)
        {
            Picb.BackColor = Color.FromArgb(tr1.Value, tr2.Value, tr3.Value);
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            //Form f5 = new Form();
            
        }
    }
}
