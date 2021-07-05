using Microsoft.AspNetCore.Mvc;
using GestionEtudiants.Models;
using System.Reflection;
using System;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using GestionEtudiants.Context;

namespace GestionEtudiants.Controllers
{
    public class ReinscriptionController : Controller
    {

        private myContext db = new myContext();


        public IActionResult step1()
        {
            var str = HttpContext.Session.GetString("regEtu");
            if(str != null)
            { 
                var obj = JsonConvert.DeserializeObject<Etudiant>(str);
                return View(obj);
            }
            else
            {
                return View();
            }
        }


        [HttpPost]
        public IActionResult step1(Etudiant et)
        {

            var key = "regEtu";
            var str = JsonConvert.SerializeObject(et);
            HttpContext.Session.SetString(key, str);
                
            return RedirectToAction("step2","Reinscription");
        }



        public IActionResult step2()
        {
            var key = "regEtu";
            var str = HttpContext.Session.GetString(key);
            if (str != null)
            {
                var obj = JsonConvert.DeserializeObject<Etudiant>(str);

                return View(obj);
            }
            else
            {
                return RedirectToAction("step1", "Reinscription");
            }
        }

        [HttpPost]
        public IActionResult step2(Etudiant et)
        {
            var key = "regEtu";
            var str = HttpContext.Session.GetString(key);
            var obj = JsonConvert.DeserializeObject<Etudiant>(str);

            obj.firstname = et.firstname;
            obj.lastname = et.lastname;
            obj.firstname_ar = et.firstname_ar;
            obj.lastname_ar = et.lastname_ar;
            obj.ddn = et.ddn;
            obj.ldn = et.ldn;
            obj.phone = et.phone;
            obj.natio = et.natio;
            obj.address = et.address;
            obj.sexe = et.sexe;

            var nstr = JsonConvert.SerializeObject(obj);
            HttpContext.Session.SetString(key, nstr);

            return RedirectToAction("step3","Reinscription");
        }

        public IActionResult step3()
        {
            var key = "regEtu";
            var str = HttpContext.Session.GetString(key);
            if (str != null)
            {
                var obj = JsonConvert.DeserializeObject<Etudiant>(str);
                return View(obj);
            }
            else
            {
                return RedirectToAction("step1", "Reinscription");
            }
        }

        [HttpPost]
        public IActionResult step3(Etudiant et)
        {
            var key = "regEtu";
            var str = HttpContext.Session.GetString(key);
            var obj = JsonConvert.DeserializeObject<Etudiant>(str);

            obj.father_name = et.father_name;
            obj.father_job = et.father_job;
            obj.mother_name = et.mother_name;
            obj.mother_job = et.mother_job;
            obj.parents_adress = et.parents_adress;
            obj.parents_phone = et.parents_phone;

            var nstr = JsonConvert.SerializeObject(obj);
            HttpContext.Session.SetString(key, nstr);
            return RedirectToAction("step4","Reinscription");
        }


        public IActionResult step4()
        {
            var key = "regEtu";
            var str = HttpContext.Session.GetString(key);
            if (str != null)
            {
                var obj = JsonConvert.DeserializeObject<Etudiant>(str);
                return View(obj);
            }
            else
            {
                return RedirectToAction("step1", "Reinscription");
            }
        }

        [HttpPost]
        public IActionResult step4(Etudiant et)
        {
            var key = "regEtu";
            var str = HttpContext.Session.GetString(key);
            var obj = JsonConvert.DeserializeObject<Etudiant>(str);

            obj.filiere = et.filiere;
            obj.annee = et.annee;
            obj.type_bac = et.type_bac;
            obj.annee_bac = et.annee_bac;
            obj.mention_bac = et.mention_bac;
            obj.lycee = et.lycee;
            obj.delegation = et.delegation;
            obj.academie = et.academie;
            obj.diplome = et.diplome;
            obj.ecole = et.ecole;
            obj.ville_diplome = et.ville_diplome;


            var nstr = JsonConvert.SerializeObject(obj);
            HttpContext.Session.SetString(key, nstr);
            return RedirectToAction("step5","Reinscription");
        }



        public IActionResult step5()
        {
            var key = "regEtu";
            var str = HttpContext.Session.GetString(key);
            if (str != null)
            {
                var obj = JsonConvert.DeserializeObject<Etudiant>(str);
                return View(obj);
            }
            else
            {
                return RedirectToAction("step1", "Reinscription");
            }
        }

        [HttpPost]
        public IActionResult step5(Etudiant et)
        {
            var key = "regEtu";
            var str = HttpContext.Session.GetString(key);
            var obj = JsonConvert.DeserializeObject<Etudiant>(str);

            obj.picture = et.picture;
            obj.classeId = 1;

            var nstr = JsonConvert.SerializeObject(obj);
            HttpContext.Session.SetString(key, nstr);

            db.Etudiants.Add(obj);
            db.SaveChanges();


            return RedirectToAction("Index","Home");
        }

    }
}