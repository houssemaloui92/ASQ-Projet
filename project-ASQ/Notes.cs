using System;
using System.Collections.Generic;
using System.Text;

namespace project_ASQ
{
    class Notes
    {
        public int NumeroEtudiant { get; set; }
        public int NumeroCours { get; set; }
        public int Note { get; set; }
        public Notes (int id , int numerocours,int note){
            this.NumeroEtudiant = id;
            this.NumeroCours = numerocours;
            this.Note = note;
        }
        public string ToString()
        {
            return "Numero de l'etudiant:  " + this.NumeroEtudiant + "Numero de cours :   " + this.NumeroCours + "Note:  " + this.Note;
        }
            
    }
}
