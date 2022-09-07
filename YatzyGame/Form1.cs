﻿using System;
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
        private int rolls = 3;
        private Random rand = new Random();
        private int sectionOneScores;
        private int totalScores;
        private int sectionOneBonus = 50;
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
        private void ResetGame()
        {
            for(int i = 0; i < dices.Count; i++)
            {
                dices[i] = new Dice();
                pictureBoxes[i].Image = null;
            }
            
        }
        private void ShowMessage(string message)
        {
              MessageBox.Show(
              message,
              "Warning",
              MessageBoxButtons.OK,
              MessageBoxIcon.Error);
        }
        private void CheckFirstSectionBonus()
        {
            if(sectionOneScores >= 63)
            {
                txtBonus1.Text = sectionOneBonus.ToString();
                totalScores += sectionOneBonus;
                txtBonus1.BackColor = Color.Green;
            }
            txtTotalScores.Text = totalScores.ToString();
        }
        
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            RollDice();
        }

        private void Dice1Hold(object sender, EventArgs e)
        {
            if (!dices[0].hold)
            {
                dices[0].hold = true;

                switch (dices[0].value)
                {
                    case 1:
                        pictureBoxes[0].Image = Properties.Resources.dice_1_red;
                        break;
                    case 2:
                        pictureBoxes[0].Image = Properties.Resources.dice_2_red;
                        break;
                    case 3:
                        pictureBoxes[0].Image = Properties.Resources.dice_3_red;
                        break;
                    case 4:
                        pictureBoxes[0].Image = Properties.Resources.dice_4_red;
                        break;
                    case 5:
                        pictureBoxes[0].Image = Properties.Resources.dice_5_red;
                        break;
                    case 6:
                        pictureBoxes[0].Image = Properties.Resources.dice_6_red;
                        break;

                }
                
            }
            else
            {
                dices[0].hold = false;

                switch (dices[0].value)
                {
                    case 1:
                        pictureBoxes[0].Image = Properties.Resources.dice_1;
                        break;
                    case 2:
                        pictureBoxes[0].Image = Properties.Resources.dice_2;
                        break;
                    case 3:
                        pictureBoxes[0].Image = Properties.Resources.dice_3;
                        break;
                    case 4:
                        pictureBoxes[0].Image = Properties.Resources.dice_4;
                        break;
                    case 5:
                        pictureBoxes[0].Image = Properties.Resources.dice_5;
                        break;
                    case 6:
                        pictureBoxes[0].Image = Properties.Resources.dice_6;
                        break;

                }

            }
        }

        private void Dice2Hold(object sender, EventArgs e)
        {
            if (!dices[1].hold)
            {
                dices[1].hold = true;

                switch (dices[1].value)
                {
                    case 1:
                        pictureBoxes[1].Image = Properties.Resources.dice_1_red;
                        break;
                    case 2:
                        pictureBoxes[1].Image = Properties.Resources.dice_2_red;
                        break;
                    case 3:
                        pictureBoxes[1].Image = Properties.Resources.dice_3_red;
                        break;
                    case 4:
                        pictureBoxes[1].Image = Properties.Resources.dice_4_red;
                        break;
                    case 5:
                        pictureBoxes[1].Image = Properties.Resources.dice_5_red;
                        break;
                    case 6:
                        pictureBoxes[1].Image = Properties.Resources.dice_6_red;
                        break;
                }
            }
            else
            {
                dices[1].hold = false;

                switch (dices[1].value)
                {
                    case 1:
                        pictureBoxes[1].Image = Properties.Resources.dice_1;
                        break;
                    case 2:
                        pictureBoxes[1].Image = Properties.Resources.dice_2;
                        break;
                    case 3:
                        pictureBoxes[1].Image = Properties.Resources.dice_3;
                        break;
                    case 4:
                        pictureBoxes[1].Image = Properties.Resources.dice_4;
                        break;
                    case 5:
                        pictureBoxes[1].Image = Properties.Resources.dice_5;
                        break;
                    case 6:
                        pictureBoxes[1].Image = Properties.Resources.dice_6;
                        break;
                }
            }
        }

        private void Dice3Hold(object sender, EventArgs e)
        {
            if (!dices[2].hold)
            {
                dices[2].hold = true;

                switch (dices[2].value)
                {
                    case 1:
                        pictureBoxes[2].Image = Properties.Resources.dice_1_red;
                        break;
                    case 2:
                        pictureBoxes[2].Image = Properties.Resources.dice_2_red;
                        break;
                    case 3:
                        pictureBoxes[2].Image = Properties.Resources.dice_3_red;
                        break;
                    case 4:
                        pictureBoxes[2].Image = Properties.Resources.dice_4_red;
                        break;
                    case 5:
                        pictureBoxes[2].Image = Properties.Resources.dice_5_red;
                        break;
                    case 6:
                        pictureBoxes[2].Image = Properties.Resources.dice_6_red;
                        break;
                }
            }
            else
            {
                dices[2].hold = false;

                switch (dices[2].value)
                {
                    case 1:
                        pictureBoxes[2].Image = Properties.Resources.dice_1;
                        break;
                    case 2:
                        pictureBoxes[2].Image = Properties.Resources.dice_2;
                        break;
                    case 3:
                        pictureBoxes[2].Image = Properties.Resources.dice_3;
                        break;
                    case 4:
                        pictureBoxes[2].Image = Properties.Resources.dice_4;
                        break;
                    case 5:
                        pictureBoxes[2].Image = Properties.Resources.dice_5;
                        break;
                    case 6:
                        pictureBoxes[2].Image = Properties.Resources.dice_6;
                        break;
                }


            }
        }

        private void Dice4Hold(object sender, EventArgs e)
        {
            if (!dices[3].hold)
            {
                dices[3].hold = true;

                switch (dices[3].value)
                {
                    case 1:
                        pictureBoxes[3].Image = Properties.Resources.dice_1_red;
                        break;
                    case 2:
                        pictureBoxes[3].Image = Properties.Resources.dice_2_red;
                        break;
                    case 3:
                        pictureBoxes[3].Image = Properties.Resources.dice_3_red;
                        break;
                    case 4:
                        pictureBoxes[3].Image = Properties.Resources.dice_4_red;
                        break;
                    case 5:
                        pictureBoxes[3].Image = Properties.Resources.dice_5_red;
                        break;
                    case 6:
                        pictureBoxes[3].Image = Properties.Resources.dice_6_red;
                        break;
                }


            }
            else
            {
                dices[3].hold = false;

                switch (dices[3].value)
                {
                    case 1:
                        pictureBoxes[3].Image = Properties.Resources.dice_1;
                        break;
                    case 2:
                        pictureBoxes[3].Image = Properties.Resources.dice_2;
                        break;
                    case 3:
                        pictureBoxes[3].Image = Properties.Resources.dice_3;
                        break;
                    case 4:
                        pictureBoxes[3].Image = Properties.Resources.dice_4;
                        break;
                    case 5:
                        pictureBoxes[3].Image = Properties.Resources.dice_5;
                        break;
                    case 6:
                        pictureBoxes[3].Image = Properties.Resources.dice_6;
                        break;
                }
            }
        }

        private void Dice5Hold(object sender, EventArgs e)
        {
            if (!dices[4].hold)
            {
                dices[4].hold = true;

                switch (dices[4].value)
                {
                    case 1:
                        pictureBoxes[4].Image = Properties.Resources.dice_1_red;
                        break;
                    case 2:
                        pictureBoxes[4].Image = Properties.Resources.dice_2_red;
                        break;
                    case 3:
                        pictureBoxes[4].Image = Properties.Resources.dice_3_red;
                        break;
                    case 4:
                        pictureBoxes[4].Image = Properties.Resources.dice_4_red;
                        break;
                    case 5:
                        pictureBoxes[4].Image = Properties.Resources.dice_5_red;
                        break;
                    case 6:
                        pictureBoxes[4].Image = Properties.Resources.dice_6_red;
                        break;
                }


            }
            else
            {
                dices[4].hold = false;

                switch (dices[4].value)
                {
                    case 1:
                        pictureBoxes[4].Image = Properties.Resources.dice_1;
                        break;
                    case 2:
                        pictureBoxes[4].Image = Properties.Resources.dice_2;
                        break;
                    case 3:
                        pictureBoxes[4].Image = Properties.Resources.dice_3;
                        break;
                    case 4:
                        pictureBoxes[4].Image = Properties.Resources.dice_4;
                        break;
                    case 5:
                        pictureBoxes[4].Image = Properties.Resources.dice_5;
                        break;
                    case 6:
                        pictureBoxes[4].Image = Properties.Resources.dice_6;
                        break;
                }
            }
        }

        private void btnOnes_Click(object sender, EventArgs e)
        {
            int scores = 0;
            if (txtOnes.Text.Equals(string.Empty))
            {
                foreach (var dice in dices)
                {
                    if (dice.value == 1)
                        scores += dice.value;
                }
                txtOnes.Text = scores.ToString();
            }
            else
            {
                ShowMessage("Value is already inserted");
                return;
            }
            sectionOneScores += scores;
            totalScores += scores;
            txtSectionOneScores.Text = sectionOneScores.ToString();
            CheckFirstSectionBonus();
           
            
            ResetGame();
        }

        private void btnTwos_Click(object sender, EventArgs e)
        {
            int scores = 0;
            if (txtTwos.Text.Equals(string.Empty))
            {
                foreach(var dice in dices)
                {
                    if(dice.value == 2)
                        scores+= dice.value;
                }
                txtTwos.Text = scores.ToString();
            }
            else
            {
                ShowMessage("Value is already inserted");

                return;
            }
            sectionOneScores += scores;
            totalScores += scores;
            txtSectionOneScores.Text = sectionOneScores.ToString();
            CheckFirstSectionBonus();
           
            
            ResetGame();
        }

        private void btnThrees_Click(object sender, EventArgs e)
        {
            int scores = 0;
            if (txtThrees.Text.Equals(string.Empty))
            {
                foreach(var dice in dices)
                {
                    if (dice.value == 3)
                        scores += dice.value;
                }
                txtThrees.Text = scores.ToString();
            }
            else
            {
                ShowMessage("Value is already inserted");

                return;
            }
            sectionOneScores += scores;
            totalScores += scores;
            txtSectionOneScores.Text = sectionOneScores.ToString();
            CheckFirstSectionBonus();
         
          
            ResetGame();
        }

        private void btnFours_Click(object sender, EventArgs e)
        {
            int scores = 0;
            if (txtFours.Text.Equals(string.Empty))
            {
                foreach(var dice in dices)
                {
                    if (dice.value == 4)
                        scores += dice.value;
                }
                txtFours.Text = scores.ToString();
            }
            else
            {
                ShowMessage("Value is already inserted");
                return;
            }
            sectionOneScores += scores;
            totalScores += scores;
            txtSectionOneScores.Text = sectionOneScores.ToString();
            CheckFirstSectionBonus();
         
          
            ResetGame();
        }

        private void btnFives_Click(object sender, EventArgs e)
        {
            int scores = 0;
            if (txtFives.Text.Equals(string.Empty))
            {
                foreach (var dice in dices)
                {
                    if(dice.value == 5)
                        scores+=dice.value;
                }
                txtFives.Text = scores.ToString();
            }
            else
            {
                ShowMessage("Value is already inserted");
                return;
            }
            sectionOneScores += scores;
            totalScores += scores;
            txtSectionOneScores.Text = sectionOneScores.ToString();
            CheckFirstSectionBonus();
        
    
            ResetGame();
        }

        private void btnSixes_Click(object sender, EventArgs e)
        {
            int scores = 0;
            if (txtSixes.Text.Equals(string.Empty))
            {
                foreach(var dice in dices)
                {
                    if(dice.value == 6)
                        scores+= dice.value;
                }
                txtSixes.Text = scores.ToString();
            }
            else
            {
                ShowMessage("Value is already inserted");
                return;
            }
            sectionOneScores += scores;
            totalScores += scores;
            txtSectionOneScores.Text = sectionOneScores.ToString();
            CheckFirstSectionBonus();
       
         
            ResetGame();
        }
    }
}
