
namespace Melt_The_Jelly_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtDrops = new System.Windows.Forms.Label();
            this.txtJelliesMelted = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.player = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDrops
            // 
            this.txtDrops.AutoSize = true;
            this.txtDrops.Font = new System.Drawing.Font("Showcard Gothic", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtDrops.ForeColor = System.Drawing.Color.White;
            this.txtDrops.Location = new System.Drawing.Point(59, 24);
            this.txtDrops.Name = "txtDrops";
            this.txtDrops.Size = new System.Drawing.Size(294, 47);
            this.txtDrops.TabIndex = 0;
            this.txtDrops.Text = "Drops left: 0";
            this.txtDrops.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtJelliesMelted
            // 
            this.txtJelliesMelted.AutoSize = true;
            this.txtJelliesMelted.Font = new System.Drawing.Font("Showcard Gothic", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtJelliesMelted.ForeColor = System.Drawing.Color.White;
            this.txtJelliesMelted.Location = new System.Drawing.Point(710, 24);
            this.txtJelliesMelted.Name = "txtJelliesMelted";
            this.txtJelliesMelted.Size = new System.Drawing.Size(364, 47);
            this.txtJelliesMelted.TabIndex = 1;
            this.txtJelliesMelted.Text = "Jellies melted: 0";
            this.txtJelliesMelted.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(450, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 47);
            this.label2.TabIndex = 2;
            this.label2.Text = "Health:";
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(100, 84);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(1000, 45);
            this.healthBar.TabIndex = 3;
            this.healthBar.Value = 100;
            this.healthBar.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // player
            // 
            this.player.Image = global::Melt_The_Jelly_Game.Properties.Resources.up;
            this.player.Location = new System.Drawing.Point(536, 631);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 71);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.player);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtJelliesMelted);
            this.Controls.Add(this.txtDrops);
            this.Name = "Form1";
            this.Text = "Jelly Shooter Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtDrops;
        private System.Windows.Forms.Label txtJelliesMelted;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer GameTimer;
    }
}

