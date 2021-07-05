using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEtudiants.Models
{
    public class Etudiant
    {
        [Key]
        public int apogee { get; set; }
        public string cne { get; set; }
        public string email { get; set; }
        public string cin { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:MM tt}", ApplyFormatInEditMode = true)]
        public DateTime ddn { get; set; }
        public string ldn { get; set; }
        public string natio { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string annee { get; set; }


        public String nom { get; set; }
        public String prenom { get; set; }
        public String tel { get; set; }
        public String adresse { get; set; }

        public String lastname_ar { get; set; }
        public String firstname_fr { get; set; }
        public String firstname_ar { get; set; }
        public String father_name { get; set; }
        public String father_job { get; set; }
        public String mother_name { get; set; }
        public String mother_job { get; set; }
        public String parents_adress { get; set; }
        public String parents_phone { get; set; }
        public String filiere { get; set; }
        public String type_bac { get; set; }
        public String mention_bac { get; set; }
        public String annee_bac { get; set; }
        public String lycee { get; set; }
        public String delegation { get; set; }
        public String academie { get; set; }
        public String diplome { get; set; }
        public String ecole { get; set; }
        public String ville_diplome { get; set; }
        public int validated { get; set; }
        public int code_promo { get; set; }


        public int classeId { get; set; }
        [ForeignKey("classeId")]
        public Classe classe { get; set; }

        public string picture { get; set; }
        public string password { get; set; }
        public string sexe { get; set; }

        public Etudiant(int apogee, string lastname, string firstname, string email, string annee, int classeId)
        {
            this.apogee = apogee;
            this.lastname = lastname;
            this.firstname = firstname;
            this.email = email;
            this.annee = annee;
            this.classeId = classeId;
        }
  

        public Etudiant(int apogee, string lastname, string firstname, string email, string annee,int classeId,string picture)
        {
            this.apogee = apogee;
            this.lastname = lastname;
            this.firstname = firstname;
            this.email = email;
            this.annee = annee;
            this.classeId = classeId;
            this.picture = picture;
        }

        public Etudiant() { }
        
        

    }
}
