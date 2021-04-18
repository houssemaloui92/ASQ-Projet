using System;
using System.Collections.Generic;
using System.Text;

namespace project_ASQ
{
    class Cours
    {
        public int NumeroCours { get; set; }
        public int Code { get; set; }
        public string Titre { get; set; }
        
        public Cours(int numerocours ,int code ,string titre)
        {
            this.NumeroCours = numerocours;
            this.Code = code;
            this.Titre = titre;
        }
        public string ToString()
        {
            return "Numero du cours:  " + this.NumeroCours + "Numero de code :   " + this.Code + "titre:  " + this.Titre
                ;
        }
    }
}
