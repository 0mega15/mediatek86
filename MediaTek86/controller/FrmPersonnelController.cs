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

        private readonly AbsenceAccess absenceAccess;

        private readonly MotifAccess motifAccess;


        public FrmPersonnelController()
        {
            personnelAccess = new PersonnelAccess();
            serviceAccess = new ServiceAccess();
            absenceAccess = new AbsenceAccess();
            motifAccess = new MotifAccess();
        }
        public List<Personnel> GetLesPersonnels()
        {
            return personnelAccess.GetLesPersonnels();
        }

        public List<Service> GetLesServices()
        {
            return serviceAccess.GetLesServices();
        }

        public List<Absence> GetLesAbsences(int idProfil)
        {
            return absenceAccess.GetLesAbsences(idProfil);
        }

        public List<Motif> GetLesMotifs()
        {
            return motifAccess.GetLesMotifs();
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

        public void DelAbsence(Absence absence)
        {
            absenceAccess.DelAbsence(absence);
        }
        public void UpdAbsence(Absence absence)
        {
            absenceAccess.UpdAbsence(absence);
        }
        public void AddAbsence(Absence absence)
        {
            absenceAccess.AddAbsence(absence);
        }

    }
}
