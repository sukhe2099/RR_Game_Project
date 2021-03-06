namespace RR_Game_Project
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.btnRuleToPlay = new System.Windows.Forms.Button();
            this.btnShot = new System.Windows.Forms.Button();
            this.btnAway = new System.Windows.Forms.Button();
            this.btnLoader = new System.Windows.Forms.Button();
            this.lblDeadOrAlive = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRuleToPlay
            // 
            this.btnRuleToPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRuleToPlay.BackgroundImage")));
            this.btnRuleToPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRuleToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRuleToPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRuleToPlay.Location = new System.Drawing.Point(16, 337);
            this.btnRuleToPlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRuleToPlay.Name = "btnRuleToPlay";
            this.btnRuleToPlay.Size = new System.Drawing.Size(307, 143);
            this.btnRuleToPlay.TabIndex = 0;
            this.btnRuleToPlay.Text = "Rules of Game";
            this.btnRuleToPlay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRuleToPlay.UseVisualStyleBackColor = true;
            this.btnRuleToPlay.Click += new System.EventHandler(this.btnRuleToPlay_Click);
            // 
            // btnShot
            // 
            this.btnShot.BackColor = System.Drawing.Color.Silver;
            this.btnShot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnShot.Image = global::RR_Game_Project.Properties.Resources.shut;
            this.btnShot.Location = new System.Drawing.Point(767, 298);
            this.btnShot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShot.Name = "btnShot";
            this.btnShot.Size = new System.Drawing.Size(393, 199);
            this.btnShot.TabIndex = 1;
            this.btnShot.Text = "Shot On Head";
            this.btnShot.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShot.UseVisualStyleBackColor = false;
            this.btnShot.Click += new System.EventHandler(this.btnShot_Click);
            // 
            // btnAway
            // 
            this.btnAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAway.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAway.Image = ((System.Drawing.Image)(resources.GetObject("btnAway.Image")));
            this.btnAway.Location = new System.Drawing.Point(767, 570);
            this.btnAway.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAway.Name = "btnAway";
            this.btnAway.Size = new System.Drawing.Size(393, 144);
            this.btnAway.TabIndex = 2;
            this.btnAway.Text = "Shoot Away (2 Chances)";
            this.btnAway.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAway.UseVisualStyleBackColor = true;
            this.btnAway.Click += new System.EventHandler(this.btnAway_Click);
            // 
            // btnLoader
            // 
            this.btnLoader.BackColor = System.Drawing.Color.White;
            this.btnLoader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLoader.Image = ((System.Drawing.Image)(resources.GetObject("btnLoader.Image")));
            this.btnLoader.Location = new System.Drawing.Point(767, 83);
            this.btnLoader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoader.Name = "btnLoader";
            this.btnLoader.Size = new System.Drawing.Size(393, 154);
            this.btnLoader.TabIndex = 3;
            this.btnLoader.Text = "Load & Spin";
            this.btnLoader.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoader.UseVisualStyleBackColor = false;
            this.btnLoader.Click += new System.EventHandler(this.btnLoader_Click);
            // 
            // lblDeadOrAlive
            // 
            this.lblDeadOrAlive.AutoSize = true;
            this.lblDeadOrAlive.BackColor = System.Drawing.Color.Gainsboro;
            this.lblDeadOrAlive.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadOrAlive.ForeColor = System.Drawing.Color.Black;
            this.lblDeadOrAlive.Location = new System.Drawing.Point(432, 9);
            this.lblDeadOrAlive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeadOrAlive.Name = "lblDeadOrAlive";
            this.lblDeadOrAlive.Size = new System.Drawing.Size(433, 42);
            this.lblDeadOrAlive.TabIndex = 0;
            this.lblDeadOrAlive.Text = "Russian Roullete Game";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPlayAgain.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayAgain.Image")));
            this.btnPlayAgain.Location = new System.Drawing.Point(16, 527);
            this.btnPlayAgain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(307, 158);
            this.btnPlayAgain.TabIndex = 5;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Visible = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(11, 187);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(248, 25);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.Text = "Please Enter Your Name";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(359, 186);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(227, 22);
            this.txtUserName.TabIndex = 7;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1252, 902);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lblDeadOrAlive);
            this.Controls.Add(this.btnLoader);
            this.Controls.Add(this.btnAway);
            this.Controls.Add(this.btnShot);
            this.Controls.Add(this.btnRuleToPlay);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GameForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRuleToPlay;
        private System.Windows.Forms.Button btnShot;
        private System.Windows.Forms.Button btnAway;
        private System.Windows.Forms.Button btnLoader;
        private System.Windows.Forms.Label lblDeadOrAlive;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
    }
}

