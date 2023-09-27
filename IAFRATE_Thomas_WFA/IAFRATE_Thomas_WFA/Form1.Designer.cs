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
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox14 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Plateform2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Plateform3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Plateform4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Door).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Me).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            SuspendLayout();
            // 
            // Plateform2
            // 
            Plateform2.BackColor = Color.Transparent;
            Plateform2.BackgroundImage = Properties.Resources.plateform;
            Plateform2.Location = new Point(227, 451);
            Plateform2.Name = "Plateform2";
            Plateform2.Size = new Size(145, 33);
            Plateform2.SizeMode = PictureBoxSizeMode.StretchImage;
            Plateform2.TabIndex = 5;
            Plateform2.TabStop = false;
            Plateform2.Tag = "platform";
            // 
            // Plateform3
            // 
            Plateform3.BackColor = Color.Transparent;
            Plateform3.BackgroundImage = Properties.Resources.plateform;
            Plateform3.Location = new Point(0, 137);
            Plateform3.Name = "Plateform3";
            Plateform3.Size = new Size(241, 35);
            Plateform3.SizeMode = PictureBoxSizeMode.StretchImage;
            Plateform3.TabIndex = 6;
            Plateform3.TabStop = false;
            Plateform3.Tag = "platform";
            // 
            // Plateform4
            // 
            Plateform4.BackColor = Color.Transparent;
            Plateform4.BackgroundImage = Properties.Resources.plateform;
            Plateform4.Location = new Point(208, 203);
            Plateform4.Name = "Plateform4";
            Plateform4.Size = new Size(145, 35);
            Plateform4.SizeMode = PictureBoxSizeMode.StretchImage;
            Plateform4.TabIndex = 7;
            Plateform4.TabStop = false;
            Plateform4.Tag = "platform";
            // 
            // Door
            // 
            Door.BackColor = Color.Transparent;
            Door.Image = Properties.Resources._9530132de98ea26;
            Door.Location = new Point(50, 53);
            Door.Name = "Door";
            Door.Size = new Size(90, 85);
            Door.SizeMode = PictureBoxSizeMode.StretchImage;
            Door.TabIndex = 8;
            Door.TabStop = false;
            Door.Tag = "door";
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
            Me.Location = new Point(28, 462);
            Me.Margin = new Padding(0);
            Me.Name = "Me";
            Me.Size = new Size(46, 58);
            Me.SizeMode = PictureBoxSizeMode.Zoom;
            Me.TabIndex = 11;
            Me.TabStop = false;
            // 
            // ground
            // 
            ground.BackgroundImage = Properties.Resources.Terrain__16x16_2;
            ground.Location = new Point(-66, 512);
            ground.Name = "ground";
            ground.Size = new Size(810, 113);
            ground.SizeMode = PictureBoxSizeMode.CenterImage;
            ground.TabIndex = 12;
            ground.TabStop = false;
            ground.Tag = "platform";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.plateform;
            pictureBox1.Location = new Point(408, 391);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "platform";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.plateform;
            pictureBox2.Location = new Point(508, 321);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(145, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "platform";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = Properties.Resources.plateform;
            pictureBox4.Location = new Point(0, 391);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(140, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "platform";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImage = Properties.Resources.plateform;
            pictureBox5.Location = new Point(644, 253);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(100, 36);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 17;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "platform";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.BackgroundImage = Properties.Resources.plateform;
            pictureBox6.Location = new Point(424, 178);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(145, 35);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 18;
            pictureBox6.TabStop = false;
            pictureBox6.Tag = "platform";
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.BackgroundImage = Properties.Resources.Cherries1;
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.Location = new Point(10, 342);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(31, 55);
            pictureBox7.TabIndex = 19;
            pictureBox7.TabStop = false;
            pictureBox7.Tag = "fruit";
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.BackgroundImage = Properties.Resources.Cherries1;
            pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox8.Location = new Point(55, 342);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(31, 55);
            pictureBox8.TabIndex = 20;
            pictureBox8.TabStop = false;
            pictureBox8.Tag = "fruit";
            // 
            // pictureBox12
            // 
            pictureBox12.BackColor = Color.Transparent;
            pictureBox12.BackgroundImage = Properties.Resources.Cherries1;
            pictureBox12.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox12.Location = new Point(286, 391);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(31, 55);
            pictureBox12.TabIndex = 24;
            pictureBox12.TabStop = false;
            pictureBox12.Tag = "fruit";
            // 
            // pictureBox14
            // 
            pictureBox14.BackColor = Color.Transparent;
            pictureBox14.BackgroundImage = Properties.Resources.Cherries1;
            pictureBox14.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox14.Location = new Point(268, 137);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(31, 55);
            pictureBox14.TabIndex = 26;
            pictureBox14.TabStop = false;
            pictureBox14.Tag = "fruit";
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.Transparent;
            pictureBox9.BackgroundImage = Properties.Resources.Cherries1;
            pictureBox9.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox9.Location = new Point(514, 117);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(31, 55);
            pictureBox9.TabIndex = 30;
            pictureBox9.TabStop = false;
            pictureBox9.Tag = "fruit";
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.Transparent;
            pictureBox10.BackgroundImage = Properties.Resources.Cherries1;
            pictureBox10.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox10.Location = new Point(477, 118);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(31, 55);
            pictureBox10.TabIndex = 29;
            pictureBox10.TabStop = false;
            pictureBox10.Tag = "fruit";
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = Color.Transparent;
            pictureBox11.BackgroundImage = Properties.Resources.Cherries1;
            pictureBox11.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox11.Location = new Point(440, 118);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(31, 55);
            pictureBox11.TabIndex = 28;
            pictureBox11.TabStop = false;
            pictureBox11.Tag = "fruit";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(-1, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 32);
            label1.TabIndex = 59;
            label1.Text = "Score :";
            // 
            // Form1
            // 
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Brown;
            ClientSize = new Size(737, 543);
            Controls.Add(label1);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(ground);
            Controls.Add(Me);
            Controls.Add(Door);
            Controls.Add(Plateform4);
            Controls.Add(Plateform2);
            Controls.Add(Plateform3);
            Controls.Add(ScoreTxt);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox14);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
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
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox12;
        private PictureBox pictureBox14;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private Label label1;
    }
}