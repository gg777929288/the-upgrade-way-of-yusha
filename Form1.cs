using System;
using System.Collections.Generic;
using System.Media;

namespace 專題_勇者升級之路
{

    public partial class Form1 : Form
    {
        

        private List<string> cardPool = new List<string>
        {

            "再接再厲...","再接再厲...","再接再厲...","再接再厲...","再接再厲...","再接再厲...",
            "普通勇者", "普通勇者", "普通勇者", "普通勇者","普通勇者", // 普通卡牌
            "稀有勇者", "稀有勇者","稀有勇者",// 稀有卡牌
            "傳奇勇者","傳奇勇者",
            "超稀有勇者" // 超稀有卡牌
        };
        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\fdytu\OneDrive\學校\南台科大\一下\程式設計\專題-勇者升級之路\path\to\you-ling-yin-le-life-will-change-shi-chou-qia-shen-qu-zhong-ying-ge-ci-persona-5-nu-shen-yi-wen-lu.wav.crdownload");
            simpleSound.Play();
        }
        private string commonCardSoundPath = @"C:\Users\fdytu\OneDrive\學校\南台科大\一下\程式設計\專題-勇者升級之路\path\to\common_card.wav";
        private string rareCardSoundPath = @"C:\Users\fdytu\OneDrive\學校\南台科大\一下\程式設計\專題-勇者升級之路\path\to\rare_card.wav";
        private string superRareCardSoundPath = @"C:\Users\fdytu\OneDrive\學校\南台科大\一下\程式設計\專題-勇者升級之路\path\to\super_rare_card.wav";
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

        }

        private void btnDrawCard_Click_1(object sender, EventArgs e)
        {
            string drawnCard = DrawCard();
            MessageBox.Show($"你抽到了：{drawnCard}");
        }
        
    }
}
