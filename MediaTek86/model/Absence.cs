using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    internal class Absence
    {
        public Absence(Personnel personnel, int ddebut, int dfin, Motif motif) 
        { 
            this.Personnel = personnel;
            this.Ddebut = ddebut;
            this.Dfin = dfin;
            this.Motif = motif;
        }

        public Personnel Personnel { get; }
        public int Ddebut { get; set; }
        public int Dfin { get; set; }
        public Motif Motif { get; set; }
    }
}
