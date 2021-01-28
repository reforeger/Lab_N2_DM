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
        public Color colorResult, historyColor;
        public Pen pen;
        TrackBar tr1, tr2, tr3;
        public Form3()
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


            pen = new Pen(Color.Black, 1);



            Controls.Add(Picb);


            Button btn1 = new Button();
            btn1.Location = new Point(100, 100);
            btn1.Text = "Change pen color";
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
            colorResult = new Color();
            colorResult = Picb.BackColor;
            pen = new Pen(colorResult, 1);
            //historyColor = colorResult;

        }
    }
}
