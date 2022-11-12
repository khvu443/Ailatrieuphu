using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using WMPLib;

namespace WhoWantToBeAMillionaire
{
    public partial class frmChat : Form
    {
        public int no { get; set; }
        public string question { get; set; }
        public List<Answer> answers { get; set; }

        public string correctAns { get; set; }

        private WindowsMediaPlayer bgm = new WindowsMediaPlayer();

        public frmChat()
        {
            InitializeComponent();
        }

        int times = 30; //Set time chat
        private void timeCall_Tick(object sender, EventArgs e)
        {
            times--;// Moi lan tick thi times se giam

            int rd = new Random().Next(0,4); //Random chon dap an
            if (times == 29)
            {
                lblFriendTalk.Text = "- Alo...";

            }

            if (times == 26)
            {
                lblPlayerTalk.Text = "- Là mình đây";

            }

            if (times == 24)
            {
                lblFriendTalk.Text = " - Là cậu à lâu lắm rồi mới gặp";
            }

            if (times == 20)
            {
                lblPlayerTalk.Text =
                    $"- Bây giờ mình đang tham gia ai là triệu phú. Hiện mình đang ở câu hỏi số {no} và cần sự trợ giúp của cậu.";

            }

            if (times == 17)
            {
                lblFriendTalk.Text = "Ok";
            }

            if (times == 14)
            {
                lblPlayerTalk.Text = $"- Câu hỏi là \"{question}\"";
                lblPlayerTalk.Text +=
                    $"\n A.{answers[0].answerQues} \n B.{answers[1].answerQues} \n C.{answers[2].answerQues} \n D.{answers[3].answerQues}";
            }


            if (times == 9)
            {

                lblFriendTalk.Text = $"- Ok. Theo mình đáp án đúng là \"{answers[rd].answerQues}\""; //Dap an co the dung or sai

            }

            if (times == 5)
            {
                lblPlayerTalk.Text =
                    " - Cảm ơn cậu";

            }

            if (times == 3)
            {
                lblFriendTalk.Text = "- OK";
            }

            if (times < 0)
            {
                timeCall.Stop();// dung time
                bgm.controls.stop(); // dung bgm
                DialogResult = DialogResult.OK; //Tra ve dialog result
                this.Close(); //tat form
            }
        }

        private void frmChat_Load(object sender, EventArgs e)
        {
            timeCall.Tick += timeCall_Tick;
            timeCall.Start(); //Start thoi gian chay
            bgm.URL = @"Audio\goidienthoaichonguoiyeu.mp3";
            bgm.controls.play();
        }

        private void frmChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            bgm.controls.stop(); // bgm goi dien stop
            DialogResult = DialogResult.OK; //De tra ve dialog result
        }
    }
}
