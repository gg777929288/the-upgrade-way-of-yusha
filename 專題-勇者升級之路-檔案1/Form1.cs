using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.Media;
using System.Numerics;

namespace 專題_勇者升級之路
{

    public partial class Form1 : Form
    {
        private SoundPlayer backgroundbgm;
        private SoundPlayer cardSound;

        private List<string> cardPool = new List<string>
        {

            "再接再厲...","再接再厲...","再接再厲...","再接再厲...","再接再厲...","再接再厲...",
            "普通勇者", "普通勇者", "普通勇者", "普通勇者","普通勇者", // 普通卡牌
            "稀有勇者", "稀有勇者","稀有勇者",// 稀有卡牌
            "傳奇勇者","傳奇勇者",
            "超稀有勇者" // 超稀有卡牌
        };
        // 抽卡方法
        private string DrawCard()
        {
            Random random = new Random();
            int index = random.Next(cardPool.Count);
            return cardPool[index];
        }
        public Form1()
        {
            InitializeComponent();
            backgroundbgm = new SoundPlayer();
            backgroundbgm.SoundLocation = "music\\background.wav";
            backgroundbgm.PlayLooping();
        }
        private async Task PlaySoundAndWaitAsync(string soundFilePath, int millisecondsToWait)
        {
            using (var soundPlayer = new SoundPlayer(soundFilePath))
            {
                soundPlayer.Play();
                await Task.Delay(millisecondsToWait);
            }
        }

        private async void BtnDrawCard_Click_1(object sender, EventArgs e)
        {
            this.Text = "洗牌中 - 勇者升級之路！";
            BtnDrawCard.Enabled = false;


            pictureBox1.Image = Image.FromFile(@"Images\\whose_that_pokemon.png");
            MessageBox.Show($"確定要抽齁?\n按下確認後請等一下~~\n很快就有新的勇者來陪你了！", "請稍等");
            SoundPlayer cardSound = new SoundPlayer(@"music\background.wav");

            // 如果圖片仍然是預設的，播放音效
            if (pictureBox1.Image == Image.FromFile(@"Images\\whose_that_pokemon.png"))
            {

                InitializeComponent();

                cardSound.SoundLocation = "load.wav";
                cardSound.Play();
            }

            // 等待 3 秒
            await Task.Delay(3000);

            btnDrawCard.Enabled = true;
            string drawnCard = DrawCard();
            if (drawnCard == "再接再厲...")
            {
                pictureBox1.Image = Image.FromFile(@"Images\\再接再厲.png");
                this.Text = "勇者升級之路！";
                SoundPlayer cardSound = new SoundPlayer(@"music\\shi-bai.wav");
                cardSound.SoundLocation = "@music\\shi-bai.wav";
                cardSound.Play();
            }
            if (drawnCard == "普通勇者")
            {
                pictureBox1.Image = Image.FromFile(@"Images\\普通角色.png");
                this.Text = "勇者升級之路！-但你不是我眼中的勇者";
            }
            else if (drawnCard == "稀有勇者")
            {
                pictureBox1.Image = Image.FromFile(@"Images\\稀有勇者.png");
                this.Text = "你抽到的還比稀有寶可夢還稀有！";
            }
            else if (drawnCard == "傳奇勇者")
            {
                pictureBox1.Image = Image.FromFile(@"Images\\傳奇勇者.png");
                this.Text = "你是個傳奇！";

            }
            else if (drawnCard == "超稀有勇者")
            {
                pictureBox1.Image = Image.FromFile(@"Images\\超稀有勇者.png");
                this.Text = "你根本是神吧！";

            }
            MessageBox.Show($"你抽到了：{drawnCard}", "抽卡通知", MessageBoxButtons.OK);


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
