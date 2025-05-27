using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    internal class Absence
    {
        public Absence(Personnel personnel, DateTime ddebut, DateTime dfin, Motif motif) 
        { 
            this.Personnel = personnel;
            this.Date_debut = ddebut;
            this.Date_fin = dfin;
            this.Motif = motif;
        }

        public Personnel Personnel { get; set; }
        public DateTime Date_debut { get; set; }
        public DateTime Date_fin { get; set; }
        public Motif Motif { get; set; }
    }
}
