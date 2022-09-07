using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YatzyGame
{
    public partial class Form1 : Form
    {
        private List<Dice> dices = new List<Dice>
        {
            new Dice(),
            new Dice(),
            new Dice(),
            new Dice(),
            new Dice()
        };
        private List<PictureBox> pictureBoxes = new List<PictureBox>();
        private int rolls;
        private Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            InitializeGame();

          
        }
        private void InitializeGame()
        {
            pictureBoxes.Add(dice1);
            pictureBoxes.Add(dice2);
            pictureBoxes.Add(dice3);
            pictureBoxes.Add(dice4);
            pictureBoxes.Add(dice5);
        }
        private void SetDiceImage(int value,PictureBox box)
        {
            switch (value)
            {
                case 1:
                    box.Image = Properties.Resources.dice_1;
                    break;
                case 2:
                    box.Image = Properties.Resources.dice_2;
                    break;
                case 3:
                    box.Image = Properties.Resources.dice_3;
                    break;
                case 4:
                    box.Image = Properties.Resources.dice_4;
                    break;
                case 5:
                    box.Image = Properties.Resources.dice_5;
                    break;
                case 6:
                    box.Image = Properties.Resources.dice_6;
                    break;

            }
            box.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void RollDice()
        {
            for(int i = 0; i< dices.Count; i++)
            {
                if (!dices[i].hold)
                {
                    dices[i].value = rand.Next(6) + 1;
                    SetDiceImage(dices[i].value, pictureBoxes[i]);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            RollDice();
        }
    }
}
