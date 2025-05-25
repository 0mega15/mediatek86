using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    internal class Motif
    {
        public Motif(int idmotif, string nom)
        {
            this.Idmotif = idmotif;
            this.Nom = nom;
        }
        public int Idmotif { get; }
        public string Nom { get; set; }
        public override string ToString()
        {
            return this.Nom;
        }

    }
}
