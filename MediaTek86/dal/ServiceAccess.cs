using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.dal
{
    internal class ServiceAccess
    {
        private readonly Access access = null;

        public ServiceAccess()
        { 
            access = Access.GetInstance();
        }

        public List<Service> GetLesServices() 
        {
            List<Service> lesServices = new List<Service>();
            if (access.Manager != null)
            {
                string req = "SELECT * FROM service ORDER BY nom;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Service service = new Service((int)record[0], (string)record[1]);
                            lesServices.Add(service);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }
            return lesServices;
        }
    }
}
