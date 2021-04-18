using System;
using System.Collections.Generic;
using System.Text;

namespace project_ASQ
{
   public class Etudiant
    {
        public int NumEtudiant { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public Etudiant(int id , string nom , string prenom)  {
            this.NumEtudiant = id;
            this.Nom = nom;
            this.Prenom = prenom;
        }
        public string ToString()
        {
            return "Numero de l'etudiant:  " + this.NumEtudiant + "Nom :   " + this.Nom + "Prenom :  " + this.Prenom;
        }
    }
}
