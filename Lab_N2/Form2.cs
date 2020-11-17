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
    public partial class Form2 : Form
    {
        PictureBox Picb;
        public Form2()
        {

            Text = "Colors";
            Icon = new Icon(@"..\..\Properties\test.ico");

            Picb = new PictureBox();
            Picb.Location = new Point(50, 50);
            Picb.BackColor = Color.DarkCyan;
            Picb.Size = new Size(300, 300);

            MainMenu menu = new MainMenu();
            MenuItem menuitem1 = new MenuItem("File");
            menuitem1.MenuItems.Add("New    Ctrl + N", new EventHandler(menuitem1_New));
            menuitem1.MenuItems.Add("Open   F3", new EventHandler(menuitem1_Open));
            menuitem1.MenuItems.Add("Save    F2", new EventHandler(menuitem1_Save));
            menuitem1.MenuItems.Add("Exit     alt + F4", new EventHandler(menuitem1_Exit));

            menu.MenuItems.Add(menuitem1);

            Menu = menu;
        }

        private void menuitem1_Exit(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void menuitem1_Save(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void menuitem1_Open(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void menuitem1_New(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
