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
                new ProjectModel { Title = "MYSQLToPLSQLConverter", Description = " MySQL sorgular�n� PL/SQL'e d�n��t�rmek i�in geli�tirilmi� bir C# projesidir. Bu ara�, veri taban� ta��nma veya entegrasyon projelerinde, MySQL sorgular�n� Oracle'�n PL/SQL yap�s�na uygun hale getirmek i�in kullan��l�d�r. B�ylece, veri taban� uyumsuzluk sorunlar�n� giderme s�recini kolayla�t�r�r.", Technologies = "C# .Net,MYSQL, PLSQL", Link = "https://github.com/malikkurt/MYSQLToPLSQLConverter" },
                new ProjectModel { Title = "Cineverse", Description = "MVC (Model-View-Controller) mimarisiyle olu�turulmu� bir web uygulamas�d�r. JavaScript, HTML, CSS, Pug, SCSS ve C# gibi teknolojiler kullan�larak geli�tirilmi�tir. Proje, kullan�c�lar�n �e�itli dizileri g�r�nt�lemesi veya y�netmesi i�in bir yap� sa�lar. ", Technologies = "ASP.NET MVC,RED�S,SEQ, SQL", Link = "https://github.com/malikkurt/SeriesMVC" },
                new ProjectModel { Title = "CompareXmlWithLinq", Description = "XML d���mlerini LINQ kullanarak kar��la�t�rmay� ama�layan bir C# projesidir. Bu proje, XML belgelerindeki yap�lar� ve de�erleri etkili bir �ekilde kar��la�t�rmak i�in LINQ sorgulama yeteneklerinden faydalan�r. XML verilerinin tutarl�l���n� do�rulama, yap�land�rma dosyalar�n� kar��la�t�rma veya veri senkronizasyonu gibi i�lemlerde kullan�labilir.", Technologies = "C#, LINQ", Link = "https://github.com/malikkurt/CompareXmlNodeWithLinq" }
            };

            //E�itim
            var education = new List<EducationModel>
            {
                new EducationModel { Title="Karadeniz Teknik �niversitesi", Position="Yaz�l�m M�hendisli�i", Description="Lisans ", Duration="2021-2024"},
                new EducationModel { Title="K�rklareli �niversitesi", Position="Yaz�l�m M�hendisli�i", Description="Lisans", Duration="2020-2021"}
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
                new SkillModel {SkillName="C#", Proficiency=100, IconClass="fa-solid fa-code"},
                new SkillModel { SkillName = "HTML", Proficiency = 100, IconClass = "fab fa-html5" },
                new SkillModel { SkillName = "CSS", Proficiency = 100, IconClass = "fab fa-css3-alt" },
                new SkillModel { SkillName = "JavaScript", Proficiency = 100, IconClass = "fab fa-js" },
                new SkillModel { SkillName = "Wordpress", Proficiency = 100, IconClass = "fab fa-wordpress" }
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
