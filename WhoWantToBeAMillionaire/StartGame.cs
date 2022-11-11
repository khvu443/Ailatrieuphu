using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoWantToBeAMillionaire
{
    public partial class frmStartGame : Form
    {
        private SoundPlayer begin = new SoundPlayer(@"Audio\begin.wav"); //Sound khi chay
        public frmStartGame()
        {
            InitializeComponent();
            begin.Play(); // chay bgm
        }

        private void btnStart_Click(object sender, EventArgs e) // Khi bam Start -> hide form hien tai + stop bgm va hien form mainGame
        {
            begin.Stop();
            frmMainGames form = new frmMainGames();
            form.Show();
            this.Hide();
            
        }

        private void btnManual_Click(object sender, EventArgs e) // Mo file txt manual 
        {
            Process p = new Process();
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "NotePad.exe";
            ps.Arguments = "..\\Manual.txt";

            p.StartInfo = ps;
            p.Start();

        }

        private void btnInformation_Click(object sender, EventArgs e) // Mo File txt information
        {
            Process p = new Process();
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "NotePad.exe";
            ps.Arguments = "..\\information.txt";

            p.StartInfo = ps;
            p.Start();
        }

        private void btnQuit_Click(object sender, EventArgs e) // Thoat App
        {
            Application.Exit();
        }

    }
}
