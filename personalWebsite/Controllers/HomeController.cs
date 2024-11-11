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
                Name = "Abd�lmalik Kurt",
                JobTitle = "Junior Backend Developer",
                Description = "Yaz�l�m m�hendisli�i alan�nda, �zellikle .NET Framework, ASP.NET MVC, MS SQL ve Redis gibi teknolojilerle \r\n�al��arak deneyim kazand�m. Hem k�sa d�nem hem uzun d�nem stajlarda uygulama geli�tirme, veri aktar�m�, \r\noptimizasyon alanlar�nda g�rev ald�m. OOP, tasar�m desenleri ve SOLID prensiplerini projelerimde kullanarak \r\ns�rd�r�lebilir ve �l�eklenebilir ��z�mler �retmeye odakland�m.  "
            };

            // Projeler
            var projects = new List<ProjectModel>
            {
                new ProjectModel { Title = "SQLConverter", Description = "MYSQL Kodlar�n� PLSQL Kodlar�na �eviren bir masa�st� uygulamas�", Technologies = "C# .Net,MYSQL, PLSQL", Link = "https://github.com/malikkurt/MYSQLToPLSQLConverter" },
                new ProjectModel { Title = "Cineverse", Description = "Identity,RED�S,SEQ ve Mvc gibi teknolojileri kulland���m bir web uygulamas�", Technologies = "ASP.NET MVC,RED�S,SEQ, SQL", Link = "https://github.com/malikkurt/SeriesMVC" }
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
                new ExperienceModel { Company = "�stanbul B�y�k�ehir Belediyesi", Position = "Yaz�l�m M�hendisli�i Stajyeri", Duration = "Ekim 2024 - Kas�m 2024", Description = "ASP.NET MVC projelerinde uygulama geli�tirme s�re�lerine kat�ld�m.Redis kullanarak veritaban� \r\nsorgular�n� optimize etmek amac�yla cache mekanizmas� kurdum.log4net entegrasyonu yaparak projede temel \r\nve �zel loglama i�lemlerini ger�ekle�tirdim.Veritaban� i�lemlerinde MS SQL kulland�m; performans \r\niyile�tirmeleri i�in Entity Framework ile �al��t�m.Kullan�c� aray�z� ve backend �zerinde geli�tirme yaparak \r\nprojenin �e�itli fonksiyonlar�n�n geli�tirilmesine katk�da bulundum. " },
                new ExperienceModel { Company = "D�g�turk Be�n Med�a Group", Position = "Yaz�l�m M�hendisli�i Uzun D�nem Stajyeri", Duration = "EK�M 2023 � OCAK 2024 ", Description = "NET Framework kullanarak, �irket i�i bir uygulamada ortamlar aras� veri aktar�m� i�in bir mod�l \r\ngeli�tirdim. Kampanya verilerini i�eren nesneler olu�turarak, MS SQL Server �zerinde veri sorgulama ve \r\nentegrasyon i�lemleri ger�ekle�tirdim.Geli�tirdi�im mod�l ile kampanya bilgilerinin ba�ka bir ortama OOP \r\nstandartlar�na uygun �ekilde aktar�lmas�n� sa�lad�m.Bu proje s�recinde .NET Framework, API ve veritaban� \r\ni�lemleri konusunda deneyim kazand�m. " },
                new ExperienceModel { Company = "D�g�turk Be�n Med�a Group", Position = "Yaz�l�m M�hendisli�i Stajyeri", Duration = "A�USTOS 2023 - EK�M 2023 ", Description = "Staj�mda OOP ve SQL tabanl� projeler yaparak ba�lad�m; MongoDB, NoSQL ve Docker teknolojilerde \r\ndeneyim kazanma f�rsat� buldum. Staj�m�n bir k�sm�nda MySQL kodlar�n� PL/SQL kodlar�na d�n��t�ren bir form \r\nuygulamas� tasarlad�m, tasar�m desenleri ve SOLID prensiplerini g�z �n�nde bulundurarak yap�land�rd�m. " }
            };

            // Yetenekler
            var skills = new List<SkillModel>
            {
                new SkillModel{SkillName="C#", Proficiency=100, IconClass="fa-solid fa-code"},
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
