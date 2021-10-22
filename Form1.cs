using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SevenSeg
{
    public partial class Form1 : Form
    {
        Button[,] btn1 = new Button[1, 1];//左邊的數字
        Button[,] btn2 = new Button[1, 1];//右邊的數字
        public Form1()
        {
            InitializeComponent();
            inputNum.Enabled = false;
        }
        int width = 0;
        int height = 0;
        int clickTimes = 0;
        private void sure_Click(object sender, EventArgs e)
        {
            try
            { 
                for(int i = 0; i < height; i++)
                {
                    for(int j = 0; j < width; j++)
                    {
                        this.Controls.Remove(btn1[i, j]);//開始之前先把之前的按鈕移除
                        this.Controls.Remove(btn2[i, j]);
                    }
                }
                
                if (Convert.ToInt32(inputHeight.Text) < 7 || Convert.ToInt32(inputHeight.Text) > 15 || Convert.ToInt32(inputWidth.Text) < 5 || Convert.ToInt32(inputWidth.Text) > 10)
                {
                    MessageBox.Show("請輸入範圍內的數字", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    inputHeight.Clear();
                    inputWidth.Clear();
                }
                else
                {
                    if (Convert.ToInt32(inputHeight.Text) % 2 == 0)
                    {
                        MessageBox.Show("高不能為偶數", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        inputHeight.Clear();
                        inputWidth.Clear();
                    }
                    else
                    {
                        width = Convert.ToInt32(inputWidth.Text);
                        height = Convert.ToInt32(inputHeight.Text);
                        inputNum.Enabled = true;
                        btn1 = resize(width, height, btn1);
                        btn2 = resize(width, height, btn2);
                        for (int i = 0; i < height; i++)
                            {
                                for (int j = 0; j < width; j++)
                                {
                                    int sizeY = 300 / height;
                                    int sizeX = 220 / width;
                                    btn1[i, j] = new Button();
                                    btn2[i, j] = new Button();
                                    btn1[i, j].SetBounds(125 + sizeX * j, 25 + sizeY * i, sizeX, sizeY);
                                    btn2[i, j].SetBounds(360 + sizeX * j, 25 + sizeY * i, sizeX, sizeY);
                                    btn1[i, j].BackColor = Color.White;
                                    btn2[i, j].BackColor = Color.White;
                                    Controls.Add(btn1[i, j]);
                                    Controls.Add(btn2[i, j]);
                                }
                            }
                        if (clickTimes != 0)
                        {
                            int num = Convert.ToInt32(inputNum.Text);
                            if (num >=-9 && num <= 99)
                            {
                                if (num < 0)
                                {
                                    int left = 99;//隨便定的
                                    Category(btn1, left);
                                    int complement = 0 - num;
                                    Category(btn2, complement);
                                }
                                else if (num < 10 && num > -1)
                                {
                                    int left = 0;
                                    Category(btn1, left);
                                    int right = num % 10;
                                    Category(btn2, right);
                                }
                                else
                                {
                                    int left = num / 10; ;
                                    Category(btn1, left);
                                    int right = num % 10;
                                    Category(btn2, right);
                                }
                            }
                        }
                        clickTimes++;
                    }
                }
            }
            catch (FormatException ){
                MessageBox.Show("請輸入數字", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inputHeight.Clear();
                inputWidth.Clear();
            }
        }
        Button[,] resize(int col,int row, Button[,] original)//Array.Resize只適用1-dimension，其他維度需要自行寫function
        {
            Button[,] newArray = new Button[row, col];
            return newArray;
        }
        private void inputNum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        btn1[i, j].BackColor = Color.White;//每次textBox讀到新的字串都要先變回白色button
                        btn2[i, j].BackColor = Color.White;
                    }
                }
                int num = Convert.ToInt32(inputNum.Text);
                if (num <= 99 && num > -10)//分成左邊數字跟右邊數字各自判讀
                {
                    if (num < 0)
                    {
                        int left = 99;//隨便定的
                        Category(btn1, left);
                        int complement = 0 - num;
                        Category(btn2, complement);
                    }
                    else if (num < 10 && num > -1)
                    {
                        int left = 0;
                        Category(btn1, left);
                        int right = num % 10;
                        Category(btn2, right);
                    }
                    else
                    {
                        int left = num / 10; ;
                        Category(btn1, left);
                        int right = num % 10;
                        Category(btn2, right);
                    }
                }
                else//超出範圍，button回復白色
                {
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            btn1[i, j].BackColor = Color.White;
                            btn2[i, j].BackColor = Color.White;
                        }
                    }
                }
            }
            catch (FormatException)
            {
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        btn1[i, j].BackColor = Color.White;
                        btn2[i, j].BackColor = Color.White;
                    }
                }
            }
        }
        int[] repre = new int[7] { 0,0,0,0,0,0,0 };//把數字分成七段去做區分
        void Category(Button[,] button,int num)
        {
            for (int i = 0; i < 7; i++) repre[i] = 0;
            switch (num)
            {
                case 0:
                    for (int i = 0; i < 7; i++)
                        if (i != 3) repre[i] = 1;
                    break;
                case 1:
                    repre[2] = 1;repre[5] = 1;
                    break;
                case 2:
                    for (int i = 0; i < 7; i++)
                        if (i != 1&&i!=5) repre[i] = 1;
                    break;
                case 3:
                    for (int i = 0; i < 7; i++)
                        if (i != 1&&i!=4) repre[i] = 1;
                    break;
                case 4:
                    for (int i = 0; i < 7; i++)
                        if (i == 1 || i == 2||i==3||i==5) repre[i] = 1;
                    break;
                case 5:
                    for (int i = 0; i < 7; i++)
                        if (i != 2 && i != 4) repre[i] = 1;
                    break;
                case 6:
                    for (int i = 0; i < 7; i++)
                        if (i != 2 ) repre[i] = 1;
                    break;
                case 7:
                    for (int i = 0; i < 7; i++)
                        if (i == 0 || i == 2||i==5) repre[i] = 1;
                    break;
                case 8:
                    for (int i = 0; i < 7; i++)
                       repre[i] = 1;
                    break;
                case 9:
                    for (int i = 0; i < 7; i++)
                        if ( i != 4) repre[i] = 1;
                    break;
                case 99:
                    repre[3] = 1;
                    break;
            }
            if (repre[0] == 1)//最上面中間橫排
                for (int j = 1; j < width - 1;j++) button[0, j].BackColor = Color.Blue;
            if(repre[1]==1)//左上角直排
                for(int j=1;j<height/2;j++)button[j,0].BackColor = Color.Blue;
            if(repre[2]==1)//右上角直排
                for (int j = 1; j < height / 2; j++) button[j, width-1].BackColor = Color.Blue;
            if (repre[3] == 1)//中間橫排
                for (int j = 1; j < width - 1; j++) button[height/2, j].BackColor = Color.Blue;
            if (repre[4] == 1)//左下角直排
                for (int j = 1; j < height / 2; j++) button[j+height/2, 0].BackColor = Color.Blue;
            if (repre[5] == 1)//右下角橫排
                for (int j = 1; j < height / 2; j++) button[j + height / 2 , width-1].BackColor = Color.Blue;
            if(repre[6] == 1)//最下面中間橫排
                for (int j = 1; j < width - 1; j++) button[height-1, j].BackColor = Color.Blue;
        }
    }
}
