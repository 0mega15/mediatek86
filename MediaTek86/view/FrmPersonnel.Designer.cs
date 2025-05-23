namespace MediaTek86.view
{
    partial class FrmPersonnel
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
            this.grbPersonnel = new System.Windows.Forms.GroupBox();
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.btnModifPersonnel = new System.Windows.Forms.Button();
            this.btnSupprPersonnel = new System.Windows.Forms.Button();
            this.grbAddPersonnel = new System.Windows.Forms.GroupBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelService = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSavePersonnel = new System.Windows.Forms.Button();
            this.btnCancelPersonnel = new System.Windows.Forms.Button();
            this.btnAbsence = new System.Windows.Forms.Button();
            this.grbPersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.grbAddPersonnel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPersonnel
            // 
            this.grbPersonnel.Controls.Add(this.btnAbsence);
            this.grbPersonnel.Controls.Add(this.btnSupprPersonnel);
            this.grbPersonnel.Controls.Add(this.btnModifPersonnel);
            this.grbPersonnel.Controls.Add(this.dgvPersonnel);
            this.grbPersonnel.Location = new System.Drawing.Point(12, 12);
            this.grbPersonnel.Name = "grbPersonnel";
            this.grbPersonnel.Size = new System.Drawing.Size(776, 319);
            this.grbPersonnel.TabIndex = 0;
            this.grbPersonnel.TabStop = false;
            this.grbPersonnel.Text = "Personnel";
            this.grbPersonnel.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Location = new System.Drawing.Point(6, 21);
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.RowHeadersWidth = 51;
            this.dgvPersonnel.RowTemplate.Height = 24;
            this.dgvPersonnel.Size = new System.Drawing.Size(764, 245);
            this.dgvPersonnel.TabIndex = 0;
            // 
            // btnModifPersonnel
            // 
            this.btnModifPersonnel.Location = new System.Drawing.Point(6, 287);
            this.btnModifPersonnel.Name = "btnModifPersonnel";
            this.btnModifPersonnel.Size = new System.Drawing.Size(92, 26);
            this.btnModifPersonnel.TabIndex = 1;
            this.btnModifPersonnel.Text = "modifier";
            this.btnModifPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnSupprPersonnel
            // 
            this.btnSupprPersonnel.Location = new System.Drawing.Point(107, 287);
            this.btnSupprPersonnel.Name = "btnSupprPersonnel";
            this.btnSupprPersonnel.Size = new System.Drawing.Size(96, 26);
            this.btnSupprPersonnel.TabIndex = 2;
            this.btnSupprPersonnel.Text = "supprimer";
            this.btnSupprPersonnel.UseVisualStyleBackColor = true;
            // 
            // grbAddPersonnel
            // 
            this.grbAddPersonnel.Controls.Add(this.btnCancelPersonnel);
            this.grbAddPersonnel.Controls.Add(this.btnSavePersonnel);
            this.grbAddPersonnel.Controls.Add(this.comboBox1);
            this.grbAddPersonnel.Controls.Add(this.textBoxMail);
            this.grbAddPersonnel.Controls.Add(this.labelService);
            this.grbAddPersonnel.Controls.Add(this.labelMail);
            this.grbAddPersonnel.Controls.Add(this.textBoxTelephone);
            this.grbAddPersonnel.Controls.Add(this.textBoxPrenom);
            this.grbAddPersonnel.Controls.Add(this.textBoxNom);
            this.grbAddPersonnel.Controls.Add(this.labelTel);
            this.grbAddPersonnel.Controls.Add(this.labelPrenom);
            this.grbAddPersonnel.Controls.Add(this.labelNom);
            this.grbAddPersonnel.Location = new System.Drawing.Point(12, 337);
            this.grbAddPersonnel.Name = "grbAddPersonnel";
            this.grbAddPersonnel.Size = new System.Drawing.Size(775, 179);
            this.grbAddPersonnel.TabIndex = 1;
            this.grbAddPersonnel.TabStop = false;
            this.grbAddPersonnel.Text = "Ajouter un personnel";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(3, 36);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(33, 16);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "nom";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(3, 72);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(53, 16);
            this.labelPrenom.TabIndex = 1;
            this.labelPrenom.Text = "prenom";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(3, 108);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(67, 16);
            this.labelTel.TabIndex = 2;
            this.labelTel.Text = "telephone";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(107, 33);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(210, 22);
            this.textBoxNom.TabIndex = 3;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(107, 69);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(210, 22);
            this.textBoxPrenom.TabIndex = 4;
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Location = new System.Drawing.Point(107, 105);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(210, 22);
            this.textBoxTelephone.TabIndex = 5;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(415, 36);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(32, 16);
            this.labelMail.TabIndex = 6;
            this.labelMail.Text = "mail";
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Location = new System.Drawing.Point(415, 72);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(51, 16);
            this.labelService.TabIndex = 7;
            this.labelService.Text = "service";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(505, 33);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(210, 22);
            this.textBoxMail.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(505, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // btnSavePersonnel
            // 
            this.btnSavePersonnel.Location = new System.Drawing.Point(6, 148);
            this.btnSavePersonnel.Name = "btnSavePersonnel";
            this.btnSavePersonnel.Size = new System.Drawing.Size(92, 25);
            this.btnSavePersonnel.TabIndex = 10;
            this.btnSavePersonnel.Text = "enregistrer";
            this.btnSavePersonnel.UseVisualStyleBackColor = true;
            // 
            // btnCancelPersonnel
            // 
            this.btnCancelPersonnel.Location = new System.Drawing.Point(107, 148);
            this.btnCancelPersonnel.Name = "btnCancelPersonnel";
            this.btnCancelPersonnel.Size = new System.Drawing.Size(96, 25);
            this.btnCancelPersonnel.TabIndex = 11;
            this.btnCancelPersonnel.Text = "annuler";
            this.btnCancelPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnAbsence
            // 
            this.btnAbsence.Location = new System.Drawing.Point(674, 287);
            this.btnAbsence.Name = "btnAbsence";
            this.btnAbsence.Size = new System.Drawing.Size(96, 26);
            this.btnAbsence.TabIndex = 3;
            this.btnAbsence.Text = "absence";
            this.btnAbsence.UseVisualStyleBackColor = true;
            // 
            // FrmPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.grbAddPersonnel);
            this.Controls.Add(this.grbPersonnel);
            this.Name = "FrmPersonnel";
            this.Text = "FrmPersonnel";
            this.grbPersonnel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.grbAddPersonnel.ResumeLayout(false);
            this.grbAddPersonnel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPersonnel;
        private System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.Button btnSupprPersonnel;
        private System.Windows.Forms.Button btnModifPersonnel;
        private System.Windows.Forms.GroupBox grbAddPersonnel;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Button btnSavePersonnel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.Button btnCancelPersonnel;
        private System.Windows.Forms.Button btnAbsence;
    }
}