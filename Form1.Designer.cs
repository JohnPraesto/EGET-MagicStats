namespace MagicStats
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
            this.btnLog = new System.Windows.Forms.Button();
            this.listBoxPlayerOne = new System.Windows.Forms.CheckedListBox();
            this.listBoxPlayerTwo = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnResultOne = new System.Windows.Forms.Button();
            this.btnResultTwo = new System.Windows.Forms.Button();
            this.process1 = new System.Diagnostics.Process();
            this.label5 = new System.Windows.Forms.Label();
            this.picturePlayerOne = new System.Windows.Forms.PictureBox();
            this.picturePlayerTwo = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLatestMatch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayerOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayerTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(202, 543);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(395, 83);
            this.btnLog.TabIndex = 0;
            this.btnLog.Text = "Log Match";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // listBoxPlayerOne
            // 
            this.listBoxPlayerOne.CheckOnClick = true;
            this.listBoxPlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPlayerOne.FormattingEnabled = true;
            this.listBoxPlayerOne.Items.AddRange(new object[] {
            "Batallion",
            "Draw Fire",
            "Extort",
            "Grave",
            "Illusion",
            "Life Gain",
            "Modern",
            "Red Deck Wins"});
            this.listBoxPlayerOne.Location = new System.Drawing.Point(149, 39);
            this.listBoxPlayerOne.Name = "listBoxPlayerOne";
            this.listBoxPlayerOne.Size = new System.Drawing.Size(185, 212);
            this.listBoxPlayerOne.TabIndex = 1;
            this.listBoxPlayerOne.SelectedIndexChanged += new System.EventHandler(this.listBoxPlayerOne_SelectedIndexChanged);
            // 
            // listBoxPlayerTwo
            // 
            this.listBoxPlayerTwo.CheckOnClick = true;
            this.listBoxPlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPlayerTwo.FormattingEnabled = true;
            this.listBoxPlayerTwo.Items.AddRange(new object[] {
            "Batallion",
            "Draw Fire",
            "Extort",
            "Grave",
            "Illusion",
            "Life Gain",
            "Modern",
            "Red Deck Wins"});
            this.listBoxPlayerTwo.Location = new System.Drawing.Point(471, 39);
            this.listBoxPlayerTwo.Name = "listBoxPlayerTwo";
            this.listBoxPlayerTwo.Size = new System.Drawing.Size(181, 212);
            this.listBoxPlayerTwo.TabIndex = 2;
            this.listBoxPlayerTwo.SelectedIndexChanged += new System.EventHandler(this.listBoxPlayerTwo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(493, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Player Two";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Player One";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(349, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Result";
            // 
            // btnResultOne
            // 
            this.btnResultOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultOne.Location = new System.Drawing.Point(149, 380);
            this.btnResultOne.Name = "btnResultOne";
            this.btnResultOne.Size = new System.Drawing.Size(185, 157);
            this.btnResultOne.TabIndex = 10;
            this.btnResultOne.Text = "Player One Result";
            this.btnResultOne.UseVisualStyleBackColor = true;
            this.btnResultOne.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnResultOne_MouseDown);
            // 
            // btnResultTwo
            // 
            this.btnResultTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultTwo.Location = new System.Drawing.Point(471, 380);
            this.btnResultTwo.Name = "btnResultTwo";
            this.btnResultTwo.Size = new System.Drawing.Size(181, 157);
            this.btnResultTwo.TabIndex = 11;
            this.btnResultTwo.Text = "Player Two Result";
            this.btnResultTwo.UseVisualStyleBackColor = true;
            this.btnResultTwo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnResultTwo_MouseDown);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(375, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 37);
            this.label5.TabIndex = 12;
            this.label5.Text = "vs";
            // 
            // picturePlayerOne
            // 
            this.picturePlayerOne.Location = new System.Drawing.Point(149, 257);
            this.picturePlayerOne.Name = "picturePlayerOne";
            this.picturePlayerOne.Size = new System.Drawing.Size(185, 117);
            this.picturePlayerOne.TabIndex = 13;
            this.picturePlayerOne.TabStop = false;
            // 
            // picturePlayerTwo
            // 
            this.picturePlayerTwo.Location = new System.Drawing.Point(471, 257);
            this.picturePlayerTwo.Name = "picturePlayerTwo";
            this.picturePlayerTwo.Size = new System.Drawing.Size(181, 117);
            this.picturePlayerTwo.TabIndex = 14;
            this.picturePlayerTwo.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 675);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Latest match:";
            // 
            // textBoxLatestMatch
            // 
            this.textBoxLatestMatch.Enabled = false;
            this.textBoxLatestMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLatestMatch.Location = new System.Drawing.Point(138, 672);
            this.textBoxLatestMatch.Name = "textBoxLatestMatch";
            this.textBoxLatestMatch.Size = new System.Drawing.Size(639, 29);
            this.textBoxLatestMatch.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 764);
            this.Controls.Add(this.textBoxLatestMatch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.picturePlayerTwo);
            this.Controls.Add(this.picturePlayerOne);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnResultTwo);
            this.Controls.Add(this.btnResultOne);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPlayerTwo);
            this.Controls.Add(this.listBoxPlayerOne);
            this.Controls.Add(this.btnLog);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayerOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayerTwo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.CheckedListBox listBoxPlayerOne;
        private System.Windows.Forms.CheckedListBox listBoxPlayerTwo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnResultOne;
        private System.Windows.Forms.Button btnResultTwo;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.PictureBox picturePlayerTwo;
        private System.Windows.Forms.PictureBox picturePlayerOne;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLatestMatch;
    }
}

