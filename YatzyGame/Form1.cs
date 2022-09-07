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
        private List<TextBox> textBoxes = new List<TextBox>();
        private int rolls;
        private Random rand = new Random();
        private int sectionOneScores;
        private int sectionTwoScores;
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

            textBoxes.Add(txtOnes);
            textBoxes.Add(txtTwos);
            textBoxes.Add(txtThrees);
            textBoxes.Add(txtFours);
            textBoxes.Add(txtFives);
            textBoxes.Add(txtSixes);
            textBoxes.Add(txtThreeOfKind);
            textBoxes.Add(txtFourOfKind);
            textBoxes.Add(txtFullHouse);
            textBoxes.Add(txtSmallStraight);
            textBoxes.Add(txtLargeStraight);
            textBoxes.Add(txtYatzy);
            textBoxes.Add(txtChance);
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
            rolls = 0;
            txtRolls.Text = rolls.ToString();   
            btnRoll.Enabled = true;
            for (int i = 0; i < dices.Count; i++)
            {
                dices[i] = new Dice();
                pictureBoxes[i].Image = null;
            }
        }
        private void CheckGameOver()
        {
            bool over = false;

            foreach(var box in textBoxes)
            {
                if (!box.Text.Equals(string.Empty))
                    over = true;
                else
                {
                    over = false;
                }

            }
            if (over)
            {
                // TODO; game over
                ShowMessage("Over");
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



            if (rolls < 3)
            {
                RollDice();
                rolls++;
            }
               
            else
            {
                btnRoll.Enabled = false;
                ShowMessage("Insert values");
            }
            
            txtRolls.Text = rolls.ToString();


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

            CheckGameOver();
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
           
            CheckGameOver();

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
         
            CheckGameOver();

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
         
            CheckGameOver();

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
        
            CheckGameOver();

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
       
            CheckGameOver();

            ResetGame();
        }

        private void btnThreeOfKind_Click(object sender, EventArgs e)
        {
            int scores = 0;
            bool threeOfKind = false;
           
            // array of dices to sort
            Dice[] sortedDices = new Dice[dices.Count];
            // list of matched dices
            List<Dice> matchedDices = new List<Dice>();

                // add dices to sorted dices array
                for (int i = 0; i < dices.Count; i++)
                {
                    sortedDices[i] = dices[i];
                }
                // sort array
                Array.Sort(sortedDices);

                // check first three dices for match, add values to scores
                if (sortedDices[0].value == sortedDices[1].value &&
                    sortedDices[1].value == sortedDices[2].value)
                {
                    matchedDices.Add(sortedDices[0]);
                    matchedDices.Add(sortedDices[1]);
                    matchedDices.Add(sortedDices[2]);
                    threeOfKind = true;

                    foreach (var dice in matchedDices)
                    {
                        scores += dice.value;
                    }

                }
                // check last dices for match,add values to score
                if (sortedDices[2].value == sortedDices[3].value &&
                    sortedDices[3].value == sortedDices[4].value)
                {
                    matchedDices.Add(sortedDices[2]);
                    matchedDices.Add(sortedDices[3]);
                    matchedDices.Add(sortedDices[4]);
                    threeOfKind = true;

                    foreach (var dice in matchedDices)
                    {
                        scores += dice.value;
                    }
                }
            // set scores to text box if not already inserted
            if(txtThreeOfKind.Text.Equals(string.Empty))
                txtThreeOfKind.Text = scores.ToString();    
           
            else
            {
                ShowMessage("Cant add");
                return;
            }
            sectionTwoScores += scores;
            totalScores += scores;
            txtTotalScores.Text = totalScores.ToString();
            txtSection2Total.Text = sectionTwoScores.ToString();
            CheckGameOver();

            ResetGame();
          
            
        }

        private void btnFourOfKind_Click(object sender, EventArgs e)
        {
            int scores = 0;
            bool fourOfKind = false;
            Dice[] sortedDices = new Dice[dices.Count];
            List<Dice> matchedDices = new List<Dice>();

            for(int i = 0; i < dices.Count; i++)
            {
                sortedDices[i] = dices[i];
            }
            Array.Sort(sortedDices);

            if (sortedDices[0].value == sortedDices[1].value&&
                sortedDices[1].value == sortedDices[2].value&&
                sortedDices[2].value == sortedDices[3].value)
            {
                matchedDices.Add(sortedDices[0]);
                matchedDices.Add(sortedDices[1]);
                matchedDices.Add(sortedDices[2]);
                matchedDices.Add(sortedDices[3]);
                fourOfKind = true;

                foreach(var dice in matchedDices)
                {
                    scores += dice.value;
                }
            }
            if (!fourOfKind &&sortedDices[1].value == sortedDices[2].value&&
                sortedDices[2].value == sortedDices[3].value&&
                sortedDices[3].value == sortedDices[4].value)
            {
                matchedDices.Add(sortedDices[1]);
                matchedDices.Add(sortedDices[2]);
                matchedDices.Add(sortedDices[3]);
                matchedDices.Add(sortedDices[4]);
                fourOfKind = true;

                foreach(var dice in matchedDices)
                {
                    scores += dice.value;
                }

            }
            if(txtFourOfKind.Text.Equals(string.Empty))
                txtFourOfKind.Text = scores.ToString();
            else
            {
                ShowMessage("Cant add");
                return;
            }
            totalScores += scores;
            txtTotalScores.Text = totalScores.ToString();
            sectionTwoScores += scores;
            txtSection2Total.Text = sectionTwoScores.ToString();
            CheckGameOver();

            ResetGame();

        }

        private void btnFullHouse_Click(object sender, EventArgs e)
        {
            int scores = 0;
            bool twoSame = false;
            bool threeSame = false;
           
            Dice[] sortedDices = new Dice[dices.Count];
           
            // add dices to array
            for(int i = 0; i < dices.Count; i++)
            {
                sortedDices[i] = dices[i];
            }
            // sort array
            Array.Sort(sortedDices);

            // check if first three is same
            if (sortedDices[0].value == sortedDices[1].value&&
                sortedDices[1].value == sortedDices[2].value ||
                sortedDices[2].value == sortedDices[3].value)
            {
                threeSame = true;
            }
            // check if last two is same
            if (sortedDices[3].value == sortedDices[4].value)
            {
                twoSame = true;
            }
            // full house
            if(threeSame && twoSame)
                scores += 25;
            
            else
                scores = 0;
            if (txtFullHouse.Text.Equals(string.Empty))
                txtFullHouse.Text = scores.ToString();
            else
                ShowMessage("Cant insert");

            totalScores += scores;
            txtTotalScores.Text = totalScores.ToString();
            sectionTwoScores += scores;
            txtSection2Total.Text = sectionTwoScores.ToString();
            CheckGameOver();

            ResetGame();
        }

        private void btnSmallStraight_Click(object sender, EventArgs e)
        {
            // 1,2,3,4,5
            // 15 points
            int scores = 0;
            Dice[] sortedDices = new Dice[dices.Count];
           
            for(int i = 0; i< dices.Count; i++)
            {
                sortedDices[i] = dices[i];
            }
            Array.Sort(sortedDices);
            if (sortedDices[0].value == 1 &&
                sortedDices[1].value == 2 &&
                sortedDices[2].value == 3 &&
                sortedDices[3].value == 4 &&
                sortedDices[4].value == 5)
            {
                scores += 15;
            }
            else
                scores = 0;
            if (txtSmallStraight.Text.Equals(string.Empty))
                txtSmallStraight.Text = scores.ToString();
            else
            {
                ShowMessage("Cant insert");
                return;
            }
            totalScores += scores;
            txtTotalScores.Text = totalScores.ToString();
            sectionTwoScores += scores;
            txtSection2Total.Text = sectionTwoScores.ToString();
            CheckGameOver();

            ResetGame();

            
        }

        private void btnLargeStraight_Click(object sender, EventArgs e)
        {
            // 2,3,4,5,6
            // 20 points
            int scores = 0;
            Dice[] sortedDices = new Dice[dices.Count];
            for(int i = 0; i < dices.Count; i++)
            {
                sortedDices[i] = dices[i];
            }
            Array.Sort(sortedDices);

            if (sortedDices[0].value == 2 &&
                sortedDices[1].value == 3 &&
                sortedDices[2].value == 4 &&
                sortedDices[3].value == 5 &&
                sortedDices[4].value == 6)
            {
                scores += 20;
            }
            else
                scores = 0;
            if (txtLargeStraight.Text.Equals(string.Empty))
                txtLargeStraight.Text = scores.ToString();
            else
            {
                ShowMessage("Cant insert");
                return;
            }
            totalScores += scores;
            txtTotalScores.Text = totalScores.ToString();
            sectionTwoScores += scores;
            txtSection2Total.Text = sectionTwoScores.ToString();
            CheckGameOver();

            ResetGame();
        }

        private void btnYatzy_Click(object sender, EventArgs e)
        {
            int scores = 0;
            Dice[] sortedDices = new Dice[dices.Count];
            for (int i = 0; i < dices.Count; i++)
                sortedDices[i] = dices[i];
            Array.Sort(sortedDices);
            if (sortedDices[0].value == sortedDices[4].value)
                scores += 50;
            else
                scores = 0;
            if (txtYatzy.Text.Equals(string.Empty))
                txtYatzy.Text = scores.ToString();
            else
            {
                ShowMessage("Cant insert");
                return;
            }
            totalScores += scores;
            txtTotalScores.Text = totalScores.ToString();
            sectionTwoScores += scores;
            txtSection2Total.Text = sectionTwoScores.ToString();
            CheckGameOver();

            ResetGame();
               

        }

        private void btnChance_Click(object sender, EventArgs e)
        {
            // count value of dices
            int scores = 0;
            foreach(var dice in dices)
            {
                scores += dice.value;
            }
            if (txtChance.Text.Equals(string.Empty))
                txtChance.Text += scores.ToString();
            totalScores += scores;
            txtTotalScores.Text = totalScores.ToString();
            sectionTwoScores += scores;
            txtSection2Total.Text = sectionTwoScores.ToString();
            CheckGameOver();

            ResetGame();
        }
    }
}
