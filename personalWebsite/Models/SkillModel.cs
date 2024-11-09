namespace personalWebsite.Models
{
    public class SkillModel
    {
        public string SkillName { get; set; }
        public int Proficiency { get; set; } // 0-100 arasında yüzdelik değer
        public string IconClass { get; set; } // Örn: "fab fa-html5" gibi Font Awesome sınıfı
    }
}