namespace IAFRATE_Thomas_WFA
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
            components = new System.ComponentModel.Container();
            Plateform2 = new PictureBox();
            Plateform3 = new PictureBox();
            Plateform4 = new PictureBox();
            Door = new PictureBox();
            GameTimer = new System.Windows.Forms.Timer(components);
            ScoreTxt = new Label();
            Me = new PictureBox();
            ground = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Plateform2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Plateform3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Plateform4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Door).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Me).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Plateform2
            // 
            Plateform2.BackColor = Color.Transparent;
            Plateform2.BackgroundImage = Properties.Resources.plateform;
            Plateform2.Location = new Point(187, 447);
            Plateform2.Name = "Plateform2";
            Plateform2.Size = new Size(241, 33);
            Plateform2.SizeMode = PictureBoxSizeMode.StretchImage;
            Plateform2.TabIndex = 5;
            Plateform2.TabStop = false;
            Plateform2.Tag = "platform";
            // 
            // Plateform3
            // 
            Plateform3.BackColor = Color.Transparent;
            Plateform3.BackgroundImage = Properties.Resources.plateform;
            Plateform3.Location = new Point(-5, 152);
            Plateform3.Name = "Plateform3";
            Plateform3.Size = new Size(242, 34);
            Plateform3.SizeMode = PictureBoxSizeMode.StretchImage;
            Plateform3.TabIndex = 6;
            Plateform3.TabStop = false;
            Plateform3.Tag = "platform";
            // 
            // Plateform4
            // 
            Plateform4.BackColor = Color.Transparent;
            Plateform4.BackgroundImage = Properties.Resources.plateform;
            Plateform4.Location = new Point(187, 208);
            Plateform4.Name = "Plateform4";
            Plateform4.Size = new Size(242, 34);
            Plateform4.SizeMode = PictureBoxSizeMode.StretchImage;
            Plateform4.TabIndex = 7;
            Plateform4.TabStop = false;
            Plateform4.Tag = "platform";
            // 
            // Door
            // 
            Door.BackColor = Color.Transparent;
            Door.Image = Properties.Resources._9530132de98ea26;
            Door.Location = new Point(48, 52);
            Door.Name = "Door";
            Door.Size = new Size(116, 102);
            Door.SizeMode = PictureBoxSizeMode.StretchImage;
            Door.TabIndex = 8;
            Door.TabStop = false;
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 50;
            GameTimer.Tick += GameTimerEvent;
            // 
            // ScoreTxt
            // 
            ScoreTxt.AutoSize = true;
            ScoreTxt.BackColor = SystemColors.InactiveBorder;
            ScoreTxt.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ScoreTxt.Location = new Point(0, 0);
            ScoreTxt.Name = "ScoreTxt";
            ScoreTxt.Size = new Size(0, 29);
            ScoreTxt.TabIndex = 10;
            // 
            // Me
            // 
            Me.BackColor = Color.Transparent;
            Me.Image = Properties.Resources.character;
            Me.Location = new Point(28, 447);
            Me.Margin = new Padding(0);
            Me.Name = "Me";
            Me.Size = new Size(56, 73);
            Me.SizeMode = PictureBoxSizeMode.Zoom;
            Me.TabIndex = 11;
            Me.TabStop = false;
            // 
            // ground
            // 
            ground.BackgroundImage = Properties.Resources.Terrain__16x16_2;
            ground.Location = new Point(-66, 512);
            ground.Name = "ground";
            ground.Size = new Size(810, 48);
            ground.SizeMode = PictureBoxSizeMode.CenterImage;
            ground.TabIndex = 12;
            ground.TabStop = false;
            ground.Tag = "platform";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.plateform;
            pictureBox1.Location = new Point(379, 373);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "platform";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.plateform;
            pictureBox2.Location = new Point(476, 286);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(145, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "platform";
            // 
            // Form1
            // 
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Brown;
            ClientSize = new Size(737, 543);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(ground);
            Controls.Add(Me);
            Controls.Add(Door);
            Controls.Add(Plateform4);
            Controls.Add(Plateform2);
            Controls.Add(Plateform3);
            Controls.Add(ScoreTxt);
            DoubleBuffered = true;
            Name = "Form1";
            FormClosed += formclosed;
            KeyDown += gamekeyisdown;
            KeyUp += gamekeyisup;
            ((System.ComponentModel.ISupportInitialize)Plateform2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Plateform3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Plateform4).EndInit();
            ((System.ComponentModel.ISupportInitialize)Door).EndInit();
            ((System.ComponentModel.ISupportInitialize)Me).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox Plateform2;
        private PictureBox Plateform3;
        private PictureBox Plateform4;
        private PictureBox Door;
        private System.Windows.Forms.Timer GameTimer;
        private Label ScoreTxt;
        private PictureBox Me;
        private PictureBox ground;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}