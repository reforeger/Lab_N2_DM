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
        Button btn;
        Label lbl;
        public Form1()
        {
            InitializeComponent();


            btn = new Button();
            btn.Text = "Vajuta siia";
            btn.Location = new Point(50, 10);
            btn.Height = 50;
            btn.Width = 150;
            btn.Click += Btn_Click;
            Controls.Add(btn);



            lbl = new Label();
            lbl.Text = "Tarkvara";
            lbl.Size = new Size(150, 50);
            lbl.Location = new Point(110, 120);
            
            MainMenu menu = new MainMenu();
            MenuItem menuitem1 = new MenuItem("File");
            menuitem1.MenuItems.Add("New", new EventHandler(menuitem1_New));
            menuitem1.MenuItems.Add("Open", new EventHandler(menuitem1_Open));
            menuitem1.MenuItems.Add("Save", new EventHandler(menuitem1_Save));
            menuitem1.MenuItems.Add("Exit", new EventHandler(menuitem1_Exit));
            MenuItem menuitem2 = new MenuItem("Edit");
            MenuItem menuitem3 = new MenuItem("Help");


            menu.MenuItems.Add(menuitem1);
            menu.MenuItems.Add(menuitem2);
            menu.MenuItems.Add(menuitem3);
            Menu = menu;
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
        private void menuitem1_Exit(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kas oled kindel", "Küsimus", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
         /*   else if (e.Node.Text == "MessageBox")
            {
                MessageBox.Show("MessageBox", "Kõige lihtsam aken");
                var answer = MessageBox.Show("Tahad inpudBoxi näha?", "Aken koos nupudega", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {

                    string text = Interaction.InputBox("Sisesta siia mingi tekst", "InputBox", "Mingi tekst");

                    if (MessageBox.Show("Kas tahad tekst saada Tekskastisse?", "Teksti salvestamine", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        lbl.Text = text;
                        Controls.Add(lbl);
                    }
                    else if (tabControl.SelectedIndex == 2)
                    {
                        page1.BackColor = Color.Red;
                    }
                }

            }*/
        

        private void Box_btn_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Box_lbl_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RadioButton_Changed(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}
    

