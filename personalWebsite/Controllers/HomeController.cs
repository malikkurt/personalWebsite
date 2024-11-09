using Microsoft.AspNetCore.Mvc;
using personalWebsite.Models;
using System.Diagnostics;

namespace personalWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Hakk�nda Bilgisi
            var about = new AboutModel
            {
                Name = "Ahmet Y�lmaz",
                JobTitle = "Backend Developer",
                Description = "Yaz�l�m m�hendisli�i alan�nda, �zellikle .NET Framework, ASP.NET MVC, MS SQL ve Redis gibi teknolojilerle \r\n�al��arak deneyim kazand�m. Hem k�sa d�nem hem uzun d�nem stajlarda uygulama geli�tirme, veri aktar�m�, \r\noptimizasyon alanlar�nda g�rev ald�m. OOP, tasar�m desenleri ve SOLID prensiplerini projelerimde kullanarak \r\ns�rd�r�lebilir ve �l�eklenebilir ��z�mler �retmeye odakland�m.  "
            };

            // Projeler
            var projects = new List<ProjectModel>
            {
                new ProjectModel { Title = "E-Ticaret Platformu", Description = "Kapsaml� bir e-ticaret sistemi.", Technologies = "ASP.NET, SQL, Docker", Link = "#" },
                new ProjectModel { Title = "API Entegrasyonu", Description = "�deme API'leri ile entegrasyon.", Technologies = "Node.js, MongoDB", Link = "#" }
            };

            //E�itim
            var education = new List<EducationModel>
            {
                new EducationModel { Title="Karadeniz Teknik �niversitesi", Position="��renci", Description="Karadeniz Teknin �niversitesi kurumunda yaz�l�m m�hendisli�i ��rencisi ", Duration="2021-2024"},
                new EducationModel { Title="K�rklareli �niversitesi", Position="��renci", Description="K�rklareli �niversitesi kurumunda yaz�l�m m�hendisli�i ��rencisi ", Duration="2020-2021"}
            };

            // Deneyim
            var experiences = new List<ExperienceModel>
            {
                new ExperienceModel { Company = "XYZ Teknoloji", Position = "Yaz�l�m M�hendisli�i Stajyeri", Duration = "2017 - 2019", Description = "�e�itli yaz�l�m projelerinde g�rev ald�." },
                new ExperienceModel { Company = "ABC Yaz�l�m", Position = "Yaz�l�m M�hendisli�i Uzun D�nem Stajyeri", Duration = "2019 - �u An", Description = "Backend geli�tirme ve API y�netimi." },
                new ExperienceModel { Company = "XYZ Teknoloji", Position = "Yaz�l�m M�hendisli�i Stajyeri", Duration = "2017 - 2019", Description = "�e�itli yaz�l�m projelerinde g�rev ald�." }
            };

            // Yetenekler
            var skills = new List<SkillModel>
            {
                new SkillModel { SkillName = "HTML", Proficiency = 90, IconClass = "fab fa-html5" },
                new SkillModel { SkillName = "CSS", Proficiency = 80, IconClass = "fab fa-css3-alt" },
                new SkillModel { SkillName = "JavaScript", Proficiency = 75, IconClass = "fab fa-js" }
            };
       


            // Modeli View'a g�nderme
            ViewBag.About = about;
            ViewBag.Projects = projects;
            ViewBag.Education = education;
            ViewBag.Experiences = experiences;
            ViewBag.Skills = skills;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
