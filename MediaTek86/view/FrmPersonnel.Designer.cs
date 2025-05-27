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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbPersonnel = new System.Windows.Forms.GroupBox();
            this.btnSupprPersonnel = new System.Windows.Forms.Button();
            this.btnModifPersonnel = new System.Windows.Forms.Button();
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.grbAddPersonnel = new System.Windows.Forms.GroupBox();
            this.btnCancelPersonnel = new System.Windows.Forms.Button();
            this.btnSavePersonnel = new System.Windows.Forms.Button();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.labelService = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelTel = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.grbAbcense = new System.Windows.Forms.GroupBox();
            this.grbAddAbsence = new System.Windows.Forms.GroupBox();
            this.labelDDebut = new System.Windows.Forms.Label();
            this.dgvAbsence = new System.Windows.Forms.DataGridView();
            this.labelDFin = new System.Windows.Forms.Label();
            this.labelMotif = new System.Windows.Forms.Label();
            this.dateTimePickerDDebut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDFin = new System.Windows.Forms.DateTimePicker();
            this.cboMotif = new System.Windows.Forms.ComboBox();
            this.btnModifAbsence = new System.Windows.Forms.Button();
            this.btnSupprAbsence = new System.Windows.Forms.Button();
            this.btnSaveAbsence = new System.Windows.Forms.Button();
            this.btnCancelAbsence = new System.Windows.Forms.Button();
            this.grbPersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.grbAddPersonnel.SuspendLayout();
            this.grbAbcense.SuspendLayout();
            this.grbAddAbsence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPersonnel
            // 
            this.grbPersonnel.Controls.Add(this.btnSupprPersonnel);
            this.grbPersonnel.Controls.Add(this.btnModifPersonnel);
            this.grbPersonnel.Controls.Add(this.dgvPersonnel);
            this.grbPersonnel.Location = new System.Drawing.Point(12, 12);
            this.grbPersonnel.Name = "grbPersonnel";
            this.grbPersonnel.Size = new System.Drawing.Size(683, 319);
            this.grbPersonnel.TabIndex = 0;
            this.grbPersonnel.TabStop = false;
            this.grbPersonnel.Text = "Personnel";
            // 
            // btnSupprPersonnel
            // 
            this.btnSupprPersonnel.Location = new System.Drawing.Point(107, 287);
            this.btnSupprPersonnel.Name = "btnSupprPersonnel";
            this.btnSupprPersonnel.Size = new System.Drawing.Size(96, 26);
            this.btnSupprPersonnel.TabIndex = 2;
            this.btnSupprPersonnel.Text = "supprimer";
            this.btnSupprPersonnel.UseVisualStyleBackColor = true;
            this.btnSupprPersonnel.Click += new System.EventHandler(this.btnSupprPersonnel_Click);
            // 
            // btnModifPersonnel
            // 
            this.btnModifPersonnel.Location = new System.Drawing.Point(6, 287);
            this.btnModifPersonnel.Name = "btnModifPersonnel";
            this.btnModifPersonnel.Size = new System.Drawing.Size(92, 26);
            this.btnModifPersonnel.TabIndex = 1;
            this.btnModifPersonnel.Text = "modifier";
            this.btnModifPersonnel.UseVisualStyleBackColor = true;
            this.btnModifPersonnel.Click += new System.EventHandler(this.btnModifPersonnel_Click);
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.AllowUserToAddRows = false;
            this.dgvPersonnel.AllowUserToDeleteRows = false;
            this.dgvPersonnel.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonnel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPersonnel.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPersonnel.Location = new System.Drawing.Point(6, 21);
            this.dgvPersonnel.MultiSelect = false;
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonnel.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPersonnel.RowHeadersVisible = false;
            this.dgvPersonnel.RowHeadersWidth = 51;
            this.dgvPersonnel.RowTemplate.Height = 24;
            this.dgvPersonnel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonnel.Size = new System.Drawing.Size(671, 245);
            this.dgvPersonnel.TabIndex = 0;
            // 
            // grbAddPersonnel
            // 
            this.grbAddPersonnel.Controls.Add(this.btnCancelPersonnel);
            this.grbAddPersonnel.Controls.Add(this.btnSavePersonnel);
            this.grbAddPersonnel.Controls.Add(this.cboService);
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
            this.grbAddPersonnel.Size = new System.Drawing.Size(683, 179);
            this.grbAddPersonnel.TabIndex = 1;
            this.grbAddPersonnel.TabStop = false;
            this.grbAddPersonnel.Text = "Ajouter un personnel";
            // 
            // btnCancelPersonnel
            // 
            this.btnCancelPersonnel.Location = new System.Drawing.Point(107, 148);
            this.btnCancelPersonnel.Name = "btnCancelPersonnel";
            this.btnCancelPersonnel.Size = new System.Drawing.Size(96, 25);
            this.btnCancelPersonnel.TabIndex = 11;
            this.btnCancelPersonnel.Text = "annuler";
            this.btnCancelPersonnel.UseVisualStyleBackColor = true;
            this.btnCancelPersonnel.Click += new System.EventHandler(this.btnCancelPersonnel_Click);
            // 
            // btnSavePersonnel
            // 
            this.btnSavePersonnel.Location = new System.Drawing.Point(6, 148);
            this.btnSavePersonnel.Name = "btnSavePersonnel";
            this.btnSavePersonnel.Size = new System.Drawing.Size(92, 25);
            this.btnSavePersonnel.TabIndex = 10;
            this.btnSavePersonnel.Text = "enregistrer";
            this.btnSavePersonnel.UseVisualStyleBackColor = true;
            this.btnSavePersonnel.Click += new System.EventHandler(this.btnSavePersonnel_Click);
            // 
            // cboService
            // 
            this.cboService.FormattingEnabled = true;
            this.cboService.Location = new System.Drawing.Point(444, 69);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(210, 24);
            this.cboService.TabIndex = 9;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(444, 30);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(210, 22);
            this.textBoxMail.TabIndex = 8;
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Location = new System.Drawing.Point(371, 72);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(51, 16);
            this.labelService.TabIndex = 7;
            this.labelService.Text = "service";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(371, 33);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(32, 16);
            this.labelMail.TabIndex = 6;
            this.labelMail.Text = "mail";
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Location = new System.Drawing.Point(76, 105);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(208, 22);
            this.textBoxTelephone.TabIndex = 5;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(76, 69);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(208, 22);
            this.textBoxPrenom.TabIndex = 4;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(76, 33);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(208, 22);
            this.textBoxNom.TabIndex = 3;
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(3, 108);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(67, 16);
            this.labelTel.TabIndex = 2;
            this.labelTel.Text = "téléphone";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(3, 72);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(53, 16);
            this.labelPrenom.TabIndex = 1;
            this.labelPrenom.Text = "prénom";
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
            // grbAbcense
            // 
            this.grbAbcense.Controls.Add(this.btnSupprAbsence);
            this.grbAbcense.Controls.Add(this.btnModifAbsence);
            this.grbAbcense.Controls.Add(this.dgvAbsence);
            this.grbAbcense.Location = new System.Drawing.Point(701, 12);
            this.grbAbcense.Name = "grbAbcense";
            this.grbAbcense.Size = new System.Drawing.Size(411, 319);
            this.grbAbcense.TabIndex = 2;
            this.grbAbcense.TabStop = false;
            this.grbAbcense.Text = "Absence";
            // 
            // grbAddAbsence
            // 
            this.grbAddAbsence.Controls.Add(this.btnCancelAbsence);
            this.grbAddAbsence.Controls.Add(this.btnSaveAbsence);
            this.grbAddAbsence.Controls.Add(this.cboMotif);
            this.grbAddAbsence.Controls.Add(this.dateTimePickerDFin);
            this.grbAddAbsence.Controls.Add(this.dateTimePickerDDebut);
            this.grbAddAbsence.Controls.Add(this.labelMotif);
            this.grbAddAbsence.Controls.Add(this.labelDFin);
            this.grbAddAbsence.Controls.Add(this.labelDDebut);
            this.grbAddAbsence.Location = new System.Drawing.Point(701, 337);
            this.grbAddAbsence.Name = "grbAddAbsence";
            this.grbAddAbsence.Size = new System.Drawing.Size(411, 179);
            this.grbAddAbsence.TabIndex = 3;
            this.grbAddAbsence.TabStop = false;
            this.grbAddAbsence.Text = "Ajouter une absence";
            // 
            // labelDDebut
            // 
            this.labelDDebut.AutoSize = true;
            this.labelDDebut.Location = new System.Drawing.Point(6, 33);
            this.labelDDebut.Name = "labelDDebut";
            this.labelDDebut.Size = new System.Drawing.Size(90, 16);
            this.labelDDebut.TabIndex = 0;
            this.labelDDebut.Text = "date de debut";
            // 
            // dgvAbsence
            // 
            this.dgvAbsence.AllowUserToAddRows = false;
            this.dgvAbsence.AllowUserToDeleteRows = false;
            this.dgvAbsence.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAbsence.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAbsence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAbsence.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAbsence.Location = new System.Drawing.Point(6, 21);
            this.dgvAbsence.MultiSelect = false;
            this.dgvAbsence.Name = "dgvAbsence";
            this.dgvAbsence.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAbsence.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAbsence.RowHeadersVisible = false;
            this.dgvAbsence.RowHeadersWidth = 51;
            this.dgvAbsence.RowTemplate.Height = 24;
            this.dgvAbsence.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbsence.Size = new System.Drawing.Size(399, 245);
            this.dgvAbsence.TabIndex = 0;
            // 
            // labelDFin
            // 
            this.labelDFin.AutoSize = true;
            this.labelDFin.Location = new System.Drawing.Point(6, 72);
            this.labelDFin.Name = "labelDFin";
            this.labelDFin.Size = new System.Drawing.Size(69, 16);
            this.labelDFin.TabIndex = 1;
            this.labelDFin.Text = "date de fin";
            // 
            // labelMotif
            // 
            this.labelMotif.AutoSize = true;
            this.labelMotif.Location = new System.Drawing.Point(6, 108);
            this.labelMotif.Name = "labelMotif";
            this.labelMotif.Size = new System.Drawing.Size(35, 16);
            this.labelMotif.TabIndex = 2;
            this.labelMotif.Text = "motif";
            // 
            // dateTimePickerDDebut
            // 
            this.dateTimePickerDDebut.Location = new System.Drawing.Point(124, 28);
            this.dateTimePickerDDebut.Name = "dateTimePickerDDebut";
            this.dateTimePickerDDebut.Size = new System.Drawing.Size(217, 22);
            this.dateTimePickerDDebut.TabIndex = 3;
            // 
            // dateTimePickerDFin
            // 
            this.dateTimePickerDFin.Location = new System.Drawing.Point(124, 67);
            this.dateTimePickerDFin.Name = "dateTimePickerDFin";
            this.dateTimePickerDFin.Size = new System.Drawing.Size(217, 22);
            this.dateTimePickerDFin.TabIndex = 4;
            // 
            // cboMotif
            // 
            this.cboMotif.FormattingEnabled = true;
            this.cboMotif.Location = new System.Drawing.Point(124, 103);
            this.cboMotif.Name = "cboMotif";
            this.cboMotif.Size = new System.Drawing.Size(217, 24);
            this.cboMotif.TabIndex = 5;
            // 
            // btnModifAbsence
            // 
            this.btnModifAbsence.Location = new System.Drawing.Point(6, 287);
            this.btnModifAbsence.Name = "btnModifAbsence";
            this.btnModifAbsence.Size = new System.Drawing.Size(90, 26);
            this.btnModifAbsence.TabIndex = 1;
            this.btnModifAbsence.Text = "modifier";
            this.btnModifAbsence.UseVisualStyleBackColor = true;
            this.btnModifAbsence.Click += new System.EventHandler(this.btnModifAbsence_Click);
            // 
            // btnSupprAbsence
            // 
            this.btnSupprAbsence.Location = new System.Drawing.Point(102, 287);
            this.btnSupprAbsence.Name = "btnSupprAbsence";
            this.btnSupprAbsence.Size = new System.Drawing.Size(90, 26);
            this.btnSupprAbsence.TabIndex = 2;
            this.btnSupprAbsence.Text = "supprimer";
            this.btnSupprAbsence.UseVisualStyleBackColor = true;
            this.btnSupprAbsence.Click += new System.EventHandler(this.btnSupprAbsence_Click);
            // 
            // btnSaveAbsence
            // 
            this.btnSaveAbsence.Location = new System.Drawing.Point(6, 147);
            this.btnSaveAbsence.Name = "btnSaveAbsence";
            this.btnSaveAbsence.Size = new System.Drawing.Size(90, 26);
            this.btnSaveAbsence.TabIndex = 6;
            this.btnSaveAbsence.Text = "enregistrer";
            this.btnSaveAbsence.UseVisualStyleBackColor = true;
            this.btnSaveAbsence.Click += new System.EventHandler(this.btnSaveAbsence_Click);
            // 
            // btnCancelAbsence
            // 
            this.btnCancelAbsence.Location = new System.Drawing.Point(102, 148);
            this.btnCancelAbsence.Name = "btnCancelAbsence";
            this.btnCancelAbsence.Size = new System.Drawing.Size(90, 26);
            this.btnCancelAbsence.TabIndex = 7;
            this.btnCancelAbsence.Text = "annuler";
            this.btnCancelAbsence.UseVisualStyleBackColor = true;
            this.btnCancelAbsence.Click += new System.EventHandler(this.btnCancelAbsence_Click);
            // 
            // FrmPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 537);
            this.Controls.Add(this.grbAddAbsence);
            this.Controls.Add(this.grbAbcense);
            this.Controls.Add(this.grbAddPersonnel);
            this.Controls.Add(this.grbPersonnel);
            this.Name = "FrmPersonnel";
            this.Text = "FrmPersonnel";
            this.grbPersonnel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.grbAddPersonnel.ResumeLayout(false);
            this.grbAddPersonnel.PerformLayout();
            this.grbAbcense.ResumeLayout(false);
            this.grbAddAbsence.ResumeLayout(false);
            this.grbAddAbsence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).EndInit();
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
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.Button btnCancelPersonnel;
        private System.Windows.Forms.GroupBox grbAbcense;
        private System.Windows.Forms.GroupBox grbAddAbsence;
        private System.Windows.Forms.DataGridView dgvAbsence;
        private System.Windows.Forms.Label labelDFin;
        private System.Windows.Forms.Label labelDDebut;
        private System.Windows.Forms.DateTimePicker dateTimePickerDDebut;
        private System.Windows.Forms.Label labelMotif;
        private System.Windows.Forms.ComboBox cboMotif;
        private System.Windows.Forms.DateTimePicker dateTimePickerDFin;
        private System.Windows.Forms.Button btnModifAbsence;
        private System.Windows.Forms.Button btnSupprAbsence;
        private System.Windows.Forms.Button btnCancelAbsence;
        private System.Windows.Forms.Button btnSaveAbsence;
    }
}