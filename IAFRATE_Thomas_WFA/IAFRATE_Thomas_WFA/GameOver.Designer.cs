namespace IAFRATE_Thomas_WFA
{
    partial class GameOver
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
            Quitter = new Button();
            Accueil = new Button();
            Rejouer = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Chiller", 70F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(198, 161);
            label1.Name = "label1";
            label1.Size = new Size(346, 109);
            label1.TabIndex = 0;
            label1.Text = "Game Over";
            // 
            // Quitter
            // 
            Quitter.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Quitter.Location = new Point(471, 349);
            Quitter.Name = "Quitter";
            Quitter.Size = new Size(113, 39);
            Quitter.TabIndex = 8;
            Quitter.Text = "QUITTER";
            Quitter.UseVisualStyleBackColor = true;
            Quitter.Click += Quitter_Click;
            // 
            // Accueil
            // 
            Accueil.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Accueil.Location = new Point(304, 349);
            Accueil.Name = "Accueil";
            Accueil.Size = new Size(113, 39);
            Accueil.TabIndex = 7;
            Accueil.Text = "ACCUEIL";
            Accueil.UseVisualStyleBackColor = true;
            Accueil.Click += Accueil_Click;
            // 
            // Rejouer
            // 
            Rejouer.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Rejouer.Location = new Point(140, 349);
            Rejouer.Name = "Rejouer";
            Rejouer.Size = new Size(113, 39);
            Rejouer.TabIndex = 6;
            Rejouer.Text = "REJOUER";
            Rejouer.UseVisualStyleBackColor = true;
            Rejouer.Click += Rejouer_Click;
            // 
            // GameOver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Brown;
            ClientSize = new Size(737, 543);
            Controls.Add(Quitter);
            Controls.Add(Accueil);
            Controls.Add(Rejouer);
            Controls.Add(label1);
            Name = "GameOver";
            Text = "GameOver";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Quitter;
        private Button Accueil;
        private Button Rejouer;
    }
}