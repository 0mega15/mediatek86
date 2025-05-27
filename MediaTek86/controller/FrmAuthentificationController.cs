using MediaTek86.dal;
using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.controller
{
    internal class FrmAuthentificationController
    {
        private readonly PersonnelAccess personnelAccess;

        public FrmAuthentificationController()
        {
            personnelAccess = new PersonnelAccess();
        }

        public Boolean ControleAuthentification(Admin admin)
        {
            return personnelAccess.ControleAuthentification(admin);
        }
    }
}
