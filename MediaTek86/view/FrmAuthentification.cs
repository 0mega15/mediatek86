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
    public partial class FrmAuthentification : Form
    {
        private FrmAuthentificationController controller;

        public FrmAuthentification()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            controller = new controller.FrmAuthentificationController();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            String login = textBoxUtilisateur.Text;
            String pwd = textBoxPwd.Text;
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Admin admin = new model.Admin(login, pwd);
                if (controller.ControleAuthentification(admin))
                {
                    FrmPersonnel frmPersonnel = new FrmPersonnel();
                    frmPersonnel.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Identifiant ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
