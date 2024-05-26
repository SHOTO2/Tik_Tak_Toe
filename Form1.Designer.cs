namespace Tik_Tak_Toe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.texPlayer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.texWinner = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pk1 = new System.Windows.Forms.PictureBox();
            this.pk2 = new System.Windows.Forms.PictureBox();
            this.pk3 = new System.Windows.Forms.PictureBox();
            this.pk4 = new System.Windows.Forms.PictureBox();
            this.pk5 = new System.Windows.Forms.PictureBox();
            this.pk6 = new System.Windows.Forms.PictureBox();
            this.pk9 = new System.Windows.Forms.PictureBox();
            this.pk8 = new System.Windows.Forms.PictureBox();
            this.pk7 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pk1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pk2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pk3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pk4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pk5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pk6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pk9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pk8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pk7)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tik_Tak_Toe.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(26, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(12, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 81);
            this.label1.TabIndex = 1;
            this.label1.Text = "Turn";
            // 
            // texPlayer
            // 
            this.texPlayer.AutoSize = true;
            this.texPlayer.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texPlayer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.texPlayer.Location = new System.Drawing.Point(55, 329);
            this.texPlayer.Name = "texPlayer";
            this.texPlayer.Size = new System.Drawing.Size(119, 37);
            this.texPlayer.TabIndex = 2;
            this.texPlayer.Text = "No one";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(17, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 81);
            this.label2.TabIndex = 3;
            this.label2.Text = "Winner";
            // 
            // texWinner
            // 
            this.texWinner.AutoSize = true;
            this.texWinner.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texWinner.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.texWinner.Location = new System.Drawing.Point(55, 469);
            this.texWinner.Name = "texWinner";
            this.texWinner.Size = new System.Drawing.Size(124, 37);
            this.texWinner.TabIndex = 4;
            this.texWinner.Text = "No One";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(31, 572);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 56);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reset Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pk1
            // 
            this.pk1.BackColor = System.Drawing.Color.Transparent;
            this.pk1.Image = ((System.Drawing.Image)(resources.GetObject("pk1.Image")));
            this.pk1.Location = new System.Drawing.Point(65, 22);
            this.pk1.Name = "pk1";
            this.pk1.Size = new System.Drawing.Size(169, 147);
            this.pk1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pk1.TabIndex = 6;
            this.pk1.TabStop = false;
            this.pk1.Tag = "?";
            this.pk1.Click += new System.EventHandler(this.pk_Click);
            // 
            // pk2
            // 
            this.pk2.BackColor = System.Drawing.Color.Transparent;
            this.pk2.Image = ((System.Drawing.Image)(resources.GetObject("pk2.Image")));
            this.pk2.Location = new System.Drawing.Point(317, 22);
            this.pk2.Name = "pk2";
            this.pk2.Size = new System.Drawing.Size(169, 147);
            this.pk2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pk2.TabIndex = 7;
            this.pk2.TabStop = false;
            this.pk2.Tag = "?";
            this.pk2.Click += new System.EventHandler(this.pk_Click);
            // 
            // pk3
            // 
            this.pk3.BackColor = System.Drawing.Color.Transparent;
            this.pk3.Image = ((System.Drawing.Image)(resources.GetObject("pk3.Image")));
            this.pk3.Location = new System.Drawing.Point(553, 22);
            this.pk3.Name = "pk3";
            this.pk3.Size = new System.Drawing.Size(169, 147);
            this.pk3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pk3.TabIndex = 8;
            this.pk3.TabStop = false;
            this.pk3.Tag = "?";
            this.pk3.Click += new System.EventHandler(this.pk_Click);
            // 
            // pk4
            // 
            this.pk4.BackColor = System.Drawing.Color.Transparent;
            this.pk4.Image = ((System.Drawing.Image)(resources.GetObject("pk4.Image")));
            this.pk4.Location = new System.Drawing.Point(65, 214);
            this.pk4.Name = "pk4";
            this.pk4.Size = new System.Drawing.Size(169, 147);
            this.pk4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pk4.TabIndex = 9;
            this.pk4.TabStop = false;
            this.pk4.Tag = "?";
            this.pk4.Click += new System.EventHandler(this.pk_Click);
            // 
            // pk5
            // 
            this.pk5.BackColor = System.Drawing.Color.Transparent;
            this.pk5.Image = ((System.Drawing.Image)(resources.GetObject("pk5.Image")));
            this.pk5.Location = new System.Drawing.Point(317, 214);
            this.pk5.Name = "pk5";
            this.pk5.Size = new System.Drawing.Size(169, 147);
            this.pk5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pk5.TabIndex = 10;
            this.pk5.TabStop = false;
            this.pk5.Tag = "?";
            this.pk5.Click += new System.EventHandler(this.pk_Click);
            // 
            // pk6
            // 
            this.pk6.BackColor = System.Drawing.Color.Transparent;
            this.pk6.Image = ((System.Drawing.Image)(resources.GetObject("pk6.Image")));
            this.pk6.Location = new System.Drawing.Point(553, 214);
            this.pk6.Name = "pk6";
            this.pk6.Size = new System.Drawing.Size(169, 147);
            this.pk6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pk6.TabIndex = 11;
            this.pk6.TabStop = false;
            this.pk6.Tag = "?";
            this.pk6.Click += new System.EventHandler(this.pk_Click);
            // 
            // pk9
            // 
            this.pk9.BackColor = System.Drawing.Color.Transparent;
            this.pk9.Image = ((System.Drawing.Image)(resources.GetObject("pk9.Image")));
            this.pk9.Location = new System.Drawing.Point(553, 413);
            this.pk9.Name = "pk9";
            this.pk9.Size = new System.Drawing.Size(169, 133);
            this.pk9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pk9.TabIndex = 14;
            this.pk9.TabStop = false;
            this.pk9.Tag = "?";
            this.pk9.Click += new System.EventHandler(this.pk_Click);
            // 
            // pk8
            // 
            this.pk8.BackColor = System.Drawing.Color.Transparent;
            this.pk8.Image = ((System.Drawing.Image)(resources.GetObject("pk8.Image")));
            this.pk8.Location = new System.Drawing.Point(317, 413);
            this.pk8.Name = "pk8";
            this.pk8.Size = new System.Drawing.Size(169, 133);
            this.pk8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pk8.TabIndex = 13;
            this.pk8.TabStop = false;
            this.pk8.Tag = "?";
            this.pk8.Click += new System.EventHandler(this.pk_Click);
            // 
            // pk7
            // 
            this.pk7.BackColor = System.Drawing.Color.Transparent;
            this.pk7.Image = ((System.Drawing.Image)(resources.GetObject("pk7.Image")));
            this.pk7.Location = new System.Drawing.Point(65, 413);
            this.pk7.Name = "pk7";
            this.pk7.Size = new System.Drawing.Size(169, 133);
            this.pk7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pk7.TabIndex = 12;
            this.pk7.TabStop = false;
            this.pk7.Tag = "?";
            this.pk7.Click += new System.EventHandler(this.pk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pk9);
            this.groupBox1.Controls.Add(this.pk8);
            this.groupBox1.Controls.Add(this.pk7);
            this.groupBox1.Controls.Add(this.pk6);
            this.groupBox1.Controls.Add(this.pk5);
            this.groupBox1.Controls.Add(this.pk4);
            this.groupBox1.Controls.Add(this.pk3);
            this.groupBox1.Controls.Add(this.pk2);
            this.groupBox1.Controls.Add(this.pk1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(263, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 588);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(404, -18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(524, 140);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tic Tac Toe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1108, 716);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.texWinner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.texPlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pk1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pk2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pk3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pk4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pk5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pk6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pk9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pk8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pk7)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label texPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label texWinner;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pk1;
        private System.Windows.Forms.PictureBox pk2;
        private System.Windows.Forms.PictureBox pk3;
        private System.Windows.Forms.PictureBox pk4;
        private System.Windows.Forms.PictureBox pk5;
        private System.Windows.Forms.PictureBox pk6;
        private System.Windows.Forms.PictureBox pk9;
        private System.Windows.Forms.PictureBox pk8;
        private System.Windows.Forms.PictureBox pk7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
    }
}

