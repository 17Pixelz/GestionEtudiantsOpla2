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
    public class Departement
    {
        [Key]
        public int id{get;set;}
        public string nom { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public List<Filiere> filieres { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public List<Professeur> professeurs { get; set; }
       
        public Departement(string nom)
        {
            this.nom = nom;
        }
        public Departement()
        {

        }
    }
}
