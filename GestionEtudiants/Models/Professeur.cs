
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GestionEtudiants.Models
{
    public class Professeur
    {
        [Key]
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom {get;set;}
        public string login { get; set; }
        public string password { get; set; }
        public string email { get; set; }


        public int departementId { get; set; }
        [ForeignKey("departementId")]
        public Departement departement { get; set; }
        
        [JsonIgnore]
        [IgnoreDataMember]
        public List<Module> modules { get; set; }

        public Professeur(string nom, string prenom,string email,int departementId)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.departementId = departementId;
        }
        
        public Professeur() { }
    }
}
