namespace flying_bird
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
            this.components = new System.ComponentModel.Container();
            this.scoretext = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grownd = new System.Windows.Forms.PictureBox();
            this.pipedown = new System.Windows.Forms.PictureBox();
            this.pipetop = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.pipedown2 = new System.Windows.Forms.PictureBox();
            this.pipetop2 = new System.Windows.Forms.PictureBox();
            this.restart = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grownd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // scoretext
            // 
            this.scoretext.AutoSize = true;
            this.scoretext.BackColor = System.Drawing.Color.White;
            this.scoretext.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scoretext.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoretext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.scoretext.Location = new System.Drawing.Point(303, 679);
            this.scoretext.Name = "scoretext";
            this.scoretext.Size = new System.Drawing.Size(109, 31);
            this.scoretext.TabIndex = 4;
            this.scoretext.Text = "Score : 20";
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.gametimerevent);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::flying_bird.Properties.Resources.Screenshot__391_;
            this.pictureBox1.Location = new System.Drawing.Point(660, 691);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // grownd
            // 
            this.grownd.Image = global::flying_bird.Properties.Resources.ground;
            this.grownd.Location = new System.Drawing.Point(-6, 632);
            this.grownd.Name = "grownd";
            this.grownd.Size = new System.Drawing.Size(771, 102);
            this.grownd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grownd.TabIndex = 3;
            this.grownd.TabStop = false;
            // 
            // pipedown
            // 
            this.pipedown.Image = global::flying_bird.Properties.Resources.pipe;
            this.pipedown.Location = new System.Drawing.Point(244, 538);
            this.pipedown.Name = "pipedown";
            this.pipedown.Size = new System.Drawing.Size(100, 99);
            this.pipedown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipedown.TabIndex = 2;
            this.pipedown.TabStop = false;
            // 
            // pipetop
            // 
            this.pipetop.Image = global::flying_bird.Properties.Resources.pipedown;
            this.pipetop.Location = new System.Drawing.Point(269, -3);
            this.pipetop.Name = "pipetop";
            this.pipetop.Size = new System.Drawing.Size(100, 158);
            this.pipetop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipetop.TabIndex = 1;
            this.pipetop.TabStop = false;
            // 
            // bird
            // 
            this.bird.Image = global::flying_bird.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(12, 243);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(100, 68);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // pipedown2
            // 
            this.pipedown2.Image = global::flying_bird.Properties.Resources.pipe;
            this.pipedown2.Location = new System.Drawing.Point(517, 446);
            this.pipedown2.Name = "pipedown2";
            this.pipedown2.Size = new System.Drawing.Size(100, 191);
            this.pipedown2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipedown2.TabIndex = 6;
            this.pipedown2.TabStop = false;
            // 
            // pipetop2
            // 
            this.pipetop2.Image = global::flying_bird.Properties.Resources.pipedown;
            this.pipetop2.Location = new System.Drawing.Point(610, -3);
            this.pipetop2.Name = "pipetop2";
            this.pipetop2.Size = new System.Drawing.Size(100, 254);
            this.pipetop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipetop2.TabIndex = 7;
            this.pipetop2.TabStop = false;
            // 
            // restart
            // 
            this.restart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.restart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart.Location = new System.Drawing.Point(100, 150);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(138, 38);
            this.restart.TabIndex = 0;
            this.restart.Text = "Restart";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // end
            // 
            this.end.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end.Location = new System.Drawing.Point(100, 215);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(138, 38);
            this.end.TabIndex = 1;
            this.end.Text = "Close";
            this.end.UseVisualStyleBackColor = true;
            this.end.Click += new System.EventHandler(this.end_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(50, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Game Over !";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.end);
            this.groupBox1.Controls.Add(this.restart);
            this.groupBox1.Location = new System.Drawing.Point(216, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 281);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(82, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = " Your Score : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(756, 731);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pipetop2);
            this.Controls.Add(this.pipedown2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.scoretext);
            this.Controls.Add(this.grownd);
            this.Controls.Add(this.pipedown);
            this.Controls.Add(this.pipetop);
            this.Controls.Add(this.bird);
            this.Name = "Form1";
            this.Text = "පියාඹන කුරුල්ලා";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamedown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameup);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grownd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox pipetop;
        private System.Windows.Forms.PictureBox pipedown;
        private System.Windows.Forms.PictureBox grownd;
        private System.Windows.Forms.Label scoretext;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pipedown2;
        private System.Windows.Forms.PictureBox pipetop2;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Button end;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}

