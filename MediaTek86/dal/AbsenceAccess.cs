using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.dal
{
    internal class AbsenceAccess
    {
        private readonly Access access = null;

        public AbsenceAccess()
        {
            access = Access.GetInstance();
        }
        public List<Absence> GetLesAbsences(int idProfil)
        {
            List<Absence> lesAbsences = new List<Absence>();
            if (access != null)
            {
                string req = string.Empty;
                req += "SELECT * FROM absence a ";
                req += "JOIN personnel p ON a.idpersonnel = p.idpersonnel ";
                req += "JOIN motif m ON m.idmotif = a.idmotif ";
                req += "JOIN service s ON p.idservice = s.idservice ";
                req += $"WHERE a.idpersonnel = '{idProfil}' ";
                req += "ORDER BY a.dateDebut DESC;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Service service = new Service((int)record[12], (string)record[13]);
                            Personnel personnel = new Personnel((int)record[4], (string)record[5], (string)record[6],
                                (string)record[7], (string)record[8], service);
                            Motif motif = new Motif((int)record[10], (string)record[11]);
                            Absence absence = new Absence(personnel, (DateTime)record[1], (DateTime)record[2], motif);
                            lesAbsences.Add(absence);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }
            return lesAbsences;
        }

        public void DelAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "DELETE FROM absence WHERE idpersonnel = @idpersonnel AND dateDebut = @dateDebut;";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@idpersonnel", absence.Personnel.Idpersonnel },
                    { "@dateDebut", absence.Date_debut }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }
        }

        public void UpdAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "UPDATE absence SET datedebut = @datedebut, datefin = @datefin, idmotif = @idmotif ";
                req += "WHERE idpersonnel = @idpersonnel;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absence.Personnel.Idpersonnel);
                parameters.Add("@datedebut", absence.Date_debut);
                parameters.Add("@datefin", absence.Date_fin);
                parameters.Add("@idmotif", absence.Motif.Idmotif);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }
        }

        public void AddAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "INSERT INTO absence (idpersonnel, datedebut, datefin, idmotif) ";
                req += "VALUES (@idpersonnel, @datedebut, @datefin, @idmotif);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absence.Personnel.Idpersonnel);
                parameters.Add("@datedebut", absence.Date_debut);
                parameters.Add("@datefin", absence.Date_fin);
                parameters.Add("@idmotif", absence.Motif.Idmotif);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }
        }
    }
}
