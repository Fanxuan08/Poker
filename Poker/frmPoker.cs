using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker
{
    public partial class frmPoker : Form
    {
        PictureBox[] pic = new PictureBox[5];

        public frmPoker()
        {
            InitializeComponent();
            InitializePoker();
        }

        int totalFunds = 1000000; // 初始總資金
        int currentBet = 0; // 當局押注金額

        private Image GetImage(string name)
        {
            return (Image)Properties.Resources.ResourceManager.GetObject(name) as Image;
        }

        private Image GetImage(int number)
        {
            return GetImage($"pic{number}");
        }

        int[] allPoker = new int[52];
        int[] playerPoker = new int[5];

        private void btnDealCard_Click(object sender, EventArgs e)
        {
            // 先將牌面蓋掉
            for (int i = 0; i < 5; i++)
            {
                pic[i].Image = GetImage("back");
            }
            // 初始化52張牌
            for (int i = 0; i < 52; i++)
            {
                allPoker[i] = i;
            }
            // 洗牌
            Shuffle();
            // 發牌
            for (int i = 0; i < 5; i++)
            {
                pic[i].Image = GetImage("pic" + (allPoker[i] + 1));
                playerPoker[i] = allPoker[i];
            }
            for (int i = 0; i < 5; i++)
            {
                pic[i].Enabled = true;
                pic[i].Tag = "front";
            }
            btnChangeCard.Enabled = true;
        }

        private void Shuffle()
        {
            Random rand = new Random();
            for (int i = 0; i < allPoker.Length; i++)
            {
                int r = rand.Next(allPoker.Length);
                int temp = allPoker[r];
                allPoker[r] = allPoker[0];
                allPoker[0] = temp;
            }
        }

        private void InitializePoker()
        {
            // 動態產生5張牌
            for (int i = 0; i < 5; i++)
            {
                pic[i] = new PictureBox();
                pic[i].Image = GetImage("back");
                pic[i].Name = "pic" + i;
                pic[i].SizeMode = PictureBoxSizeMode.AutoSize;
                pic[i].Top = 30;
                pic[i].Left = 10 + ((pic[i].Width + 10) * i);
                pic[i].Visible = true;
                pic[i].Enabled = false;
                pic[i].Tag = "back";
                // 將 pic 丟至到 grpPorker 內
                this.grpPoker.Controls.Add(pic[i]);
                pic[i].MouseClick += new MouseEventHandler(pic_Click);
            }
        }

        private void pic_Click(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            // 取得 pic 的索引值
            int index = int.Parse(pic.Name.Replace("pic", ""));
            // 如果 pic 的 Tag 為 back，則將顯示撲克牌
            if (pic.Tag.ToString() == "back")
            {
                pic.Tag = "front";
                pic.Image = GetImage(playerPoker[index] + 1);
            }
            else
            {
                pic.Tag = "back";
                pic.Image = GetImage("back");
            }
        }

        private void btnChangeCard_Click(object sender, EventArgs e)
        {
            int cardIndex = 5;
            for (int i = 0; i < pic.Length; i++)
            {
                if (pic[i].Tag.ToString() == "back")
                {
                    playerPoker[i] = allPoker[cardIndex];
                 pic[i].Image = GetImage(playerPoker[i] + 1);
                    pic[i].Tag = "front";
                    cardIndex++;
                }
            }
            // 禁用所有牌的點擊事件
            for (int i = 0; i < pic.Length; i++)
            {
                pic[i].Enabled = false;
            }
            btnChangeCard.Enabled = false;
            btnCheck.Enabled = true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string[] colorList = { "梅花", "方塊", "愛心", "黑桃" };
            string[] pointList = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            // 計錄目前五張撲克牌的花色和點數的陣列
            int[] pokerColor = new int[5];
            int[] pokerPoint = new int[5];
            // 將每張牌的顏色和點數分別存入 pokerColor 和 pokerPoint 陣列
            for (int i = 0; i < 5; i++)
            {
                pokerColor[i] = playerPoker[i] % 4;
                pokerPoint[i] = playerPoker[i] / 4;
            }
            // 記錄花色和點數出現次數的陣列
            int[] colorCount = new int[4];
            int[] pointCount = new int[13];
            // 統計 color 和 point 出現次數
            for (int i = 0; i < 5; i++)
            {
                int color = pokerColor[i];
                int point = pokerPoint[i];
                colorCount[color]++;
                pointCount[point]++;
            }
            // 排序 colorCount 和 pointCount 由大到小
            Array.Sort(colorCount, colorList);
            Array.Reverse(colorCount);
            Array.Reverse(colorList);
            Array.Sort(pointCount, pointList);
            Array.Reverse(pointCount);
            Array.Reverse(pointList);

            // 判斷是否為同花
            bool isFlush = (colorCount[0] == 5);
            // 判斷是否為五張單張
            bool isSingle = (pointCount[0] == 1 && pointCount[1] == 1 && pointCount[2] == 1 &&
            pointCount[3] == 1 && pointCount[4] == 1);
            // 判斷是否為差四
            bool isDiffFout = (pokerPoint.Max() - pokerPoint.Min() == 4);
            // 判斷是否為大順
            bool isRoyal = pokerPoint.Contains(0) && pokerPoint.Contains(9) &&
            pokerPoint.Contains(10) && pokerPoint.Contains(11) && pokerPoint.Contains(12);
            // 判斷是否為同花大順
            bool isRoyalisFlush = isFlush && isRoyal;
            // 判斷是否為同花順
            bool isStraightFlush = isFlush && isSingle && isDiffFout;
            // 判斷是否為順子
            bool isStraight = isSingle && (isDiffFout || isRoyal);
            // 判斷是否為鐵支
            bool isFourOfAKind = (pointCount[0] == 4);
            // 判斷是否為葫蘆
            bool isFullHouse = (pointCount[0] == 3 && pointCount[1] == 2);
            // 判斷是否為三條
            bool isThreeOfAKind = (pointCount[0] == 3 && pointCount[1] == 1);
            // 判斷是否為兩對
            bool isTwoPair = (pointCount[0] == 2 && pointCount[1] == 2);
            // 判斷是否為一對
            bool isOnePair = (pointCount[0] == 2 && pointCount[1] == 1);
            string result = "";
            if (isRoyalisFlush)
            {
                result = $"{colorList[0]} 同花大順";
            }
            else if (isStraightFlush)
            {
                result = $"{colorList[0]} 同花順";
            }
            else if (isStraight)
            {
                result = "順子";
            }
            else if (isFourOfAKind)
            {
                result = $"{pointList[0]} 鐵支";
            }
            else if (isFullHouse)
            {
                result = $"{pointList[0]}三張{pointList[1]}兩張 葫蘆";
            }
            else if (isFlush)
            {
                result = $"{colorList[0]} 同花";
            }
            else if (isThreeOfAKind)
            {
                result = $"{pointList[0]} 三條";
            }
            else if (isTwoPair)
            {
                result = $"{pointList[0]},{pointList[1]} 兩對";
            }
            else if (isOnePair)
            {
                result = $"{pointList[0]} 一對";
            }
            else
            {
                result = "雜牌!";
            }
            lblResult.Text = result;
            btnChangeCard.Enabled = false;
            btnCheck.Enabled = false;
            btnDealCard.Enabled = true;

            int payoutOdds = 0;

            if (isRoyalisFlush)
            {
                result = $"{colorList[0]} 皇家同花順";
                payoutOdds = 250;
            }
            else if (isStraightFlush)
            {
                result = $"{colorList[0]} 同花順";
                payoutOdds = 50;
            }
            else if (isFourOfAKind)
            {
                result = $"{pointList[0]}四條"; 
                payoutOdds = 25;
            }
            else if (isFullHouse)
            {
                result = $"{pointList[0]}三張{pointList[1]}兩張葫蘆";
                payoutOdds = 9;
            }
            else if (isFlush)
            {
                result = $"{colorList[0]}同花";
                payoutOdds = 6;
            }
            else if (isStraight)
            {
                result = "順子";
                payoutOdds = 4;
            }
            else if (isThreeOfAKind)
            {
                result = $"{pointList[0]}三條";
                payoutOdds = 3;
            }
            else if (isTwoPair)
            {
                result = $"{pointList[0]},{pointList[1]}兩對";
                payoutOdds = 2;
            }
            else if (isOnePair)
            {
                result = $"{pointList[0]}一對";
                payoutOdds = 1;
            }
            else
            {
                result = "雜牌!";
                payoutOdds = 0;
            }

            // 計算獎金並更新資金
            int winnings = currentBet * payoutOdds;
            totalFunds += winnings;
            txbTotalFunds.Text = totalFunds.ToString(); // 更新 txbTotalFunds

            lblResult.Text = $"{result}！ 贏得 {winnings} 元!!!";

            // 遊戲結束，重置按鈕狀態準備下一局
            btnChangeCard.Enabled = false;
            btnCheck.Enabled = false;
            btnDealCard.Enabled = false;
            btnBet.Enabled = true;       // 重新開放下注
            txbPouring.Enabled = true;   // 重新開放修改押注金額
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            // 檢查押注金額輸入框 (txbPouring) 是否為合法數字
            if (int.TryParse(txbPouring.Text, out currentBet))
            {
                if (currentBet > 0 && currentBet <= totalFunds)
                {
                    totalFunds -= currentBet; // 扣除下注金額
                    txbTotalFunds.Text = totalFunds.ToString(); // 更新 UI 上的總資金

                    // 狀態控制：下注後鎖定下注區，並開放發牌
                    btnBet.Enabled = false;
                    txbPouring.Enabled = false;
                    btnDealCard.Enabled = true;
                }
                else
                {
                    MessageBox.Show("押注金額無效或資金不足！");
                }
            }
            else
            {
                MessageBox.Show("請輸入正確的數字格式！");
            }
        }

        private void btnBet_KeyDown(object sender, KeyEventArgs e)
        {
            // 判斷玩家按下的按鍵是不是 Enter
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 消除系統預設的「叮」警告音
                btnBet.PerformClick();     // 程式自動幫你去「點擊」下注按鈕
            }
        }

        private void grpPoker_Paint(object sender, PaintEventArgs e)
        {
            GroupBox gb = sender as GroupBox;

            // 絕招 1：用 GroupBox 的背景顏色，把原本預設畫出來的邊框全部塗掉
            e.Graphics.Clear(gb.BackColor);

            // 絕招 2：因為上一步連原本的標題文字也塗掉了，所以我們要手動把它畫回來
            // (如果你的 GroupBox 本來就沒有打字，這行可以省略)
            e.Graphics.DrawString(gb.Text, gb.Font, new SolidBrush(gb.ForeColor), 10, 0);
        }
    }
}
