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
            // Hakkýnda Bilgisi
            var about = new AboutModel
            {
                Name = "Ahmet Yýlmaz",
                JobTitle = "Backend Developer",
                Description = "Yazýlým mühendisliði alanýnda, özellikle .NET Framework, ASP.NET MVC, MS SQL ve Redis gibi teknolojilerle \r\nçalýþarak deneyim kazandým. Hem kýsa dönem hem uzun dönem stajlarda uygulama geliþtirme, veri aktarýmý, \r\noptimizasyon alanlarýnda görev aldým. OOP, tasarým desenleri ve SOLID prensiplerini projelerimde kullanarak \r\nsürdürülebilir ve ölçeklenebilir çözümler üretmeye odaklandým.  "
            };

            // Projeler
            var projects = new List<ProjectModel>
            {
                new ProjectModel { Title = "E-Ticaret Platformu", Description = "Kapsamlý bir e-ticaret sistemi.", Technologies = "ASP.NET, SQL, Docker", Link = "#" },
                new ProjectModel { Title = "API Entegrasyonu", Description = "Ödeme API'leri ile entegrasyon.", Technologies = "Node.js, MongoDB", Link = "#" }
            };

            //Eðitim
            var education = new List<EducationModel>
            {
                new EducationModel { Title="Karadeniz Teknik Üniversitesi", Position="Öðrenci", Description="Karadeniz Teknin Üniversitesi kurumunda yazýlým mühendisliði öðrencisi ", Duration="2021-2024"},
                new EducationModel { Title="Kýrklareli Üniversitesi", Position="Öðrenci", Description="Kýrklareli Üniversitesi kurumunda yazýlým mühendisliði öðrencisi ", Duration="2020-2021"}
            };

            // Deneyim
            var experiences = new List<ExperienceModel>
            {
                new ExperienceModel { Company = "XYZ Teknoloji", Position = "Yazýlým Mühendisliði Stajyeri", Duration = "2017 - 2019", Description = "Çeþitli yazýlým projelerinde görev aldý." },
                new ExperienceModel { Company = "ABC Yazýlým", Position = "Yazýlým Mühendisliði Uzun Dönem Stajyeri", Duration = "2019 - Þu An", Description = "Backend geliþtirme ve API yönetimi." },
                new ExperienceModel { Company = "XYZ Teknoloji", Position = "Yazýlým Mühendisliði Stajyeri", Duration = "2017 - 2019", Description = "Çeþitli yazýlým projelerinde görev aldý." }
            };

            // Yetenekler
            var skills = new List<SkillModel>
            {
                new SkillModel { SkillName = "HTML", Proficiency = 90, IconClass = "fab fa-html5" },
                new SkillModel { SkillName = "CSS", Proficiency = 80, IconClass = "fab fa-css3-alt" },
                new SkillModel { SkillName = "JavaScript", Proficiency = 75, IconClass = "fab fa-js" }
            };
       


            // Modeli View'a gönderme
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
