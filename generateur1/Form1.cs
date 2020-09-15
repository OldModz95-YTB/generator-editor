using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace generateur1
{
    public partial class Form1 : Form
    {

        WebClient WebClient = new WebClient(); // communiquer avec les generation via le FTP (Filezilla) pour que ca vienne du site web au generateur.

        public Form1()
        {
            InitializeComponent();
            timer1.Start(); // start timer and start color label
        }

        private void logInButton1_Click(object sender, EventArgs e)
        {
            //Téléchargement
            Historique.Text = WebClient.DownloadString(""); //Link to site web generator
            statusBar1.Text = "Generating accounts...";
        }

        private void logInButton2_Click(object sender, EventArgs e)
        {
            if (this.Contacter.SelectedIndex == 0)
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/oldmodz95"); // My channel YTB, sub me ok?!
                statusBar1.Text = "Redirection vers YouTube...";
            }

            if (this.Contacter.SelectedIndex == 1)
            {
                System.Diagnostics.Process.Start("https://discordapp.com/invite/3t2568W"); // My Server Discord
                statusBar1.Text = "Redirection vers Discord...";
            }

            if (this.Contacter.SelectedIndex == 2)
            {
                System.Diagnostics.Process.Start("https://rocketr.net/sellers/OldModz95"); // My Shop
                statusBar1.Text = "Redirection vers le Shop...";
            }

            if (this.Contacter.SelectedIndex == 3)
            {
                System.Diagnostics.Process.Start("https://www.facebook.com/OldModzytb"); // My Facebook
                statusBar1.Text = "Redirection vers Facebook...";
            }

            if (this.Contacter.SelectedIndex == 4)
            {
                MessageBox.Show("Add me Snap: oldmodz95"); // Snap oldmodz95
                statusBar1.Text = "Affichage du Snap...";
            }

            if (this.Contacter.SelectedIndex == 5)
            {
                System.Diagnostics.Process.Start("http://oldmodz953.webnode.fr"); // My Site Web
                statusBar1.Text = "Redirection vers mon site...";
            }

            if (this.Contacter.SelectedIndex == 6)
            {
                System.Diagnostics.Process.Start("https://www.instagram.com/oldmodz95/"); // My Insta
                statusBar1.Text = "Redirection vers Instagram";
            }

            if (this.Contacter.SelectedIndex == 7)
            {
                System.Diagnostics.Process.Start("https://twitter.com/@OldYtb"); // My Twitter
                statusBar1.Text = "Redirection vers Twitter...";
            }

            if (this.Contacter.SelectedIndex == 8)
            {
                MessageBox.Show("PS4: YTB-OldModz95 & PS3: OldModz95--Dev"); // My PSN floflo_du_95-27
                statusBar1.Text = "Affichage de mes PSN...";
            }

            if (this.Contacter.SelectedIndex == 9)
            {
                System.Diagnostics.Process.Start("https://steamcommunity.com/id/OldModz95"); //My Steam (PC)
                statusBar1.Text = "Redirection vers Steam...";
            }

            if (this.Contacter.SelectedIndex == 10)
            {
                System.Diagnostics.Process.Start("https://oldmodz95.store.aptoide.com/"); //My application ANDROID ! Phone
                statusBar1.Text = "Redirection vers Aptoide...";
            }

            if (this.Contacter.SelectedIndex == 11)
            {
                MessageBox.Show("Add me Discord: OldModz95#6215"); // My Discord OldModz95#4202
                statusBar1.Text = "Affichage de mon Discord...";
        }

            if (this.Contacter.SelectedIndex == 12)
            {
                System.Diagnostics.Process.Start("https://oldmodz95-boutique7.webnode.fr"); // Link to site web me (shop)
                statusBar1.Text = "Redirection vers ma Boutique...";
            }
        }

        private void logInLabel3_Click(object sender, EventArgs e)
        {
            //Channel ExoTiQueModz
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCHvV7Nhr8fl3Jv6IniDMMiA?view_as=subscriber"); // channel YTB to ExoTiQueModz ! Sub to channel Exo ^^ OK ?????!!!!
            statusBar1.Text = "Redirection vers YouTube...";
        }

        private void Contacter_SelectedIndexChanged(object sender, EventArgs e)
        {
          // Pas toucher !
        }

        private void logInButton3_Click(object sender, EventArgs e)
        {
            Historique.Text = WebClient.DownloadString(""); // Link to site web and generator^^
            statusBar1.Text = "Generation des comptes...";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // pas toucher car c'etais une image et je les retirer
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // pas toucher car c'etais une image et je les retirer
        }

        private void timer1_Tick(object sender, EventArgs e) // Flash Label auto
        {
            Random labelcolor = new Random(); // effect^^
            int R = labelcolor.Next(0, 255); // color
            int G = labelcolor.Next(0, 255); // color
            int B = labelcolor.Next(0, 255); // color
            int A = labelcolor.Next(0, 255); // color
            open.ForeColor = Color.FromArgb(R, G, B, A); // name label
            OldModz95.ForeColor = Color.FromArgb(R, G, B, A); // name label
        }

        private void label1_Click(object sender, EventArgs e)
        {
            base.Hide();
            new DevDuTool().Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random labelcolor = new Random(); // effect^^
            int R = labelcolor.Next(0, 255); // color
            int B = labelcolor.Next(0, 255); // color
            label1.ForeColor = Color.FromArgb(R, G, B, A); // name label
        }

        public int G { get; set; }

        public int A { get; set; }
    }
}
