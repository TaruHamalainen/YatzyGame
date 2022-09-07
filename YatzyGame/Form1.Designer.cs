namespace YatzyGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRoll = new System.Windows.Forms.Button();
            this.txtTotalScores = new System.Windows.Forms.TextBox();
            this.dice5 = new System.Windows.Forms.PictureBox();
            this.dice4 = new System.Windows.Forms.PictureBox();
            this.dice3 = new System.Windows.Forms.PictureBox();
            this.dice2 = new System.Windows.Forms.PictureBox();
            this.dice1 = new System.Windows.Forms.PictureBox();
            this.txtOnes = new System.Windows.Forms.TextBox();
            this.btnOnes = new System.Windows.Forms.Button();
            this.txtTwos = new System.Windows.Forms.TextBox();
            this.btnTwos = new System.Windows.Forms.Button();
            this.txtSectionOneScores = new System.Windows.Forms.TextBox();
            this.txtThrees = new System.Windows.Forms.TextBox();
            this.btnThrees = new System.Windows.Forms.Button();
            this.txtFours = new System.Windows.Forms.TextBox();
            this.btnFours = new System.Windows.Forms.Button();
            this.txtFives = new System.Windows.Forms.TextBox();
            this.btnFives = new System.Windows.Forms.Button();
            this.txtSixes = new System.Windows.Forms.TextBox();
            this.btnSixes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBonus1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThreeOfKind = new System.Windows.Forms.TextBox();
            this.btnThreeOfKind = new System.Windows.Forms.Button();
            this.debug = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dice5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(338, 125);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 23);
            this.btnRoll.TabIndex = 5;
            this.btnRoll.Text = "ROLL";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // txtTotalScores
            // 
            this.txtTotalScores.Location = new System.Drawing.Point(668, 418);
            this.txtTotalScores.Name = "txtTotalScores";
            this.txtTotalScores.Size = new System.Drawing.Size(100, 20);
            this.txtTotalScores.TabIndex = 6;
            // 
            // dice5
            // 
            this.dice5.Location = new System.Drawing.Point(469, 42);
            this.dice5.Name = "dice5";
            this.dice5.Size = new System.Drawing.Size(51, 50);
            this.dice5.TabIndex = 4;
            this.dice5.TabStop = false;
            this.dice5.Click += new System.EventHandler(this.Dice5Hold);
            // 
            // dice4
            // 
            this.dice4.Location = new System.Drawing.Point(410, 42);
            this.dice4.Name = "dice4";
            this.dice4.Size = new System.Drawing.Size(53, 50);
            this.dice4.TabIndex = 3;
            this.dice4.TabStop = false;
            this.dice4.Click += new System.EventHandler(this.Dice4Hold);
            // 
            // dice3
            // 
            this.dice3.Location = new System.Drawing.Point(349, 42);
            this.dice3.Name = "dice3";
            this.dice3.Size = new System.Drawing.Size(55, 50);
            this.dice3.TabIndex = 2;
            this.dice3.TabStop = false;
            this.dice3.Click += new System.EventHandler(this.Dice3Hold);
            // 
            // dice2
            // 
            this.dice2.Location = new System.Drawing.Point(287, 42);
            this.dice2.Name = "dice2";
            this.dice2.Size = new System.Drawing.Size(56, 50);
            this.dice2.TabIndex = 1;
            this.dice2.TabStop = false;
            this.dice2.Click += new System.EventHandler(this.Dice2Hold);
            // 
            // dice1
            // 
            this.dice1.Location = new System.Drawing.Point(224, 42);
            this.dice1.Name = "dice1";
            this.dice1.Size = new System.Drawing.Size(57, 50);
            this.dice1.TabIndex = 0;
            this.dice1.TabStop = false;
            this.dice1.Click += new System.EventHandler(this.Dice1Hold);
            // 
            // txtOnes
            // 
            this.txtOnes.Location = new System.Drawing.Point(142, 204);
            this.txtOnes.Name = "txtOnes";
            this.txtOnes.Size = new System.Drawing.Size(100, 20);
            this.txtOnes.TabIndex = 7;
            // 
            // btnOnes
            // 
            this.btnOnes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOnes.Location = new System.Drawing.Point(46, 204);
            this.btnOnes.Name = "btnOnes";
            this.btnOnes.Size = new System.Drawing.Size(75, 23);
            this.btnOnes.TabIndex = 8;
            this.btnOnes.Text = "Ones";
            this.btnOnes.UseVisualStyleBackColor = false;
            this.btnOnes.Click += new System.EventHandler(this.btnOnes_Click);
            // 
            // txtTwos
            // 
            this.txtTwos.Location = new System.Drawing.Point(142, 231);
            this.txtTwos.Name = "txtTwos";
            this.txtTwos.Size = new System.Drawing.Size(100, 20);
            this.txtTwos.TabIndex = 9;
            // 
            // btnTwos
            // 
            this.btnTwos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTwos.Location = new System.Drawing.Point(46, 229);
            this.btnTwos.Name = "btnTwos";
            this.btnTwos.Size = new System.Drawing.Size(75, 23);
            this.btnTwos.TabIndex = 10;
            this.btnTwos.Text = "Twos";
            this.btnTwos.UseVisualStyleBackColor = false;
            this.btnTwos.Click += new System.EventHandler(this.btnTwos_Click);
            // 
            // txtSectionOneScores
            // 
            this.txtSectionOneScores.Location = new System.Drawing.Point(142, 375);
            this.txtSectionOneScores.Name = "txtSectionOneScores";
            this.txtSectionOneScores.Size = new System.Drawing.Size(100, 20);
            this.txtSectionOneScores.TabIndex = 11;
            // 
            // txtThrees
            // 
            this.txtThrees.Location = new System.Drawing.Point(142, 258);
            this.txtThrees.Name = "txtThrees";
            this.txtThrees.Size = new System.Drawing.Size(100, 20);
            this.txtThrees.TabIndex = 12;
            // 
            // btnThrees
            // 
            this.btnThrees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThrees.Location = new System.Drawing.Point(46, 254);
            this.btnThrees.Name = "btnThrees";
            this.btnThrees.Size = new System.Drawing.Size(75, 23);
            this.btnThrees.TabIndex = 13;
            this.btnThrees.Text = "Threes";
            this.btnThrees.UseVisualStyleBackColor = false;
            this.btnThrees.Click += new System.EventHandler(this.btnThrees_Click);
            // 
            // txtFours
            // 
            this.txtFours.Location = new System.Drawing.Point(142, 285);
            this.txtFours.Name = "txtFours";
            this.txtFours.Size = new System.Drawing.Size(100, 20);
            this.txtFours.TabIndex = 14;
            // 
            // btnFours
            // 
            this.btnFours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFours.Location = new System.Drawing.Point(46, 285);
            this.btnFours.Name = "btnFours";
            this.btnFours.Size = new System.Drawing.Size(75, 23);
            this.btnFours.TabIndex = 15;
            this.btnFours.Text = "Fours";
            this.btnFours.UseVisualStyleBackColor = false;
            this.btnFours.Click += new System.EventHandler(this.btnFours_Click);
            // 
            // txtFives
            // 
            this.txtFives.Location = new System.Drawing.Point(142, 311);
            this.txtFives.Name = "txtFives";
            this.txtFives.Size = new System.Drawing.Size(100, 20);
            this.txtFives.TabIndex = 16;
            // 
            // btnFives
            // 
            this.btnFives.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFives.Location = new System.Drawing.Point(46, 315);
            this.btnFives.Name = "btnFives";
            this.btnFives.Size = new System.Drawing.Size(75, 23);
            this.btnFives.TabIndex = 17;
            this.btnFives.Text = "Fives";
            this.btnFives.UseVisualStyleBackColor = false;
            this.btnFives.Click += new System.EventHandler(this.btnFives_Click);
            // 
            // txtSixes
            // 
            this.txtSixes.Location = new System.Drawing.Point(142, 341);
            this.txtSixes.Name = "txtSixes";
            this.txtSixes.Size = new System.Drawing.Size(100, 20);
            this.txtSixes.TabIndex = 18;
            // 
            // btnSixes
            // 
            this.btnSixes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSixes.Location = new System.Drawing.Point(46, 341);
            this.btnSixes.Name = "btnSixes";
            this.btnSixes.Size = new System.Drawing.Size(75, 23);
            this.btnSixes.TabIndex = 19;
            this.btnSixes.Text = "Sixes";
            this.btnSixes.UseVisualStyleBackColor = false;
            this.btnSixes.Click += new System.EventHandler(this.btnSixes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Section Total";
            // 
            // txtBonus1
            // 
            this.txtBonus1.BackColor = System.Drawing.Color.White;
            this.txtBonus1.Location = new System.Drawing.Point(142, 402);
            this.txtBonus1.Name = "txtBonus1";
            this.txtBonus1.Size = new System.Drawing.Size(100, 20);
            this.txtBonus1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Section Bonus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(620, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "TOTAL";
            // 
            // txtThreeOfKind
            // 
            this.txtThreeOfKind.Location = new System.Drawing.Point(517, 204);
            this.txtThreeOfKind.Name = "txtThreeOfKind";
            this.txtThreeOfKind.Size = new System.Drawing.Size(100, 20);
            this.txtThreeOfKind.TabIndex = 24;
            // 
            // btnThreeOfKind
            // 
            this.btnThreeOfKind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThreeOfKind.Location = new System.Drawing.Point(623, 204);
            this.btnThreeOfKind.Name = "btnThreeOfKind";
            this.btnThreeOfKind.Size = new System.Drawing.Size(90, 23);
            this.btnThreeOfKind.TabIndex = 25;
            this.btnThreeOfKind.Text = "Three of kind";
            this.btnThreeOfKind.UseVisualStyleBackColor = false;
            this.btnThreeOfKind.Click += new System.EventHandler(this.btnThreeOfKind_Click);
            // 
            // debug
            // 
            this.debug.Location = new System.Drawing.Point(432, 317);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(100, 20);
            this.debug.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.btnThreeOfKind);
            this.Controls.Add(this.txtThreeOfKind);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBonus1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSixes);
            this.Controls.Add(this.txtSixes);
            this.Controls.Add(this.btnFives);
            this.Controls.Add(this.txtFives);
            this.Controls.Add(this.btnFours);
            this.Controls.Add(this.txtFours);
            this.Controls.Add(this.btnThrees);
            this.Controls.Add(this.txtThrees);
            this.Controls.Add(this.txtSectionOneScores);
            this.Controls.Add(this.btnTwos);
            this.Controls.Add(this.txtTwos);
            this.Controls.Add(this.btnOnes);
            this.Controls.Add(this.txtOnes);
            this.Controls.Add(this.txtTotalScores);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.dice5);
            this.Controls.Add(this.dice4);
            this.Controls.Add(this.dice3);
            this.Controls.Add(this.dice2);
            this.Controls.Add(this.dice1);
            this.Name = "Form1";
            this.Text = "Yatzy";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dice5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dice1;
        private System.Windows.Forms.PictureBox dice2;
        private System.Windows.Forms.PictureBox dice3;
        private System.Windows.Forms.PictureBox dice4;
        private System.Windows.Forms.PictureBox dice5;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.TextBox txtTotalScores;
        private System.Windows.Forms.TextBox txtOnes;
        private System.Windows.Forms.Button btnOnes;
        private System.Windows.Forms.TextBox txtTwos;
        private System.Windows.Forms.Button btnTwos;
        private System.Windows.Forms.TextBox txtSectionOneScores;
        private System.Windows.Forms.TextBox txtThrees;
        private System.Windows.Forms.Button btnThrees;
        private System.Windows.Forms.TextBox txtFours;
        private System.Windows.Forms.Button btnFours;
        private System.Windows.Forms.TextBox txtFives;
        private System.Windows.Forms.Button btnFives;
        private System.Windows.Forms.TextBox txtSixes;
        private System.Windows.Forms.Button btnSixes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBonus1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtThreeOfKind;
        private System.Windows.Forms.Button btnThreeOfKind;
        private System.Windows.Forms.TextBox debug;
    }
}

