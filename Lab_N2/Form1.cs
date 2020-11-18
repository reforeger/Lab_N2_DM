using Amazon.SimpleWorkflow.Model;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        TrackBar tr1;
        Panel panel1;
        int x = -1;
        int y = -1;
        bool moving = false;
        Pen pen;
        Color historyColor;
        List<Image> History;
        
        public Form1()
        {
            historyColor = new Color();
            History = new List<Image>();

            panel1 = new Panel();
            panel1.Width = 10000;
            panel1.Height = 10000;
            g = panel1.CreateGraphics();
            pen = new Pen(Color.Black, 5);


            

            

            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Fill;
            
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;



            Icon = new Icon(@"..\..\Properties\test.ico");
            Text = "Paint";
            Opacity = .95;
            
            



            tr1 = new TrackBar();
            tr1.Width = 225;
            
            tr1.Dock = DockStyle.Bottom;
            tr1.Minimum = 10;
            tr1.Maximum = 500;
            //tr1.Value += new (tr_ValueChanged);




            
            Controls.Add(tr1);
            Controls.Add(panel1);

            MainMenu menu = new MainMenu();
            MenuItem menuitem1 = new MenuItem("File");







            
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

            //picDrawingSurface.Image = pic;





        }

        private void menuitem1_Refresh(object sender, EventArgs e)
        {
            panel1.Refresh();
        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(moving && x!=-1 && y!= -1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
        }

        private void tr_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void menuitem1_2Dot(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void menuitem1_Dot(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void menuitem1_solid(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void menuitem1_Style(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void menuitem1_Pen1(object sender, EventArgs e)
        {
            Form3 f2 = new Form3();
            f2.ShowDialog();
        }

        private void menuitem1_New(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void CreateKeyShortcut_KeyDown1(object sender, KeyEventArgs e)
        {
            if ((e.Control && e.KeyCode == Keys.Control) || (e.Control && e.KeyCode == Keys.S))
            {
                MessageBox.Show(
                "Выберите один из вариантов",
                "Сообщение",
                MessageBoxButtons.YesNo);
            }
        }

        private void menuitem1_Reno(object sender, EventArgs e)
        {
            
        }

        private void menuitem1_Undo(object sender, EventArgs e)
        {
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
                   // case 
                        
                }
            
            }
        }

        private void menuitem1_Open(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "JPEG Image |*.jpg|Bitmap image|*.bmp|GIF image|*.gif|PNG" +
                "image|*.png";
            open.Title = "Open an Image File";
            open.FilterIndex = 1;
            if (open.ShowDialog() != DialogResult.OK)
            {
                
            }
        }
        private void menuitem1_Exit(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kas oled kindel", "Küsimus", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Dispose();
            }
        }



        private void menuitem1_About(object sender, EventArgs e)
        {

        }





    }
}
    

