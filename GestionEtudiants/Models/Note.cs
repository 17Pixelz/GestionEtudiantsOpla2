using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEtudiants.Models
{
    public class Note
    {
        [Key]
        public int id { get; set; }
        public string NotePdfUrl { get; set; }
        public string semestre { get; set; }
        public int moduleId { get; set; }
        [ForeignKey("moduleId")]
        public Module module { get; set; }

        

        public Note() { }
    }
}
