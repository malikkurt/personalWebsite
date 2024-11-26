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
                new ProjectModel { Title = "AI Image Generator ", Description = "Bu projede, yapay zeka destekli bir görsel oluþturma uygulamasý geliþtirdim. Kullanýcýlarýn \r\ngirdiði  verileri, REST API üzerinden dýþ bir yapay zeka servisine göndererek, belirtilen kriterlere \r\nuygun görsellerin oluþturulmasýný saðladým. Proje kapsamýnda, kullanýcý dostu bir arayüz oluþturmak \r\niçin ASP.NET MVC mimarisi kullandým. API'den gelen görsel sonuçlarýný JSON formatýnda iþleyerek \r\nkullanýcýya gerçek zamanlý olarak sundum. Ayrýca, oluþturulan görsellerin paylaþýlabilmesi ve \r\nindirilebilmesi için çeþitli özellikler ekledim. ", Technologies = " ASP.NET MVC, C#, REST API, JSON", Link = "" },
                new ProjectModel { Title = "REALTÝMEPOLLÝNGAPP", Description = "SignalR kullanarak gerçek zamanlý bir anket uygulamasý geliþtirdim. Bu proje, kullanýcýlarýn \r\nanlýk olarak oylama yapmalarýna ve sonuçlarýn canlý olarak güncellenmesini izlemelerine imkan \r\ntanýyor. ASP.NET Core Web API ve SignalR ile oluþturduðum bu uygulama, etkileþimli ve dinamik bir \r\nanket deneyimi sunarak kullanýcýlarýn aktif katýlýmýný saðlýyor.", Technologies = "C# WEB API, SIGNALR", Link = "https://github.com/malikkurt/RealTimePollingApp" },
                new ProjectModel { Title = "MYSQLToPLSQLConverter", Description = "MySQL sorgularýný PL/SQL'e dönüþtürmek için geliþtirilmiþ bir C# projesidir. Bu araç, veri tabaný taþýnma veya entegrasyon projelerinde, MySQL sorgularýný Oracle'ýn PL/SQL yapýsýna uygun hale getirmek için kullanýþlýdýr. Böylece, veri tabaný uyumsuzluk sorunlarýný giderme sürecini kolaylaþtýrýr.", Technologies = "C# .Net,MYSQL, PLSQL", Link = "https://github.com/malikkurt/MYSQLToPLSQLConverter" },
                new ProjectModel { Title = "Cineverse", Description = "MVC (Model-View-Controller) mimarisiyle oluþturulmuþ bir web uygulamasýdýr. JavaScript, HTML, CSS, Pug, SCSS ve C# gibi teknolojiler kullanýlarak geliþtirilmiþtir. Proje, kullanýcýlarýn çeþitli dizileri görüntülemesi veya yönetmesi için bir yapý saðlar. ", Technologies = "ASP.NET MVC,REDÝS,SEQ, SQL", Link = "https://github.com/malikkurt/SeriesMVC" },
                new ProjectModel { Title = "CompareXmlWithLinq", Description = "XML düðümlerini LINQ kullanarak karþýlaþtýrmayý amaçlayan bir C# projesidir. Bu proje, XML belgelerindeki yapýlarý ve deðerleri etkili bir þekilde karþýlaþtýrmak için LINQ sorgulama yeteneklerinden faydalanýr. XML verilerinin tutarlýlýðýný doðrulama, yapýlandýrma dosyalarýný karþýlaþtýrma veya veri senkronizasyonu gibi iþlemlerde kullanýlabilir.", Technologies = "C#, LINQ", Link = "https://github.com/malikkurt/CompareXmlNodeWithLinq" }
            };

            //Eðitim
            var education = new List<EducationModel>
            {
                new EducationModel { Title="Karadeniz Teknik Üniversitesi", Position="Yazýlým Mühendisliði", Description="Lisans ", Duration="2021-2024"},
                new EducationModel { Title="Kýrklareli Üniversitesi", Position="Yazýlým Mühendisliði", Description="Lisans", Duration="2020-2021"}
            };

            // Deneyim
            var experiences = new List<ExperienceModel>
            {
                new ExperienceModel { Company = "Ýstanbul Büyükþehir Belediyesi", Position = "Yazýlým Mühendisliði Stajyeri", Duration = "Ekim 2024 - Kasým 2024", Description = "ASP.NET MVC projelerinde geliþtirme süreçlerine katýldým. Redis ile cache mekanizmasý kurarak \r\nsorgularý optimize ettim ve log4net entegrasyonu ile loglama iþlemlerini gerçekleþtirdim. MS SQL ve Entity \r\nFramework kullanarak veritabaný iþlemlerini hýzlandýrdým. Kullanýcý arayüzü ve backend geliþtirmeleriyle \r\nprojeye katkýda bulundum. Ayrýca, SignalR ile gerçek zamanlý bir anket uygulamasý geliþtirerek anlýk oylama ve \r\ncanlý sonuç güncellemeleri saðladým. Bunun yaný sýra, yapay zeka destekli bir görsel oluþturma uygulamasý \r\ngeliþtirdim. Bu projede, REST API kullanarak kullanýcýlarýn verdiði metinlerle yapay zeka tabanlý görseller \r\nürettim ve oluþturulan görselleri kullanýcý dostu bir arayüzle sundum. " },
                new ExperienceModel { Company = "Dýgýturk Beýn Medýa Group", Position = "Yazýlým Mühendisliði Uzun Dönem Stajyeri", Duration = "EKÝM 2023 – OCAK 2024 ", Description = "NET Framework kullanarak, þirket içi bir uygulamada ortamlar arasý veri aktarýmý için bir modül \r\ngeliþtirdim. Kampanya verilerini içeren nesneler oluþturarak, MS SQL Server üzerinde veri sorgulama ve \r\nentegrasyon iþlemleri gerçekleþtirdim.Geliþtirdiðim modül ile kampanya bilgilerinin baþka bir ortama OOP \r\nstandartlarýna uygun þekilde aktarýlmasýný saðladým.Bu proje sürecinde .NET Framework, API ve veritabaný \r\niþlemleri konusunda deneyim kazandým. " },
                new ExperienceModel { Company = "Dýgýturk Beýn Medýa Group", Position = "Yazýlým Mühendisliði Stajyeri", Duration = "AÐUSTOS 2023 - EKÝM 2023 ", Description = "Stajýmda OOP ve SQL tabanlý projeler yaparak baþladým; MongoDB, NoSQL ve Docker teknolojilerde \r\ndeneyim kazanma fýrsatý buldum. Stajýmýn bir kýsmýnda MySQL kodlarýný PL/SQL kodlarýna dönüþtüren bir form \r\nuygulamasý tasarladým, tasarým desenleri ve SOLID prensiplerini göz önünde bulundurarak yapýlandýrdým. " }
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
