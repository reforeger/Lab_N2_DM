﻿
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_N2
{
    public partial class Form1 : Form
    {
        NotifyIcon ico;
        Graphics g;
        TrackBar tr4, tr5;
        Panel panel1;
        PictureBox picboxi, Picb;
        bool drawing;
        int historyCounter;
        public Pen pen;
        List<Image> History;
        Point oldLocation;
        GraphicsPath currentPath1;

        private Size _pictOriginalSize;
        public Color colorResult;

        public Form1()
        {
            InitializeComponent();

            picboxi = new PictureBox();
            //picboxi.Dock = DockStyle.Fill;
            picboxi.Location = new Point(200, 20);
            picboxi.Width = 1700;
            picboxi.Height = 875;
            picboxi.BackColor = Color.White;
            picboxi.BorderStyle = BorderStyle.FixedSingle;

            Bitmap pic = new Bitmap(1980, 1080);

            picboxi.Image = pic;


            History = new List<Image>();



            panel1 = new Panel();
            panel1.Location = new Point(200, 925);
            panel1.Width = 1705;
            panel1.Height = 55;
            panel1.BorderStyle = BorderStyle.FixedSingle;




            pen = new Pen(Color.Black, 1);
            drawing = false;


            tr4 = new TrackBar();
            tr4.Width = 500;
            tr4.Location = new Point(1400, 930);
            tr4.Minimum = 1;
            tr4.Maximum = 1000;

            tr5 = new TrackBar();
            tr5.Width = 500;
            tr5.Location = new Point(210, 930);
            tr5.Minimum = 1;
            tr5.Maximum = 50;
            tr5.Scroll += tr5_Scroll;



            Label lbl = new Label();
            lbl.Location = new Point(1630, 900);
            lbl.Text = "Zoom";
            lbl.ForeColor = Color.Black;














            Controls.Add(tr5);
            Controls.Add(tr4);
            Controls.Add(lbl);
            Controls.Add(panel1);

            



            Icon = new Icon(@"..\..\Properties\test.ico");
            Text = "Cheap Paint";













            //Controls.Add(panel1);
            Controls.Add(picboxi);



            MainMenu menu = new MainMenu();
            MenuItem menuitem1 = new MenuItem("File");


            _pictOriginalSize = picboxi.Size;




            picboxi.MouseDown += picboxi_MouseDown;
            picboxi.MouseMove += picboxi_MouseMove;
            picboxi.MouseUp += picboxi_MouseUp;


            menuitem1.MenuItems.Add("New    Ctrl + N", new EventHandler(menuitem1_New));
            menuitem1.MenuItems.Add("Refresh Ctrl + F5", new EventHandler(menuitem1_Refresh));
            menuitem1.MenuItems.Add("Open   F3", new EventHandler(menuitem1_Open));
            menuitem1.MenuItems.Add("Save    F2", new EventHandler(menuitem1_Save));
            menuitem1.MenuItems.Add("Exit     alt + F4", new EventHandler(menuitem1_Exit));
            MenuItem menuitem2 = new MenuItem("Edit");
            menuitem2.MenuItems.Add("Undo               Ctrl + Z", new EventHandler(menuitem1_Undo));
            menuitem2.MenuItems.Add("Reno   Ctrl + Shift + Z", new EventHandler(menuitem1_Reno));
            MenuItem menuitem5 = new MenuItem("Pen");
            MenuItem menuitem6 = new MenuItem("Style");

            menuitem5.MenuItems.Add("Color", new EventHandler(menuitem1_Pen1));
            menuitem6.MenuItems.Add("Solid", new EventHandler(menuitem1_solid));
            menuitem6.MenuItems.Add("Dot", new EventHandler(menuitem1_Dot));
            menuitem6.MenuItems.Add("Dash Dot Dot", new EventHandler(menuitem1_2Dot));


            menuitem2.MenuItems.Add(menuitem5);
            menuitem5.MenuItems.Add(menuitem6);



            MenuItem menuitem3 = new MenuItem("Help");
            menuitem3.MenuItems.Add("About F1", new EventHandler(menuitem1_About));


            menu.MenuItems.Add(menuitem1);
            menu.MenuItems.Add(menuitem2);
            menu.MenuItems.Add(menuitem3);









            Menu = menu;
            g = picboxi.CreateGraphics();



            ToolStripButton toolStripButton1 = new ToolStripButton();
            toolStripButton1.Image = Bitmap.FromFile(@"..\..\Properties\pilt.jpg");
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            toolStripButton1.ImageAlign = ContentAlignment.MiddleLeft;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Text = "&New";
            toolStripButton1.TextAlign = ContentAlignment.MiddleRight;
            toolStripButton1.Click += new EventHandler(this.toolStripButton1_Click);
            


        }






        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void tr5_Scroll(object sender, EventArgs e)
        {
            pen.Width = tr5.Value;
        }


        private void menuitem1_Refresh(object sender, EventArgs e)
        {

            picboxi.Refresh();
            
        }

        private void picboxi_MouseDown(object sender, MouseEventArgs e)
        {
            if (picboxi.Image == null)
            {
                MessageBox.Show("Save First");
                return;
            }
            if (e.Button == MouseButtons.Left)
            {
                drawing = true;
                oldLocation = e.Location;
                currentPath1 = new GraphicsPath();
            }
        }

        private void picboxi_MouseUp(object sender, MouseEventArgs e)
        {
            /*
            History.RemoveRange(historyCounter + 1, History.Count - historyCounter - 1);
            History.Add(new Bitmap(picboxi.Image));
            if (historyCounter + 1 < 10) historyCounter++;
            if (History.Count - 1 == 10) History.RemoveAt(0);*/
            drawing = false;
            try
            {
                currentPath1.Dispose();
            }
            catch { };
        }

        private void picboxi_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                Graphics g = Graphics.FromImage(picboxi.Image);
                currentPath1.AddLine(oldLocation, e.Location);
                g.DrawPath(pen, currentPath1);
                oldLocation = e.Location;
                g.Dispose();
                picboxi.Invalidate();
                if (e.Button == MouseButtons.Right)
                {
                    currentPath1.Dispose();
                }
            }

        }


        private void menuitem1_2Dot(object sender, EventArgs e)
        {

        }

        private void menuitem1_Dot(object sender, EventArgs e)
        {

        }

        private void menuitem1_solid(object sender, EventArgs e)
        {
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;

            //menuitem1_solid.Checked = true;

        }

        private void menuitem1_Style(object sender, EventArgs e)
        {

        }

        private void menuitem1_Pen1(object sender, EventArgs e)
        {
            Form3 f2 = new Form3();
            f2.ShowDialog();
        }

        private void menuitem1_New(object sender, EventArgs e)
        {
            History.Clear();
            historyCounter = 0;
            Bitmap pic = new Bitmap(750, 500);
            picboxi.Image = pic;
            History.Add(new Bitmap(picboxi.Image));
            Form1 f = new Form1();
            f.ShowDialog();
        }


        private void menuitem1_Reno(object sender, EventArgs e)
        {

        }

        private void menuitem1_Undo(object sender, EventArgs e)
        {

            if (History.Count != 0 && historyCounter != 0)
            {
                picboxi.Image = new Bitmap(History[--historyCounter]);
            }
            else MessageBox.Show("История пуста");
        }

        private void menuitem1_Save(object sender, EventArgs e)
        {

            SaveFileDialog SaveDlg = new SaveFileDialog();
            SaveDlg.Filter = "JPEG Image |*.jpg|Bitmap image|*.bmp|GIF image|*.gif|PNG" +
                "image|*.png";
            SaveDlg.Title = "Save an Image File";
            SaveDlg.FilterIndex = 4;
            SaveDlg.ShowDialog();
            if (SaveDlg.FileName != "")
            {
                System.IO.FileStream fs =
                    (System.IO.FileStream)SaveDlg.OpenFile();
                switch (SaveDlg.FilterIndex)
                {
                    case 1:
                        picboxi.Image.Save(fs, ImageFormat.Jpeg);
                        break;
                    case 2:
                        picboxi.Image.Save(fs, ImageFormat.Bmp);
                        break;
                    case 3:
                        picboxi.Image.Save(fs, ImageFormat.Gif);
                        break;
                    case 4:
                        picboxi.Image.Save(fs, ImageFormat.Png);
                        break;

                }
                fs.Close();

            }
        }

        private void menuitem1_Open(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "JPEG Image |*.jpg|Bitmap image|*.bmp|GIF image|*.gif|PNG" +
                "image|*.png";
            open.Title = "Open an Image File";
            open.FilterIndex = 1;
            if (open.ShowDialog() != DialogResult.Cancel)
            {
                picboxi.Load(open.FileName);
                
            }
            
        }
        


        private void menuitem1_Exit(object sender, EventArgs e)
        {

            if (picboxi.Image != null)
            {
                var result = MessageBox.Show("Save picture pls, -_- before close", "Warning", MessageBoxButtons.YesNoCancel);

                switch (result)
                {
                    case DialogResult.No: Dispose(); break ;
                    case DialogResult.Yes: menuitem1_Save(sender, e); break;
                    case DialogResult.Cancel: return;

                }
            }

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Dispose();
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

        }


        private void menuitem1_About(object sender, EventArgs e)
        {
            MessageBox.Show("Version: 1.22474487139\nProgrammer:Daniel Mihol \nAbout programm: This programm was created by very talented programmer, \nits just a regular paint but with few upgreads, different functions and posabilitys.");
        }
    }
}
    

