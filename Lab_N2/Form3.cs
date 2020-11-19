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
        PictureBox Picb, Picb2, Picb3, Picb4, Picb5, Picb6, Picb7, Picb8, Picb9, Picb10;
        TextBox textBox1;
        Color colorResult;
        public Form3()
        {
            Text = "Colors";
            Icon = new Icon(@"..\..\Properties\test.ico");
            Width = 800;
            Height = 800;
            Picb = new PictureBox();
            Picb.Location = new Point(50, 50);
            Picb.BackColor = Color.DarkGray;
            Picb.Size = new Size(300, 260);
           


            Picb2 = new PictureBox();
            Picb2.Location = new Point(80, 75);
            Picb2.Size = new Size(40, 40);
            Picb2.BackColor = Color.Blue;
            Picb2.MouseClick += Picb2_MouseClick;


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



            textBox1 = new TextBox();
            textBox1.BackColor = Color.Cyan;
            textBox1.Location = new Point(700, 500);
            textBox1.Size = new Size(150, 150);
            Controls.Add(textBox1);


            Controls.Add(Picb2);
            Controls.Add(Picb3);
            Controls.Add(Picb4);
            Controls.Add(Picb5);
            Controls.Add(Picb6);
            Controls.Add(Picb7);
            Controls.Add(Picb8);
            Controls.Add(Picb9);
            Controls.Add(Picb10);
            Controls.Add(textBox1);
            Controls.Add(Picb);


            //Scroll_Red.Tag = numeric_Red;


        }

        /*private void Scroll_Red_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = ScrollBar.Value;
        }
        private void UpdateColor()
        {
            colorResult = Color.FromArgb(Scroll_Red.Value, Scroll_Green.Value,
                Scroll_Blue.Value);
            picResultColor.BackColor = colorResult;
        }*/
        private void Picb2_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
