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
            this.debug = new System.Windows.Forms.TextBox();
            this.dice5 = new System.Windows.Forms.PictureBox();
            this.dice4 = new System.Windows.Forms.PictureBox();
            this.dice3 = new System.Windows.Forms.PictureBox();
            this.dice2 = new System.Windows.Forms.PictureBox();
            this.dice1 = new System.Windows.Forms.PictureBox();
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
            // debug
            // 
            this.debug.Location = new System.Drawing.Point(113, 204);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(100, 20);
            this.debug.TabIndex = 6;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.dice5);
            this.Controls.Add(this.dice4);
            this.Controls.Add(this.dice3);
            this.Controls.Add(this.dice2);
            this.Controls.Add(this.dice1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox debug;
    }
}

