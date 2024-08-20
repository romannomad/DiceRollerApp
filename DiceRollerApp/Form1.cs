using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRollerApp
{
    
    public partial class Form1 : Form
    {
        Random dice = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int randomNum1 = dice.Next(1, 7);
            int randomNum2 = dice.Next(1, 7);

            switch (randomNum1)
            {
                case 1:
                    pictureBox1.ImageLocation = @"D:\C# Projects\Windows Forms Projects\9 Dice Roller App\Images\1.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox1.ImageLocation = @"D:\C# Projects\Windows Forms Projects\9 Dice Roller App\Images\2.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox1.ImageLocation = @"D:\C# Projects\Windows Forms Projects\9 Dice Roller App\Images\3.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pictureBox1.ImageLocation = @"D:\C# Projects\Windows Forms Projects\9 Dice Roller App\Images\4.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pictureBox1.ImageLocation = @"D:\C# Projects\Windows Forms Projects\9 Dice Roller App\Images\5.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pictureBox1.ImageLocation = @"D:\C# Projects\Windows Forms Projects\9 Dice Roller App\Images\6.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pictureBox1.ImageLocation = @"D:\C# Projects\Windows Forms Projects\9 Dice Roller App\Images\1.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

            }

            switch (randomNum2)
            {
                case 1:
                    pictureBox2.ImageLocation = @"D:\C# Projects\Windows Forms Projects\9 Dice Roller App\Images\1.png";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox2.ImageLocation = @"D:\C# Projects\Windows Forms Projects\9 Dice Roller App\Images\2.png";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox2.ImageLocation = @"D:\C# Projects\Windows Forms Projects\9 Dice Roller App\Images\3.png";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pictureBox2.ImageLocation = @"D:\C# Projects\Windows Forms Projects\9 Dice Roller App\Images\4.png";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pictureBox2.ImageLocation = @"D:\C# Projects\Windows Forms Projects\9 Dice Roller App\Images\5.png";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pictureBox2.ImageLocation = @"D:\C# Projects\Windows Forms Projects\9 Dice Roller App\Images\6.png";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pictureBox2.ImageLocation = @"D:\C# Projects\Windows Forms Projects\9 Dice Roller App\Images\1.png";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
