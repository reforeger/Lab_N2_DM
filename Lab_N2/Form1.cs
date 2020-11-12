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
        Label lbl;
        Graphics g;
        public Form1()
        {
            InitializeComponent();

            Icon = new Icon(@"..\..\Properties\test.ico");
            Text = "Paint";



            lbl = new Label();
            lbl.Text = "Tarkvara";
            lbl.Size = new Size(150, 50);
            lbl.Location = new Point(110, 120);

            MainMenu menu = new MainMenu();
            MenuItem menuitem1 = new MenuItem("File");
            menuitem1.MenuItems.Add("New    Ctrl + N", new EventHandler(menuitem1_New));
            menuitem1.MenuItems.Add("Open   F3", new EventHandler(menuitem1_Open));
            menuitem1.MenuItems.Add("Save    F2", new EventHandler(menuitem1_Save));
            menuitem1.MenuItems.Add("Exit     alt + F4", new EventHandler(menuitem1_Exit));
            MenuItem menuitem2 = new MenuItem("Edit");
            menuitem2.MenuItems.Add("Undo               Ctrl + Z", new EventHandler(menuitem1_Undo));
            menuitem2.MenuItems.Add("Reno   Ctrl + Shift + Z", new EventHandler(menuitem1_Reno));
            menuitem2.MenuItems.Add("Pen", new EventHandler(menuitem1_Pen));
            ToolStripMenuItem menuItem4 = new ToolStripMenuItem("Opera");


            MenuItem menuitem3 = new MenuItem("Help");
            menuitem3.MenuItems.Add("About F1", new EventHandler(menuitem1_About));

            menu.MenuItems.Add(menuitem1);
            menu.MenuItems.Add(menuitem2);
            menu.MenuItems.Add(menuitem3);
            Menu = menu;

            g = CreateGraphics();
            Bitmap pic = new Bitmap(750, 500);
            //picDrawingSurface.Image = pic;





        }

        private void menuitem1_New(object sender, EventArgs e)
        {
            Form f = new Form();
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
        private void menuitem1_Pen(object sender, EventArgs e)
        {
            MessageBox.Show(
            "Выберите один из вариантов",
            "Сообщение",
            MessageBoxButtons.YesNo);
        }

        private void menuitem1_Reno(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void menuitem1_Undo(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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
    

