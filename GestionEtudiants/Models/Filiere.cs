using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEtudiants.Models
{
    public class Filiere
    {
        [Key]
        public int id { get; set; }
        public string nom { get; set; }

        public int departementId { get; set; }
        [ForeignKey("departementId")]
        public Departement departement { get; set; }
        public List<Classe> classes { get; set; }

        public Filiere(int filiereId, string nom,int coordinateurId,int departementId)
        {
            this.id = filiereId;
            this.nom = nom;
            this.departementId = departementId;
        }

        public Filiere() { }
    }
}
