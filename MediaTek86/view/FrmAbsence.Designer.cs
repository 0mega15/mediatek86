namespace MediaTek86.view
{
    partial class FrmAbsence
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
            this.grbAbsence = new System.Windows.Forms.GroupBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnSupprAbsence = new System.Windows.Forms.Button();
            this.btnModifAbcense = new System.Windows.Forms.Button();
            this.dgvAbsence = new System.Windows.Forms.DataGridView();
            this.grbAddAbsence = new System.Windows.Forms.GroupBox();
            this.labelDateDebut = new System.Windows.Forms.Label();
            this.labelDateFin = new System.Windows.Forms.Label();
            this.labelMotif = new System.Windows.Forms.Label();
            this.btnSaveAbsence = new System.Windows.Forms.Button();
            this.btnCancelAbsence = new System.Windows.Forms.Button();
            this.dateTimePickerDebut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.cboMotif = new System.Windows.Forms.ComboBox();
            this.grbAbsence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).BeginInit();
            this.grbAddAbsence.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAbsence
            // 
            this.grbAbsence.Controls.Add(this.btnQuitter);
            this.grbAbsence.Controls.Add(this.btnSupprAbsence);
            this.grbAbsence.Controls.Add(this.btnModifAbcense);
            this.grbAbsence.Controls.Add(this.dgvAbsence);
            this.grbAbsence.Location = new System.Drawing.Point(12, 13);
            this.grbAbsence.Name = "grbAbsence";
            this.grbAbsence.Size = new System.Drawing.Size(776, 319);
            this.grbAbsence.TabIndex = 0;
            this.grbAbsence.TabStop = false;
            this.grbAbsence.Text = "Absence";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(678, 287);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(92, 26);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // btnSupprAbsence
            // 
            this.btnSupprAbsence.Location = new System.Drawing.Point(104, 287);
            this.btnSupprAbsence.Name = "btnSupprAbsence";
            this.btnSupprAbsence.Size = new System.Drawing.Size(92, 26);
            this.btnSupprAbsence.TabIndex = 2;
            this.btnSupprAbsence.Text = "supprimer";
            this.btnSupprAbsence.UseVisualStyleBackColor = true;
            // 
            // btnModifAbcense
            // 
            this.btnModifAbcense.Location = new System.Drawing.Point(6, 287);
            this.btnModifAbcense.Name = "btnModifAbcense";
            this.btnModifAbcense.Size = new System.Drawing.Size(92, 26);
            this.btnModifAbcense.TabIndex = 1;
            this.btnModifAbcense.Text = "modifier";
            this.btnModifAbcense.UseVisualStyleBackColor = true;
            // 
            // dgvAbsence
            // 
            this.dgvAbsence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsence.Location = new System.Drawing.Point(6, 21);
            this.dgvAbsence.Name = "dgvAbsence";
            this.dgvAbsence.RowHeadersWidth = 51;
            this.dgvAbsence.RowTemplate.Height = 24;
            this.dgvAbsence.Size = new System.Drawing.Size(764, 245);
            this.dgvAbsence.TabIndex = 0;
            // 
            // grbAddAbsence
            // 
            this.grbAddAbsence.Controls.Add(this.cboMotif);
            this.grbAddAbsence.Controls.Add(this.dateTimePickerFin);
            this.grbAddAbsence.Controls.Add(this.dateTimePickerDebut);
            this.grbAddAbsence.Controls.Add(this.btnCancelAbsence);
            this.grbAddAbsence.Controls.Add(this.btnSaveAbsence);
            this.grbAddAbsence.Controls.Add(this.labelMotif);
            this.grbAddAbsence.Controls.Add(this.labelDateFin);
            this.grbAddAbsence.Controls.Add(this.labelDateDebut);
            this.grbAddAbsence.Location = new System.Drawing.Point(12, 338);
            this.grbAddAbsence.Name = "grbAddAbsence";
            this.grbAddAbsence.Size = new System.Drawing.Size(776, 188);
            this.grbAddAbsence.TabIndex = 1;
            this.grbAddAbsence.TabStop = false;
            this.grbAddAbsence.Text = "Ajouter une absence";
            // 
            // labelDateDebut
            // 
            this.labelDateDebut.AutoSize = true;
            this.labelDateDebut.Location = new System.Drawing.Point(3, 36);
            this.labelDateDebut.Name = "labelDateDebut";
            this.labelDateDebut.Size = new System.Drawing.Size(71, 16);
            this.labelDateDebut.TabIndex = 0;
            this.labelDateDebut.Text = "date debut";
            // 
            // labelDateFin
            // 
            this.labelDateFin.AutoSize = true;
            this.labelDateFin.Location = new System.Drawing.Point(3, 72);
            this.labelDateFin.Name = "labelDateFin";
            this.labelDateFin.Size = new System.Drawing.Size(50, 16);
            this.labelDateFin.TabIndex = 1;
            this.labelDateFin.Text = "date fin";
            // 
            // labelMotif
            // 
            this.labelMotif.AutoSize = true;
            this.labelMotif.Location = new System.Drawing.Point(3, 108);
            this.labelMotif.Name = "labelMotif";
            this.labelMotif.Size = new System.Drawing.Size(35, 16);
            this.labelMotif.TabIndex = 2;
            this.labelMotif.Text = "motif";
            // 
            // btnSaveAbsence
            // 
            this.btnSaveAbsence.Location = new System.Drawing.Point(6, 157);
            this.btnSaveAbsence.Name = "btnSaveAbsence";
            this.btnSaveAbsence.Size = new System.Drawing.Size(92, 25);
            this.btnSaveAbsence.TabIndex = 11;
            this.btnSaveAbsence.Text = "Enregistrer";
            this.btnSaveAbsence.UseVisualStyleBackColor = true;
            // 
            // btnCancelAbsence
            // 
            this.btnCancelAbsence.Location = new System.Drawing.Point(104, 157);
            this.btnCancelAbsence.Name = "btnCancelAbsence";
            this.btnCancelAbsence.Size = new System.Drawing.Size(92, 25);
            this.btnCancelAbsence.TabIndex = 12;
            this.btnCancelAbsence.Text = "annuler";
            this.btnCancelAbsence.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDebut
            // 
            this.dateTimePickerDebut.Location = new System.Drawing.Point(104, 31);
            this.dateTimePickerDebut.Name = "dateTimePickerDebut";
            this.dateTimePickerDebut.Size = new System.Drawing.Size(232, 22);
            this.dateTimePickerDebut.TabIndex = 13;
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.Location = new System.Drawing.Point(104, 67);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(232, 22);
            this.dateTimePickerFin.TabIndex = 14;
            // 
            // cboMotif
            // 
            this.cboMotif.FormattingEnabled = true;
            this.cboMotif.Location = new System.Drawing.Point(104, 105);
            this.cboMotif.Name = "cboMotif";
            this.cboMotif.Size = new System.Drawing.Size(232, 24);
            this.cboMotif.TabIndex = 15;
            // 
            // FrmAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.grbAddAbsence);
            this.Controls.Add(this.grbAbsence);
            this.Name = "FrmAbsence";
            this.Text = "FrmAbsence";
            this.grbAbsence.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).EndInit();
            this.grbAddAbsence.ResumeLayout(false);
            this.grbAddAbsence.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAbsence;
        private System.Windows.Forms.GroupBox grbAddAbsence;
        private System.Windows.Forms.DataGridView dgvAbsence;
        private System.Windows.Forms.Button btnModifAbcense;
        private System.Windows.Forms.Button btnSupprAbsence;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label labelDateDebut;
        private System.Windows.Forms.Label labelMotif;
        private System.Windows.Forms.Label labelDateFin;
        private System.Windows.Forms.Button btnSaveAbsence;
        private System.Windows.Forms.ComboBox cboMotif;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerDebut;
        private System.Windows.Forms.Button btnCancelAbsence;
    }
}