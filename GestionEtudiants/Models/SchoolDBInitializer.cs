using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEtudiants.Models
{
    public class SchoolDBInitializer
    {
        public List<Filiere> filieres { get; set; }
        public List<Module> modules { get; set; }
        public List<Etudiant> etudiants { get; set; }
        public List<Document> documents {get; set;}
        public List<Classe> classes {get; set;}
        public List<Note> notes {get; set;}
        public List<Professeur> professeurs{get; set;}
        public List<Departement> departements { get; set; }
        public List<Etat> etats { get; set; }


        public SchoolDBInitializer()
        {

            var docus = new List<String> {
                "Attestation de scolarite",
                "Releve de note",
                "Attestation de stage"
            };

            var pdfs = new List<String> {
                "A",
                "B",
                "C"
            };


            var ids = 1;
            departements = new List<Departement>
            {
                new Departement { id = ids++, nom = "Informatique" },
                new Departement { id = ids++, nom = "Industrielle" },
            };

            etats = new List<Etat>
            {
                new Etat { Id = 1, etat = 1},
                new Etat { Id = 2, etat = 1},
                new Etat { Id = 3, etat = 1},
                new Etat { Id = 4, etat = 1}
            };

            ids = 1;
            filieres = new List<Filiere>
            {
                new Filiere { id = ids++, nom = "GINFO" , departementId = 1},
                new Filiere { id = ids++, nom = "GTR" , departementId = 1},
                new Filiere { id = ids++, nom = "GPMC", departementId = 2 },
                new Filiere { id = ids++, nom = "GINDUS", departementId = 2}
            };



            ids = 1;
            var profs = new Faker<Professeur>()
                .RuleFor(m => m.id, f => ids++)
                .RuleFor(m => m.nom, f => f.Person.LastName)
                .RuleFor(m => m.prenom, f => f.Person.FirstName)
                .RuleFor(m => m.departementId, f => f.PickRandom(departements).id)
                .RuleFor(m => m.email, f => f.Person.Email)
                .RuleFor(m => m.login, f => f.Random.Words(1))
                .RuleFor(m => m.password, f => "0000");

            professeurs = profs.Generate(25);




            ids = 1;
            var inscs = new Faker<Classe>()
                .RuleFor(m => m.id, f => ids++)
                .RuleFor(m => m.annee, f => 2021)
                .RuleFor(m => m.filiereId, f => f.PickRandom(filieres).id);

            classes = inscs.Generate(4);

            ids = 1;
            var mods = new Faker<Module>()
                .RuleFor(m => m.id, f => ids++)
                .RuleFor(m => m.nom, f => f.Lorem.Random.Words(3))
                .RuleFor(m => m.professeurId, f => f.PickRandom(professeurs).id)
                .RuleFor(m => m.classeId, f => f.PickRandom(classes).id);

            modules = mods.Generate(24);



            ids = 1;
            var nots = new Faker<Note>()
                .RuleFor(m => m.id, f => ids++)
                .RuleFor(m => m.semestre, f => f.Random.Number(2).ToString())
                .RuleFor(m => m.moduleId, f => f.PickRandom(modules).id)
                .RuleFor(m => m.NotePdfUrl, f => f.PickRandom(pdfs));

            notes = nots.Generate(25);





            var iid = 1;
            ids = 2000;
            var etus = new Faker<Etudiant>()
                .RuleFor(m => m.apogee, f => ids++)
                .RuleFor(m => m.lastname, f => f.Person.LastName)
                .RuleFor(m => m.firstname, f => f.Person.FirstName)
                .RuleFor(m => m.email, f => f.Person.Email)
                .RuleFor(m => m.cin, f => "EE" + f.System.Random.Number(60000))
                .RuleFor(m => m.cne, f => "G" + f.System.Random.Number(600000))
                .RuleFor(m => m.phone, f => f.Person.Phone)
                .RuleFor(m => m.ddn, f =>  f.Person.DateOfBirth.Date)
                .RuleFor(m => m.annee, f => "2021")
                .RuleFor(m => m.address, f => f.Person.Address.City)
                .RuleFor(m => m.natio, f => f.Address.Country())
                .RuleFor(m => m.password, "0000")
                .RuleFor(m => m.sexe, f => f.Person.Gender.ToString())
                .RuleFor(m => m.classeId, f => f.PickRandom(classes).id);

            etudiants = etus.Generate(500);


            ids = 1;
            var docs = new Faker<Document>()
                .RuleFor(m => m.id, f => ids++)
                .RuleFor(m => m.type, f => f.PickRandom(docus))
                .RuleFor(m => m.date_demande, f => DateTime.Now)
                .RuleFor(m => m.id_etudiant, f => f.PickRandom(etudiants).apogee);

            documents = docs.Generate(5);




        }

    }
}
