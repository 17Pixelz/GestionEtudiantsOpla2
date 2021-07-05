using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEtudiants.Models
{
    public class Classe
    {
        [Key]
        public int id { get; set; }


        public int filiereId { get; set; }
        [ForeignKey("filiereId")]
        public Filiere filiere { get; set; }


        public int annee { get; set; }
        public List<Module> modules { get; set; }

        public List<Etudiant> etudiants { get; set; }
        public Classe() { }

        public override string ToString()
        {
            var filiere = this.filiere.nom;
            return this.annee + ' ' + filiere;
        }
    }
}
