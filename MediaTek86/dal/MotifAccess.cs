using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.dal
{
    internal class MotifAccess
    {
        private readonly Access access = null;

        public MotifAccess()
        {
            access = Access.GetInstance();
        }

        public List<Motif> GetLesMotifs()
        {
            List<Motif> lesMotifs = new List<Motif>();
            if (access.Manager != null)
            {
                string req = "SELECT * FROM motif ORDER BY libelle;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Motif motif = new Motif((int)record[0], (string)record[1]);
                            lesMotifs.Add(motif);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }
            return lesMotifs;
        }
    }
}
