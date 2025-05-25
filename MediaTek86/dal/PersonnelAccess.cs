using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.dal
{
    internal class PersonnelAccess
    {
        private readonly Access access = null;

        public PersonnelAccess()
        {
            access = Access.GetInstance();
        }

        public List<Personnel> GetLesPersonnels() 
        { 
            List<Personnel> lesPersonnels = new List<Personnel>();
            if (access != null)
            {
                string req = string.Empty;

                req += "SELECT * FROM personnel p JOIN service s ON p.idservice = s.idservice ";
                req += "ORDER BY p.nom, p.prenom;";

                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Service service = new Service((int)record[6], (string)record[7]);
                            Personnel personnel = new Personnel((int)record[0], (string)record[1], (string)record[2], 
                                (string)record[3], (string)record[4], service);
                            lesPersonnels.Add(personnel);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }
            return lesPersonnels;
        }

        public void DelPersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "DELETE FROM personnel WHERE idpersonnel = @idpersonnel;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", personnel.Idpersonnel);
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

        public void AddPersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "INSERT INTO personnel(nom, prenom, mail, tel, idservice)";
                req += "VALUES(@nom, @prenom, @mail, @tel, @idservice);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@nom", personnel.Nom);
                parameters.Add("@prenom", personnel.Prenom);
                parameters.Add("@mail", personnel.Mail);
                parameters.Add("@tel", personnel.Tel);
                parameters.Add("@idservice", personnel.Service.Idservice);
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

        public void UpdPersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "UPDATE personnel SET nom = @nom, prenom = @prenom, mail = @mail, tel = @tel, idservice = @idservice ";
                req += "WHERE idpersonnel = @idpersonnel;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@nom", personnel.Nom);
                parameters.Add("@prenom", personnel.Prenom);
                parameters.Add("@mail", personnel.Mail);
                parameters.Add("@tel", personnel.Tel);
                parameters.Add("@idservice", personnel.Service.Idservice);
                parameters.Add("@idpersonnel", personnel.Idpersonnel);
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
