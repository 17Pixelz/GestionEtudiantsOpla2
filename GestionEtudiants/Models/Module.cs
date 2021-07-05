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
    public class Module
    {
        [Key]
        public int id { get; set; }
        public string nom { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [ForeignKey("classeId")]
        public int classeId { get; set; }
        public Classe classe { get; set; }

        public int professeurId { get; set; }
        [ForeignKey("professeurId")]
        public Professeur professeur { get; set; }

        public Module(int moduleId,string nom,int classeId)
        {
            this.id = moduleId;
            this.nom = nom;
            this.classeId = classeId;
        }

        public Module() { }
    }
}
