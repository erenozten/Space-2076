namespace SpaceGame
{
    //--auto-generated codes
    partial class SpaceForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpaceForm));
            this.MoveBgTimer = new System.Windows.Forms.Timer(this.components);
            this.UzayGemisi = new System.Windows.Forms.PictureBox();
            this.MoveLeftTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveRigthTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveTopTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveDownTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveMunitionTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.scorelbl = new System.Windows.Forms.Label();
            this.levelbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MoveEnemiesTimer = new System.Windows.Forms.Timer(this.components);
            this.Text_lbl = new System.Windows.Forms.Label();
            this.ReplayBtn = new System.Windows.Forms.Button();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.EnemiesMunitionTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UzayGemisi)).BeginInit();
            this.SuspendLayout();

            this.MoveBgTimer.Enabled = true;
            this.MoveBgTimer.Interval = 10;
            this.MoveBgTimer.Tick += new System.EventHandler(this.MoveBgTimer_Tick);

            this.UzayGemisi.BackColor = System.Drawing.Color.Transparent;
            this.UzayGemisi.Image = ((System.Drawing.Image)(resources.GetObject("UzayGemisi.Image")));
            this.UzayGemisi.Location = new System.Drawing.Point(237, 387);
            this.UzayGemisi.Name = "UzayGemisi";
            this.UzayGemisi.Size = new System.Drawing.Size(78, 68);
            this.UzayGemisi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UzayGemisi.TabIndex = 0;
            this.UzayGemisi.TabStop = false;
            this.UzayGemisi.Click += new System.EventHandler(this.Aircraft_Click);

            this.MoveLeftTimer.Interval = 5;
            this.MoveLeftTimer.Tick += new System.EventHandler(this.MoveLeftTimer_Tick);

            this.MoveRigthTimer.Interval = 5;
            this.MoveRigthTimer.Tick += new System.EventHandler(this.MoveRigthTimer_Tick);

            this.MoveTopTimer.Interval = 5;
            this.MoveTopTimer.Tick += new System.EventHandler(this.MoveTopTimer_Tick);

            this.MoveDownTimer.Interval = 5;
            this.MoveDownTimer.Tick += new System.EventHandler(this.MoveDownTimer_Tick);

            this.MoveMunitionTimer.Enabled = true;
            this.MoveMunitionTimer.Interval = 20;
            this.MoveMunitionTimer.Tick += new System.EventHandler(this.MermiyiHareketEttirTimer_Tick);

            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "SCORE:";

            this.scorelbl.AutoSize = true;
            this.scorelbl.BackColor = System.Drawing.Color.Transparent;
            this.scorelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.scorelbl.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.scorelbl.Location = new System.Drawing.Point(90, 12);
            this.scorelbl.Name = "scorelbl";
            this.scorelbl.Size = new System.Drawing.Size(32, 24);
            this.scorelbl.TabIndex = 27;
            this.scorelbl.Text = "00";

            this.levelbl.AutoSize = true;
            this.levelbl.BackColor = System.Drawing.Color.Transparent;
            this.levelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.levelbl.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.levelbl.Location = new System.Drawing.Point(542, 10);
            this.levelbl.Name = "levelbl";
            this.levelbl.Size = new System.Drawing.Size(32, 24);
            this.levelbl.TabIndex = 29;
            this.levelbl.Text = "01";

            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Location = new System.Drawing.Point(464, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "LEVEL:";
            this.label4.Click += new System.EventHandler(this.label4_Click);

            this.MoveEnemiesTimer.Enabled = true;
            this.MoveEnemiesTimer.Tick += new System.EventHandler(this.DusmanlariHareketEttirTimer_Tick);

            this.Text_lbl.AutoSize = true;
            this.Text_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Text_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_lbl.ForeColor = System.Drawing.Color.Red;
            this.Text_lbl.Location = new System.Drawing.Point(61, 108);
            this.Text_lbl.Name = "Text_lbl";
            this.Text_lbl.Size = new System.Drawing.Size(272, 55);
            this.Text_lbl.TabIndex = 35;
            this.Text_lbl.Text = "Game Over";
            this.Text_lbl.Visible = false;
            this.Text_lbl.Click += new System.EventHandler(this.Text_lbl_Click);

            this.ReplayBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.ReplayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReplayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplayBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ReplayBtn.Location = new System.Drawing.Point(154, 218);
            this.ReplayBtn.Name = "ReplayBtn";
            this.ReplayBtn.Size = new System.Drawing.Size(262, 44);
            this.ReplayBtn.TabIndex = 36;
            this.ReplayBtn.Text = "Tekrar Oyna!";
            this.ReplayBtn.UseVisualStyleBackColor = false;
            this.ReplayBtn.Visible = false;
            this.ReplayBtn.Click += new System.EventHandler(this.ReplayBtn_Click);

            this.QuitBtn.BackColor = System.Drawing.Color.Red;
            this.QuitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.QuitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.QuitBtn.Location = new System.Drawing.Point(154, 279);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(262, 44);
            this.QuitBtn.TabIndex = 37;
            this.QuitBtn.Text = "Çık";
            this.QuitBtn.UseVisualStyleBackColor = false;
            this.QuitBtn.Visible = false;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);

            this.EnemiesMunitionTimer.Enabled = true;
            this.EnemiesMunitionTimer.Interval = 20;
            this.EnemiesMunitionTimer.Tick += new System.EventHandler(this.DusmanlarMermiTimer_Tick);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(56)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.QuitBtn);
            this.Controls.Add(this.ReplayBtn);
            this.Controls.Add(this.Text_lbl);
            this.Controls.Add(this.levelbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.scorelbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UzayGemisi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.Name = "SpaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space 2076";
            this.Load += new System.EventHandler(this.SpaceForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SpaceForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SpaceForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.UzayGemisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MoveBgTimer;
        private System.Windows.Forms.PictureBox UzayGemisi;
        private System.Windows.Forms.Timer MoveLeftTimer;
        private System.Windows.Forms.Timer MoveRigthTimer;
        private System.Windows.Forms.Timer MoveTopTimer;
        private System.Windows.Forms.Timer MoveDownTimer;
        private System.Windows.Forms.Timer MoveMunitionTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scorelbl;
        private System.Windows.Forms.Label levelbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer MoveEnemiesTimer;
        private System.Windows.Forms.Label Text_lbl;
        private System.Windows.Forms.Button ReplayBtn;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.Timer EnemiesMunitionTimer;
    }
}

