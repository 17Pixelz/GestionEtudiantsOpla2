using GestionEtudiants.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using GestionEtudiants.Context;
using GestionEtudiants.ViewModel;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace GestionEtudiants.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        [Obsolete]
        private readonly IHostingEnvironment _hostEnvironment;

        private myContext db = new myContext();

        [Obsolete]
        public HomeController(ILogger<HomeController> logger, IHostingEnvironment hostEnvironment)
        {
            _logger = logger;
            _hostEnvironment = hostEnvironment;
        }

        [Authorize]
        public IActionResult Index()
        {
            ConsultationModel cm = new ConsultationModel();

            //var eid = HttpContext.Session.GetInt32("_Id");
            if (Get("_Id") == null)
            {
                return RedirectToAction("Login","Home");
            }
            var eid = Int32.Parse(Get("_Id"));

            var id_insc = db.Etudiants.Where(i => i.apogee == eid).FirstOrDefault();

            var fil = db.classes.Where(i => i.id == id_insc.classeId).FirstOrDefault();
            
            
            var modules = (from m in db.Modules where m.classeId == fil.id select m).ToList();

            var profs = (from p in db.Professeurs select p).ToList();

            cm.modules = modules;
            cm.professeurs = profs;
            
            return View(cm);
        }

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(Etudiant et)
        {
            
            var x = db.Etudiants.Where(a => a.apogee == et.apogee && a.password == et.password).SingleOrDefault();
            if(x != null)
            {
                HttpContext.Session.SetString("_Nom", x.lastname + " " + x.firstname);
                HttpContext.Session.SetInt32("_Id", (int)x.classeId);
                Set("_Nom", x.lastname + " " + x.firstname, 60);
                Set("_Id", x.apogee.ToString() , 60);

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, x.cin)
                };

                var identity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                var props = new AuthenticationProperties();
                HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,principal, props).Wait();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewData["error"] = "Les donnees entrees sont incorrect";
                return View();
            }
        }





        [Authorize]
        public IActionResult Document()
        {
            var id_etudiant = Int32.Parse(Get("_Id"));

            var docs = (from doc in db.Documents where doc.id_etudiant == id_etudiant select doc).ToList();
            List<Document> documents = docs;


            return View(documents);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Document(String type)
        {
            Document dc = new Document()
            {
                id_etudiant = Int32.Parse(Get("_Id")),
                type = type,
                date_demande = DateTime.Now

            };

            db.Documents.Add(dc);
            db.SaveChanges();

            return RedirectToAction("Document", "Home");
        }


        [Authorize]
        public IActionResult Profile()
        {
            Etudiant et = new Etudiant();
            var eid = Int32.Parse(Get("_Id"));
            et = db.Etudiants.Where(a => a.apogee == eid).SingleOrDefault();
            

            return View(et);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Profile(Etudiant et)
        {
            var eid = Int32.Parse(Get("_Id"));
            var x = db.Etudiants.Where(a => a.apogee == eid).SingleOrDefault();
            x.email = et.email != null ? et.email : x.email;
            x.password = et.password != null ? et.password : x.password;
            db.SaveChanges();

            return RedirectToAction("Profile", "Home");
        }



        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            Remove("_Nom");
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        public IActionResult Consultation()
        {
            //var eid = HttpContext.Session.GetInt32("_Id");
            var eid = Int32.Parse(Get("_Id"));

            var id_insc = db.Etudiants.Where(i => i.apogee == eid).FirstOrDefault();

            var fil = db.classes.Where(i => i.id == id_insc.classeId).FirstOrDefault();


            var modules = (from m in db.Modules where m.classeId == fil.id select m).ToList();

            var profs = (from p in db.Professeurs select p).ToList();

            ConsultationModel cm = new ConsultationModel();

            cm.notes = new Dictionary<int,List<Note>>();
              
            foreach (var mod in modules)
            {
                var notes = (from n in db.Notes where n.moduleId == mod.id select n).ToList();
                cm.notes.Add(mod.id,notes);
            }
            

            cm.modules = modules;
            cm.professeurs = profs;

            return View(cm);
        }

        [HttpGet]
        public FileResult download(string filename)
        {
            string path = "";
            var content_type = "";
            filename = filename + ".pdf";
            path = Path.Combine(_hostEnvironment.WebRootPath, "docs\\" + filename);

            if (filename.Contains(".pdf"))
            {
                content_type = "application/pdf";
            }
            var fs = System.IO.File.OpenRead(path);
            return File(fs, content_type, filename);
        }

        [Authorize]
        public IActionResult Delibiration()
        {   
            return View();
        }

        

        

        public IActionResult Register()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public string Get(string key)
        {
            return Request.Cookies[key];
        }

        public void Set(string key, string value, int? expireTime)
        {
            CookieOptions option = new CookieOptions();
            if (expireTime.HasValue)
                option.Expires = DateTime.Now.AddMinutes(expireTime.Value);
            else
                option.Expires = DateTime.Now.AddMilliseconds(10);
            Response.Cookies.Append(key, value, option);
        }
 
        public void Remove(string key)
        {
            Response.Cookies.Delete(key);
        }
    }
}
