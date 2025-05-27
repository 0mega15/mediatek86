using MediaTek86.controller;
using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86.view
{
    /// <summary>
    /// Formulaire de gestion du personnel.
    /// </summary>
    public partial class FrmPersonnel : Form
    {
        private Boolean enCoursModifPersonnel = false;

        private Boolean enCoursModifAbsence = false;

        private BindingSource bdgPersonnel = new BindingSource();

        private BindingSource bdgService = new BindingSource();

        private BindingSource bdgAbsence = new BindingSource();

        private BindingSource bdgMotif = new BindingSource();

        private FrmPersonnelController controller;
        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="FrmPersonnel"/>.
        /// </summary>
        public FrmPersonnel()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            controller = new FrmPersonnelController();
            RemplirListePersonnel();
            if (dgvPersonnel.Rows.Count > 0)
            {
                dgvPersonnel.Rows[0].Selected = true;
            }
            bdgPersonnel.CurrentChanged += bdgPersonnel_CurrentChanged;
            RemplirListeService();
            RemplirListeAbsence();
            RemplirListeMotif();
            EnCoursModifPersonnel(false);
            EnCoursModifAbsence(false);
        }

        private void bdgPersonnel_CurrentChanged(object sender, EventArgs e)
        {
            RemplirListeAbsence();
        }

        private void RemplirListePersonnel()
        {
            List<Personnel> lesPersonnels = controller.GetLesPersonnels();
            bdgPersonnel.DataSource = lesPersonnels;
            dgvPersonnel.DataSource = bdgPersonnel;
            dgvPersonnel.Columns["Idpersonnel"].Visible = false;
            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void RemplirListeService()
        {
            List<Service> lesServices = controller.GetLesServices();
            bdgService.DataSource = lesServices;
            cboService.DataSource = bdgService;
        }

        private void RemplirListeAbsence()
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                var personnel = bdgPersonnel.Current as Personnel;
                if (personnel != null)
                {
                    int idPersonnel = personnel.Idpersonnel;
                    List<Absence> lesAbsence = controller.GetLesAbsences(idPersonnel);
                    bdgAbsence.DataSource = lesAbsence;
                    dgvAbsence.DataSource = bdgAbsence;
                    dgvAbsence.Columns["Personnel"].Visible = false;
                    dgvAbsence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
        }

        private void RemplirListeMotif()
        {
            List<Motif> lesMotifs = controller.GetLesMotifs();
            bdgMotif.DataSource = lesMotifs;
            cboMotif.DataSource = bdgMotif;
        }

        private void btnModifPersonnel_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                EnCoursModifPersonnel(true);
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                textBoxNom.Text = personnel.Nom;
                textBoxPrenom.Text = personnel.Prenom;
                textBoxMail.Text = personnel.Mail;
                textBoxTelephone.Text = personnel.Tel;
                cboService.SelectedIndex = cboService.FindStringExact(personnel.Service.Nom);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un personnel à modifier.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSupprPersonnel_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer ce personnel ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Personnel personnel = (Personnel)bdgPersonnel.Current;
                    controller.DelPersonnel(personnel);
                    RemplirListePersonnel();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un personnel à supprimer.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSavePersonnel_Click(object sender, EventArgs e)
        {
            if (!textBoxNom.Text.Equals(string.Empty) &&
                !textBoxPrenom.Text.Equals(string.Empty) &&
                !textBoxMail.Text.Equals(string.Empty) &&
                !textBoxTelephone.Text.Equals(string.Empty) &&
                cboService.SelectedItem != null)
            {
                Service service = (Service)bdgService.List[bdgService.Position];
                if (enCoursModifPersonnel)
                {
                    Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                    personnel.Nom = textBoxNom.Text;
                    personnel.Prenom = textBoxPrenom.Text;
                    personnel.Mail = textBoxMail.Text;
                    personnel.Tel = textBoxTelephone.Text;
                    personnel.Service = service;
                    controller.UpdPersonnel(personnel);
                }
                else
                {
                    Personnel personnel = new Personnel(0, textBoxNom.Text, textBoxPrenom.Text, textBoxMail.Text, textBoxTelephone.Text, service);
                    controller.AddPersonnel(personnel);
                }
                RemplirListePersonnel();
                EnCoursModifPersonnel(false);
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelPersonnel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCoursModifPersonnel(false);
            }
        }

        private void EnCoursModifPersonnel(Boolean modif)
        {
            enCoursModifPersonnel = modif;
            grbPersonnel.Enabled = !modif;
            grbAbcense.Enabled = !modif;
            grbAddAbsence.Enabled = !modif;
            if (modif)
            {
                grbAddPersonnel.Text = "Modifier un personnel";
            }
            else
            {
                grbAddPersonnel.Text = "Ajouter un personnel";
                textBoxNom.Text = string.Empty;
                textBoxPrenom.Text = string.Empty;
                textBoxMail.Text = string.Empty;
                textBoxTelephone.Text = string.Empty;
                cboService.SelectedIndex = -1;
            }
        }

        private void EnCoursModifAbsence(Boolean modif)
        {
            enCoursModifAbsence = modif;
            grbPersonnel.Enabled = !modif;
            grbAddPersonnel.Enabled = !modif;
            if (modif)
            {
                grbAddAbsence.Text = "Modifier une absence";
            }
            else
            {
                grbAddAbsence.Text = "Ajouter une absence";
                dateTimePickerDDebut.Value = DateTime.Now;
                dateTimePickerDFin.Value = DateTime.Now;
                cboMotif.SelectedIndex = -1;
            }

        }

        private void btnModifAbsence_Click(object sender, EventArgs e)
        {
            if (dgvAbsence.SelectedRows.Count > 0)
            {
                EnCoursModifAbsence(true);
                Absence absence = (Absence)bdgAbsence.List[bdgAbsence.Position];
                dateTimePickerDDebut.Value = absence.Date_debut;
                dateTimePickerDFin.Value = absence.Date_fin;
                cboMotif.SelectedIndex = cboMotif.FindStringExact(absence.Motif.Nom);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une absence à modifier.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSupprAbsence_Click(object sender, EventArgs e)
        {
            if (dgvAbsence.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer cette absence ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Absence absence = (Absence)bdgAbsence.Current;
                    controller.DelAbsence(absence);
                    RemplirListeAbsence();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une absence à supprimer.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSaveAbsence_Click(object sender, EventArgs e)
        {
            if (cboMotif.SelectedItem == null || dateTimePickerDDebut.Value >= dateTimePickerDFin.Value)
            {
                MessageBox.Show("Veuillez sélectionner un motif et vérifier les dates.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Motif motif = (Motif)cboMotif.SelectedItem;
            Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
            if (enCoursModifAbsence)
            {
                Absence absence = (Absence)bdgAbsence.List[bdgAbsence.Position];
                absence.Personnel = personnel;
                absence.Date_debut = dateTimePickerDDebut.Value;
                absence.Date_fin = dateTimePickerDFin.Value;
                absence.Motif = motif;
                controller.UpdAbsence(absence);
            }
            else
            {
                Absence absence = new Absence(personnel, dateTimePickerDDebut.Value, dateTimePickerDFin.Value ,motif);
                controller.AddAbsence(absence);
            }
            RemplirListeAbsence();
            EnCoursModifAbsence(false);
        }

        private void btnCancelAbsence_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCoursModifAbsence(false);
            }
        }
        
    }
}
