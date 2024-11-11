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
                Name = "Abdülmalik Kurt",
                JobTitle = "Junior Backend Developer",
                Description = "Yazýlým mühendisliði alanýnda, özellikle .NET Framework, ASP.NET MVC, MS SQL ve Redis gibi teknolojilerle \r\nçalýþarak deneyim kazandým. Hem kýsa dönem hem uzun dönem stajlarda uygulama geliþtirme, veri aktarýmý, \r\noptimizasyon alanlarýnda görev aldým. OOP, tasarým desenleri ve SOLID prensiplerini projelerimde kullanarak \r\nsürdürülebilir ve ölçeklenebilir çözümler üretmeye odaklandým.  "
            };

            // Projeler
            var projects = new List<ProjectModel>
            {
                new ProjectModel { Title = "SQLConverter", Description = "MYSQL Kodlarýný PLSQL Kodlarýna çeviren bir masaüstü uygulamasý", Technologies = "C# .Net,MYSQL, PLSQL", Link = "https://github.com/malikkurt/MYSQLToPLSQLConverter" },
                new ProjectModel { Title = "Cineverse", Description = "Identity,REDÝS,SEQ ve Mvc gibi teknolojileri kullandýðým bir web uygulamasý", Technologies = "ASP.NET MVC,REDÝS,SEQ, SQL", Link = "https://github.com/malikkurt/SeriesMVC" }
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
                new ExperienceModel { Company = "Ýstanbul Büyükþehir Belediyesi", Position = "Yazýlým Mühendisliði Stajyeri", Duration = "Ekim 2024 - Kasým 2024", Description = "ASP.NET MVC projelerinde uygulama geliþtirme süreçlerine katýldým.Redis kullanarak veritabaný \r\nsorgularýný optimize etmek amacýyla cache mekanizmasý kurdum.log4net entegrasyonu yaparak projede temel \r\nve özel loglama iþlemlerini gerçekleþtirdim.Veritabaný iþlemlerinde MS SQL kullandým; performans \r\niyileþtirmeleri için Entity Framework ile çalýþtým.Kullanýcý arayüzü ve backend üzerinde geliþtirme yaparak \r\nprojenin çeþitli fonksiyonlarýnýn geliþtirilmesine katkýda bulundum. " },
                new ExperienceModel { Company = "Dýgýturk Beýn Medýa Group", Position = "Yazýlým Mühendisliði Uzun Dönem Stajyeri", Duration = "EKÝM 2023 – OCAK 2024 ", Description = "NET Framework kullanarak, þirket içi bir uygulamada ortamlar arasý veri aktarýmý için bir modül \r\ngeliþtirdim. Kampanya verilerini içeren nesneler oluþturarak, MS SQL Server üzerinde veri sorgulama ve \r\nentegrasyon iþlemleri gerçekleþtirdim.Geliþtirdiðim modül ile kampanya bilgilerinin baþka bir ortama OOP \r\nstandartlarýna uygun þekilde aktarýlmasýný saðladým.Bu proje sürecinde .NET Framework, API ve veritabaný \r\niþlemleri konusunda deneyim kazandým. " },
                new ExperienceModel { Company = "Dýgýturk Beýn Medýa Group", Position = "Yazýlým Mühendisliði Stajyeri", Duration = "AÐUSTOS 2023 - EKÝM 2023 ", Description = "Stajýmda OOP ve SQL tabanlý projeler yaparak baþladým; MongoDB, NoSQL ve Docker teknolojilerde \r\ndeneyim kazanma fýrsatý buldum. Stajýmýn bir kýsmýnda MySQL kodlarýný PL/SQL kodlarýna dönüþtüren bir form \r\nuygulamasý tasarladým, tasarým desenleri ve SOLID prensiplerini göz önünde bulundurarak yapýlandýrdým. " }
            };

            // Yetenekler
            var skills = new List<SkillModel>
            {
                new SkillModel{SkillName="C#", Proficiency=100, IconClass="fa-solid fa-code"},
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
