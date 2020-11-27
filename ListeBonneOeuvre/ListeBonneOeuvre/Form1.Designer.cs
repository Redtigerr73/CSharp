namespace ListeBonneOeuvre
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelCombienDonner = new System.Windows.Forms.Label();
            this.labelCommentaire = new System.Windows.Forms.Label();
            this.button1Confirmer = new System.Windows.Forms.Button();
            this.label1Confirmation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.OrangeRed;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "10",
            "100",
            "1000"});
            this.comboBox1.Location = new System.Drawing.Point(322, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.labelCommentaire_Click);
            // 
            // labelCombienDonner
            // 
            this.labelCombienDonner.AutoSize = true;
            this.labelCombienDonner.Location = new System.Drawing.Point(212, 96);
            this.labelCombienDonner.Name = "labelCombienDonner";
            this.labelCombienDonner.Size = new System.Drawing.Size(90, 13);
            this.labelCombienDonner.TabIndex = 1;
            this.labelCombienDonner.Text = "Combien donner?";
            // 
            // labelCommentaire
            // 
            this.labelCommentaire.AutoSize = true;
            this.labelCommentaire.Location = new System.Drawing.Point(484, 96);
            this.labelCommentaire.Name = "labelCommentaire";
            this.labelCommentaire.Size = new System.Drawing.Size(68, 13);
            this.labelCommentaire.TabIndex = 3;
            this.labelCommentaire.Text = "Commentaire";
            this.labelCommentaire.Click += new System.EventHandler(this.labelCommentaire_Click);
            // 
            // button1Confirmer
            // 
            this.button1Confirmer.Location = new System.Drawing.Point(342, 155);
            this.button1Confirmer.Name = "button1Confirmer";
            this.button1Confirmer.Size = new System.Drawing.Size(75, 23);
            this.button1Confirmer.TabIndex = 4;
            this.button1Confirmer.Text = "Confirmer";
            this.button1Confirmer.UseVisualStyleBackColor = true;
            this.button1Confirmer.Click += new System.EventHandler(this.button1Confirmer_Click);
            // 
            // label1Confirmation
            // 
            this.label1Confirmation.AutoSize = true;
            this.label1Confirmation.Location = new System.Drawing.Point(484, 160);
            this.label1Confirmation.Name = "label1Confirmation";
            this.label1Confirmation.Size = new System.Drawing.Size(91, 13);
            this.label1Confirmation.TabIndex = 5;
            this.label1Confirmation.Text = "MerciConfirmation";
            this.label1Confirmation.Click += new System.EventHandler(this.label1Confirmation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1Confirmation);
            this.Controls.Add(this.button1Confirmer);
            this.Controls.Add(this.labelCommentaire);
            this.Controls.Add(this.labelCombienDonner);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelCombienDonner;
        private System.Windows.Forms.Label labelCommentaire;
        private System.Windows.Forms.Button button1Confirmer;
        private System.Windows.Forms.Label label1Confirmation;
    }
}

