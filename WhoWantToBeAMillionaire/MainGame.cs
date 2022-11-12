using System.Media;
using System.Reflection.Metadata.Ecma335;
using DTO;
using NAudio.Codecs;
using NAudio.Wave;
using Repository;
using WMPLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WhoWantToBeAMillionaire
{
    public partial class frmMainGames : Form
    {
        private int noQues = 1;
        private Answer correct;
        private string money = "0";
        private int timePlay = 0;

        private SoundPlayer chooseAns = new SoundPlayer(@"Audio\true (3).wav");
        private WaveFileReader wf = new WaveFileReader(@"Audio\true (3).wav");

        private WindowsMediaPlayer win = new WindowsMediaPlayer();
        private WindowsMediaPlayer begin = new WindowsMediaPlayer();
        private QuesRepository res = new QuesRepository();
        public frmMainGames()
        {
            InitializeComponent();

        }

        private void frmMainGames_Load(object sender, EventArgs e)
        {
            displayQues(noQues);
            countTime.Start();
            pnYKien.Visible = false; //An Y kien phan gia
            begin.URL = @"Audio\Nhac_Hieu_Ai_La_Trieu_Phu.mp3"; //set bgm
        }

        private void displayQues(int x)
        {
            timePlay = 60; //Set time dem nguoc
            begin.controls.play();
            if (noQues >= 16) //Neu cau hoi dat den cau 15 dung -> noQues se tang len 16 -> Win game
            {
	            win.URL = @"Audio\1_Millon_Win_Music_-_You_Just_Won_A_Million_Dollars.mp3";
				begin.controls.stop(); //Tat bgm choi
                win.controls.play(); //Bat bgm nhac win game
				MessageBox.Show("Chúc mừng bạn là triệu phú!");


            }
            else
            {

                Question q = res.GetQuestion("Q" + x);
                lblQuestion.Text = "Câu " + noQues + ". " + q.QuesName;

                List<Answer> answerList = res.GetAnswer("Q" + x);
                correct = answerList.SingleOrDefault(a => a.isCorrect);

                int rd = new Random().Next(1, 5); // Random vi tri cau tra loi

                btnAnswerA.FillColor = Color.MidnightBlue;
                btnAnswerA.ForeColor = Color.White;

                btnAnswerB.FillColor = Color.MidnightBlue;
                btnAnswerB.ForeColor = Color.White;

                btnAnswerC.FillColor = Color.MidnightBlue;
                btnAnswerC.ForeColor = Color.White;

                btnAnswerD.FillColor = Color.MidnightBlue;
                btnAnswerD.ForeColor = Color.White;

                //btnAnswerA.Text.DefaultIfEmpty();
                //btnAnswerB.Text.DefaultIfEmpty();
                //btnAnswerC.Text.DefaultIfEmpty();
                //btnAnswerD.Text.DefaultIfEmpty();


                if (rd == 1)
                {
                    btnAnswerA.Text = "A" + ". " + answerList[0].answerQues;
                    btnAnswerB.Text = "B" + ". " + answerList[1].answerQues;
                    btnAnswerC.Text = "C" + ". " + answerList[2].answerQues;
                    btnAnswerD.Text = "D" + ". " + answerList[3].answerQues;

                }

                if (rd == 2)
                {

                    btnAnswerA.Text = "A" + ". " + answerList[3].answerQues;
                    btnAnswerB.Text = "B" + ". " + answerList[2].answerQues;
                    btnAnswerC.Text = "C" + ". " + answerList[1].answerQues;
                    btnAnswerD.Text = "D" + ". " + answerList[0].answerQues;

                }

                if (rd == 3)
                {

                    btnAnswerA.Text = "A" + ". " + answerList[2].answerQues;
                    btnAnswerB.Text = "B" + ". " + answerList[1].answerQues;
                    btnAnswerC.Text = "C" + ". " + answerList[3].answerQues;
                    btnAnswerD.Text = "D" + ". " + answerList[0].answerQues;

                }

                if (rd == 4)
                {

                    btnAnswerA.Text = "A" + ". " + answerList[3].answerQues;
                    btnAnswerB.Text = "B" + ". " + answerList[0].answerQues;
                    btnAnswerC.Text = "C" + ". " + answerList[1].answerQues;
                    btnAnswerD.Text = "D" + ". " + answerList[2].answerQues;
                }
            }

        }

        private DialogResult displayCorrect(string ans) //Thong bao dap an dung hay sai - Muon tiep tuc choi cau hoi 5, 10, 15
        {

            DialogResult result = DialogResult.Cancel;

            if (correct.answerQues == ans)
            {
                money = IncreaseMoney(noQues);


                if (noQues + 1 == 5 || noQues + 1 == 15 || noQues + 1 == 10) //Check cau hoi tiep theo la 5, 10 hay 15
                {
                    result = MessageBox.Show(
                        $"{money} VND\n" +
                        $"Bạn có muốn tiếp tục chơi không nếu mốc câu hỏi số {noQues+1} mà bạn trả lời sai thì số tiền sẽ về 0 còn trả lời đúng thì số tiền sẽ là",
                        "Notification", MessageBoxButtons.OKCancel);

                    if (result == DialogResult.Cancel) //Neu bam Cancel => thoat app
                    {
                        if (MessageBox.Show($"Đây là tấm séc trị giá {money} VND!\n Cảm ơn bạn đã chơi!",
                                "Notification",
                                MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            Application.Exit();
                        }

                    }
                }


                if (result == DialogResult.OK) //OK thi tiep tuc
                {

                    noQues++;
                    return DialogResult.OK; //tra ve ok de tiep tuc cau hoi moi khi tra loi dung
                }
                else //Khi chua gap moc cau hoi 5, 10, 15
                {
                    DialogResult r = MessageBox.Show(
                        $"{money} VND\n" + "Bạn đã trả lời đúng!!! Bạn có muốn tiếp tục không?", "Notification",
                        MessageBoxButtons.OKCancel);
                    if (r == DialogResult.OK)
                    {
                        noQues++;
                        return DialogResult.OK;
                    }
                    else //Dung choi
                    {
                        if (MessageBox.Show($"Đây là tấm séc trị giá {money} VND!\n Cảm ơn bạn đã chơi!",
                                "Notification",
                                MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            frmStartGame form = new frmStartGame();
                            form.Show();
                            begin.controls.stop();
                            this.Hide();
                        }
                        else
                        {
                            Application.Exit();
                        }
                    }

                }
            }
            else
            {
                if (noQues == 5 || noQues == 10 || noQues == 15)  //Khi sai o nhung moc quan trong la 5,10,15 -> money se la 0
                {
                    money = "0";
                }

                DialogResult r = MessageBox.Show(
                    $"{money} VND\n" +
                    $"Rất tiếc nhưng bạn đã trả lời sai Đáp án đúng là \"{correct.answerQues}\". Bạn có muốn chơi lại không?",
                    "Notification",
                    MessageBoxButtons.OKCancel);

                if (r == DialogResult.OK) //-> Chcoi lai
                {
                    this.Hide();
                    frmStartGame form = new frmStartGame();
                    begin.controls.stop();
                    form.Show();

                }
                else //Thoat
                {
                    Application.Exit();
                }
            }

            return DialogResult.Cancel;
        }


        private void btnAnswerA_Click(object sender, EventArgs e)
        {
            //Color cua btn khi bam se doi
            btnAnswerA.FillColor = Color.CornflowerBlue;
            btnAnswerA.ForeColor = Color.Black;
            //Dung bgm choi
            begin.controls.stop();
            //bgm chon kq 
            chooseAns.Play();
            Thread.Sleep(wf.TotalTime);//Tam dung moi hoat dong trg cung thoi gian nhac chay
            if (displayCorrect(btnAnswerA.Text.Split(". ")[1]) == DialogResult.OK)
            {
                displayQues(noQues);
            }
        }

        private void btnAnswerB_Click(object sender, EventArgs e)
        {
            btnAnswerB.FillColor = Color.CornflowerBlue;
            btnAnswerB.ForeColor = Color.Black;
            begin.controls.stop();
            chooseAns.Play();
            Thread.Sleep(wf.TotalTime);
            if (displayCorrect(btnAnswerB.Text.Split(". ")[1]) == DialogResult.OK)
            {
                displayQues(noQues);
            }
        }

        private void btnAnswerC_Click(object sender, EventArgs e)
        {
            btnAnswerC.FillColor = Color.CornflowerBlue;
            btnAnswerC.ForeColor = Color.Black;
            begin.controls.stop();
            chooseAns.Play();
            Thread.Sleep(wf.TotalTime);
            if (displayCorrect(btnAnswerC.Text.Split(". ")[1]) == DialogResult.OK)
            {
                displayQues(noQues);
            }
        }

        private void btnAnswerD_Click(object sender, EventArgs e)
        {
            btnAnswerD.FillColor = Color.CornflowerBlue;
            btnAnswerD.ForeColor = Color.Black;
            begin.controls.stop();
            chooseAns.Play();
            Thread.Sleep(wf.TotalTime);
            if (displayCorrect(btnAnswerD.Text.Split(". ")[1]) == DialogResult.OK)
            {
                displayQues(noQues);
            }
        }


        private string IncreaseMoney(int x) //Dung de tang so tien va danh dau moc da dung
        {
            switch (x)
            {
                case 1:
                    panel1.BackColor = Color.MediumBlue;
                    return lblValue1.Text;
                case 2:
                    panel2.BackColor = Color.MediumBlue;
                    return lblValue2.Text;
                case 3:
                    panel3.BackColor = Color.MediumBlue;
                    return lblValue3.Text;
                case 4:
                    panel4.BackColor = Color.MediumBlue;
                    return lblValue4.Text;
                case 5:
                    panel5.BackColor = Color.MediumBlue;
                    lblValue5.ForeColor = Color.White;
                    lbl5.ForeColor = Color.White;
                    return lblValue5.Text;
                case 6:
                    panel6.BackColor = Color.MediumBlue;
                    return lblValue6.Text;
                case 7:
                    panel7.BackColor = Color.MediumBlue;
                    return lblValue7.Text;
                case 8:
                    panel8.BackColor = Color.MediumBlue;
                    return lblValue8.Text;
                case 9:
                    panel9.BackColor = Color.MediumBlue;
                    return lblValue9.Text;
                case 10:
                    panel10.BackColor = Color.MediumBlue;
                    lblValue10.ForeColor = Color.White;
                    lbl10.ForeColor = Color.White;
                    return lblValue10.Text;
                case 11:
                    panel11.BackColor = Color.MediumBlue;
                    return lblValue11.Text;
                case 12:
                    panel12.BackColor = Color.MediumBlue;
                    return lblValue12.Text;
                case 13:
                    panel13.BackColor = Color.MediumBlue;
                    return lblValue13.Text;
                case 14:
                    panel14.BackColor = Color.MediumBlue;
                    return lblValue14.Text;
                case 15:
                    panel15.BackColor = Color.MediumBlue;
                    lblValue15.ForeColor = Color.White;
                    lbl15.ForeColor = Color.White;
                    return lblValue15.Text;
            }
            return "0";
        }


        //Quyền trợ giúp

        // 50 : 50
        private void btn5050_Click(object sender, EventArgs e)
        {
            btn5050.Image = null;
            btn5050.FillColor = Color.Red;

            //gan gia tri tam thoi
            string ansA = btnAnswerA.Text;
            string ansB = btnAnswerB.Text;
            string ansC = btnAnswerC.Text;
            string ansD = btnAnswerD.Text;

            // Tao 1 map 
            Dictionary<int, string> answerDic = new Dictionary<int, string>();
            answerDic.Add(1, ansA.Split(". ")[1]);
            answerDic.Add(2, ansB.Split(". ")[1]);
            answerDic.Add(3, ansC.Split(". ")[1]);
            answerDic.Add(4, ansD.Split(". ")[1]);

            int rd; // key de check Xoa cau thu 1
            int rd1; //key Xoa cau thu 2
            do
            {
                rd = new Random().Next(1, 5); 
                rd1 = new Random().Next(1, 5);

            } while (rd == rd1 || answerDic[rd1] == correct.answerQues || answerDic[rd] == correct.answerQues); // Neu rd ma = rd1  or neu trg value dictionary key rd1 == correct answer
                                                                                                                // or dictionary key rd value == correct -> ma true 1 trg 3 => thi se random lai

            //-> neu dap an dung la A thi dap an A se ko loai
            //ma 3 dap an con lai se loai neu dap an do == value dictionary key rd or value dictionary key rd1
            if (ansA.Split(". ")[1] == correct.answerQues)
            {
                if (answerDic[rd] == ansB.Split(". ")[1] || answerDic[rd1] == ansB.Split(". ")[1])
                {
                    btnAnswerB.Click -= btnAnswerB_Click;
                    btnAnswerB.Text = "";
                }

                if (answerDic[rd] == ansC.Split(". ")[1] || answerDic[rd1] == ansC.Split(". ")[1])
                {
                    btnAnswerC.Click -= btnAnswerC_Click;
                    btnAnswerC.Text = "";
                }


                if (answerDic[rd] == ansD.Split(". ")[1] || answerDic[rd1] == ansD.Split(". ")[1])
                {
                    btnAnswerD.Click -= btnAnswerD_Click;
                    btnAnswerD.Text = "";
                }

            }

            if (ansB.Split(". ")[1] == correct.answerQues)
            {
                if (answerDic[rd] == ansC.Split(". ")[1] || answerDic[rd1] == ansC.Split(". ")[1])
                {

                    btnAnswerC.Click -= btnAnswerC_Click;
                    btnAnswerC.Text = "";
                }

                if (answerDic[rd] == ansD.Split(". ")[1] || answerDic[rd1] == ansD.Split(". ")[1])
                {
                    btnAnswerD.Click -= btnAnswerD_Click;
                    btnAnswerD.Text = "";
                }

                if (answerDic[rd] == ansA.Split(". ")[1] || answerDic[rd1] == ansA.Split(". ")[1])
                {
                    btnAnswerA.Click -= btnAnswerA_Click;
                    btnAnswerA.Text = "";
                }
            }

            if (ansC.Split(". ")[1] == correct.answerQues)
            {
                if (answerDic[rd] == ansB.Split(". ")[1] || answerDic[rd1] == ansB.Split(". ")[1])
                {
                    btnAnswerB.Click -= btnAnswerB_Click;
                    btnAnswerB.Text = "";
                }

                if (answerDic[rd] == ansD.Split(". ")[1] || answerDic[rd1] == ansD.Split(". ")[1])
                {
                    btnAnswerD.Click -= btnAnswerD_Click;
                    btnAnswerD.Text = "";
                }

                if (answerDic[rd] == ansA.Split(". ")[1] || answerDic[rd1] == ansA.Split(". ")[1])
                {
                    btnAnswerA.Click -= btnAnswerA_Click;
                    btnAnswerA.Text = "";
                }
            }

            if (ansD.Split(". ")[1] == correct.answerQues)
            {
                if (answerDic[rd] == ansB.Split(". ")[1] || answerDic[rd1] == ansB.Split(". ")[1])
                {
                    btnAnswerB.Click -= btnAnswerB_Click;
                    btnAnswerB.Text = "";
                }

                if (answerDic[rd] == ansC.Split(". ")[1] || answerDic[rd1] == ansC.Split(". ")[1])
                {
                    btnAnswerC.Click -= btnAnswerC_Click;
                    btnAnswerC.Text = "";
                }

                if (answerDic[rd] == ansA.Split(". ")[1] || answerDic[rd1] == ansA.Split(". ")[1])
                {
                    btnAnswerA.Click -= btnAnswerA_Click;
                    btnAnswerA.Text = "";
                }

            }

            //Khoi phuc lai unsubscribe event
            if (rd == 1 || rd1 == 1)
            {
                btnAnswerA.Click += btnAnswerA_Click;
            }

            if (rd == 2 || rd1 == 2)
            {
                btnAnswerB.Click += btnAnswerB_Click;
            }

            if (rd == 3 || rd1 == 3)
            {
                btnAnswerC.Click += btnAnswerC_Click;
            }

            if (rd == 4 || rd1 == 4)
            {
                btnAnswerD.Click += btnAnswerD_Click;
            }

            btn5050.Click -= btn5050_Click;
        }

        //Goi Dien
        private void btnPhone_Click(object sender, EventArgs e)
        {
            btnPhone.Image = null;
            btnPhone.FillColor = Color.Red;
            btnPhone.Click -= btnPhone_Click; //Unsubscribe event de trach bam lai lan nua se thuc hien event click
            begin.controls.stop();
            frmChat form = new frmChat()
            {
                // Truyen cac gia tri qua form chat
                // + cau so may
                // + List cau tra loi cua cau do
                // + Cau hoi
                // + Dap an dung
                no = noQues,
                answers = res.GetAnswer("Q" + noQues),
                question = res.GetQuestion("Q" + noQues).QuesName,
                correctAns = correct.answerQues
            };
            // Sau khi thoat form chat or het thoi gian call thi se cho dialog form do = OK
            // de khien cho bgm choi chay nhac
            if (form.ShowDialog() == DialogResult.OK)
            {
                begin.controls.play();
            }
        }

        //Y kien khan gia trg truong quay
        private void btnYkien_Click(object sender, EventArgs e)
        {
            btnYkien.Image = null;
            btnYkien.FillColor = Color.Red;
            pnYKien.Visible = true;
            btnYkien.Click -= btnYkien_Click;

            int rd = new Random().Next(1, 5);//Random ra ti le co the sai or dung

            switch (rd)
            {
                case 1:
                    pBykienA.Value = 78;
                    lblPercentA.Text = "78%";
                    pBykienB.Value = 4;
                    lblPercentB.Text = "4%";
                    pBykienC.Value = 8;
                    lblPercentC.Text = "8%";
                    pBykienD.Value = 12;
                    lblPercentD.Text = "12%";
                    break;

                case 2:
                    pBykienA.Value = 7;
                    lblPercentA.Text = "7%";
                    pBykienB.Value = 40;
                    lblPercentB.Text = "40%";
                    pBykienC.Value = 8;
                    lblPercentC.Text = "8%";
                    pBykienD.Value = 45;
                    lblPercentD.Text = "45%";
                    break;


                case 3:
                    pBykienA.Value = 4;
                    lblPercentA.Text = "4%";
                    pBykienB.Value = 8;
                    lblPercentB.Text = "8%";
                    pBykienC.Value = 83;
                    lblPercentC.Text = "83%";
                    pBykienD.Value = 7;
                    lblPercentD.Text = "7%";
                    break;

                case 4:
                    pBykienA.Value = 2;
                    lblPercentA.Text = "2%";
                    pBykienB.Value = 90;
                    lblPercentB.Text = "90%";
                    pBykienC.Value = 5;
                    lblPercentC.Text = "5%";
                    pBykienD.Value = 3;
                    lblPercentD.Text = "3%";
                    break;
            }

            //Tu dong ta cai panel  phan tram y kien
            timeKhanGia.Start();
        }


        //Count down thoi gian choi
        private void countTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = timePlay--.ToString();
            if (timePlay < 0)
            {
                lblTime.Text = "0";
            }
            if (timePlay == -1) // Khi ma time < -1 => Hien ra thong bao het gio choi
            {
                DialogResult r = MessageBox.Show($"{money} VND\n" + $"Rất tiếc nhưng bạn đã hết thời gian. Bạn có muốn chơi lại không?", "Notification",
                    MessageBoxButtons.OKCancel);
                if (r == DialogResult.OK)
                {
                    this.Hide();
                    frmStartGame form = new frmStartGame();
                    ;
                    form.Show();

                }
                else
                {
                    Application.Exit();
                }
            }

        }

        //Dung de tu dong tat panel y kien nguoi choi
        private int time = 5;
        private void timeKhanGia_Tick(object sender, EventArgs e)
        {
            time--;

            if (time < 0)
            {
                pnYKien.Visible = false;
                timeKhanGia.Stop();
            }
        }

        // Tat nhac va Thoat game
        private void frmMainGames_FormClosing(object sender, FormClosingEventArgs e)
        {
            begin.controls.stop();
            Application.Exit();
        }
    }
}