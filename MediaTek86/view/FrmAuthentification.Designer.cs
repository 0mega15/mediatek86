namespace MediaTek86.view
{
    partial class FrmAuthentification
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
            this.labelUtilisateur = new System.Windows.Forms.Label();
            this.labelPwd = new System.Windows.Forms.Label();
            this.textBoxUtilisateur = new System.Windows.Forms.TextBox();
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUtilisateur
            // 
            this.labelUtilisateur.AutoSize = true;
            this.labelUtilisateur.Location = new System.Drawing.Point(12, 34);
            this.labelUtilisateur.Name = "labelUtilisateur";
            this.labelUtilisateur.Size = new System.Drawing.Size(63, 16);
            this.labelUtilisateur.TabIndex = 0;
            this.labelUtilisateur.Text = "utilisateur";
            // 
            // labelPwd
            // 
            this.labelPwd.AutoSize = true;
            this.labelPwd.Location = new System.Drawing.Point(12, 69);
            this.labelPwd.Name = "labelPwd";
            this.labelPwd.Size = new System.Drawing.Size(89, 16);
            this.labelPwd.TabIndex = 1;
            this.labelPwd.Text = "mot de passe";
            // 
            // textBoxUtilisateur
            // 
            this.textBoxUtilisateur.Location = new System.Drawing.Point(138, 31);
            this.textBoxUtilisateur.Name = "textBoxUtilisateur";
            this.textBoxUtilisateur.Size = new System.Drawing.Size(209, 22);
            this.textBoxUtilisateur.TabIndex = 2;
            this.textBoxUtilisateur.Text = "admin";
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.Location = new System.Drawing.Point(138, 66);
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.PasswordChar = '*';
            this.textBoxPwd.Size = new System.Drawing.Size(209, 22);
            this.textBoxPwd.TabIndex = 3;
            this.textBoxPwd.Text = "5nhFz2jYuXxB";
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(239, 106);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(108, 23);
            this.btnConnexion.TabIndex = 4;
            this.btnConnexion.Text = "connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // FrmAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 141);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.textBoxPwd);
            this.Controls.Add(this.textBoxUtilisateur);
            this.Controls.Add(this.labelPwd);
            this.Controls.Add(this.labelUtilisateur);
            this.Name = "FrmAuthentification";
            this.Text = "Authentification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUtilisateur;
        private System.Windows.Forms.Label labelPwd;
        private System.Windows.Forms.TextBox textBoxUtilisateur;
        private System.Windows.Forms.TextBox textBoxPwd;
        private System.Windows.Forms.Button btnConnexion;
    }
}