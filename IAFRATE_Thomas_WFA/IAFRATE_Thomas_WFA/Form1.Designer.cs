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
            Me = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            Plateform1 = new PictureBox();
            Plateform2 = new PictureBox();
            Plateform3 = new PictureBox();
            Plateform4 = new PictureBox();
            Door = new PictureBox();
            GameTimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            ScoreTxt = new Label();
            ((System.ComponentModel.ISupportInitialize)Me).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Plateform1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Plateform2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Plateform3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Plateform4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Door).BeginInit();
            SuspendLayout();
            // 
            // Me
            // 
            Me.Image = Properties.Resources.itsasecret;
            Me.Location = new Point(27, 555);
            Me.Name = "Me";
            Me.Size = new Size(169, 163);
            Me.SizeMode = PictureBoxSizeMode.StretchImage;
            Me.TabIndex = 0;
            Me.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._2D_SpriteShape_025;
            pictureBox2.Location = new Point(-7, 684);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(348, 122);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._2D_SpriteShape_025;
            pictureBox3.Location = new Point(338, 684);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(347, 122);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._2D_SpriteShape_025;
            pictureBox4.Location = new Point(682, 684);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(348, 122);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // Plateform1
            // 
            Plateform1.Image = Properties.Resources._2D_SpriteShape_025;
            Plateform1.Location = new Point(485, 537);
            Plateform1.Name = "Plateform1";
            Plateform1.Size = new Size(282, 84);
            Plateform1.SizeMode = PictureBoxSizeMode.StretchImage;
            Plateform1.TabIndex = 4;
            Plateform1.TabStop = false;
            // 
            // Plateform2
            // 
            Plateform2.Image = Properties.Resources._2D_SpriteShape_025;
            Plateform2.Location = new Point(710, 379);
            Plateform2.Name = "Plateform2";
            Plateform2.Size = new Size(282, 84);
            Plateform2.SizeMode = PictureBoxSizeMode.StretchImage;
            Plateform2.TabIndex = 5;
            Plateform2.TabStop = false;
            // 
            // Plateform3
            // 
            Plateform3.Image = Properties.Resources._2D_SpriteShape_025;
            Plateform3.Location = new Point(338, 222);
            Plateform3.Name = "Plateform3";
            Plateform3.Size = new Size(282, 84);
            Plateform3.SizeMode = PictureBoxSizeMode.StretchImage;
            Plateform3.TabIndex = 6;
            Plateform3.TabStop = false;
            // 
            // Plateform4
            // 
            Plateform4.Image = Properties.Resources._2D_SpriteShape_025;
            Plateform4.Location = new Point(12, 379);
            Plateform4.Name = "Plateform4";
            Plateform4.Size = new Size(282, 84);
            Plateform4.SizeMode = PictureBoxSizeMode.StretchImage;
            Plateform4.TabIndex = 7;
            Plateform4.TabStop = false;
            // 
            // Door
            // 
            Door.Image = Properties.Resources._9530132de98ea26;
            Door.Location = new Point(30, 222);
            Door.Name = "Door";
            Door.Size = new Size(176, 159);
            Door.SizeMode = PictureBoxSizeMode.StretchImage;
            Door.TabIndex = 8;
            Door.TabStop = false;
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 20;
            GameTimer.Tick += GameTimerEvent;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-30, 366);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 9;
            label1.Text = "label1";
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
            // Form1
            // 
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1004, 748);
            Controls.Add(ScoreTxt);
            Controls.Add(label1);
            Controls.Add(Door);
            Controls.Add(Plateform4);
            Controls.Add(Plateform3);
            Controls.Add(Plateform2);
            Controls.Add(Plateform1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(Me);
            Name = "Form1";
            FormClosed += formclosed;
            KeyDown += gamekeyisdown;
            KeyUp += gamekeyisup;
            ((System.ComponentModel.ISupportInitialize)Me).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)Plateform1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Plateform2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Plateform3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Plateform4).EndInit();
            ((System.ComponentModel.ISupportInitialize)Door).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Me;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox Plateform1;
        private PictureBox Plateform2;
        private PictureBox Plateform3;
        private PictureBox Plateform4;
        private PictureBox Door;
        private System.Windows.Forms.Timer GameTimer;
        private Label label1;
        private Label ScoreTxt;
    }
}