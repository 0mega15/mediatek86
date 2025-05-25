using MediaTek86.dal;
using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.controller
{
    internal class FrmPersonnelController
    {
        private readonly PersonnelAccess personnelAccess;

        private readonly ServiceAccess serviceAccess;


        public FrmPersonnelController()
        {
            personnelAccess = new PersonnelAccess();
            serviceAccess = new ServiceAccess();
        }
        public List<Personnel> GetLesPersonnels()
        {
            return personnelAccess.GetLesPersonnels();
        }

        public List<Service> GetLesServices()
        {
            return serviceAccess.GetLesServices();
        }

        public void DelPersonnel(Personnel personnel)
        {
            personnelAccess.DelPersonnel(personnel);
        }

        public void UpdPersonnel(Personnel personnel)
        {
            personnelAccess.UpdPersonnel(personnel);
        }

        public void AddPersonnel(Personnel personnel)
        {
            personnelAccess.AddPersonnel(personnel);
        }
    }
}
