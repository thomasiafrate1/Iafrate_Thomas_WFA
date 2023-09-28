namespace IAFRATE_Thomas_WFA
{
    partial class Fin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Rejouer = new Button();
            Accueil = new Button();
            Quitter = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(251, 104);
            label1.Name = "label1";
            label1.Size = new Size(236, 44);
            label1.TabIndex = 0;
            label1.Text = "Félicitation !";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(196, 49);
            label2.Name = "label2";
            label2.Size = new Size(343, 44);
            label2.TabIndex = 1;
            label2.Text = "Vous avez terminé";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Chiller", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(196, 172);
            label3.Name = "label3";
            label3.Size = new Size(343, 74);
            label3.TabIndex = 2;
            label3.Text = "A Frog Journey";
            // 
            // Rejouer
            // 
            Rejouer.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Rejouer.Location = new Point(140, 407);
            Rejouer.Name = "Rejouer";
            Rejouer.Size = new Size(113, 39);
            Rejouer.TabIndex = 3;
            Rejouer.Text = "REJOUER";
            Rejouer.UseVisualStyleBackColor = true;
            Rejouer.Click += Rejouer_Click;
            // 
            // Accueil
            // 
            Accueil.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Accueil.Location = new Point(304, 407);
            Accueil.Name = "Accueil";
            Accueil.Size = new Size(113, 39);
            Accueil.TabIndex = 4;
            Accueil.Text = "ACCUEIL";
            Accueil.UseVisualStyleBackColor = true;
            Accueil.Click += Accueil_Click;
            // 
            // Quitter
            // 
            Quitter.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Quitter.Location = new Point(471, 407);
            Quitter.Name = "Quitter";
            Quitter.Size = new Size(113, 39);
            Quitter.TabIndex = 5;
            Quitter.Text = "QUITTER";
            Quitter.UseVisualStyleBackColor = true;
            Quitter.Click += Quitter_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(251, 281);
            label4.Name = "label4";
            label4.Size = new Size(125, 37);
            label4.TabIndex = 6;
            label4.Text = "Score :";
            // 
            // Fin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Pink;
            ClientSize = new Size(737, 543);
            Controls.Add(label4);
            Controls.Add(Quitter);
            Controls.Add(Accueil);
            Controls.Add(Rejouer);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Fin";
            Text = "Fin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button Rejouer;
        private Button Accueil;
        private Button Quitter;
        private Label label4;
    }
}