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

        private BindingSource bdgPersonnel = new BindingSource();

        private BindingSource bdgService = new BindingSource();

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
            RemplirListeService();
            EnCoursModifPersonnel(false);
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


        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
            enCoursModifPersonnel = true;
            grbPersonnel.Enabled = !modif;
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
            }
        }
    }
}
