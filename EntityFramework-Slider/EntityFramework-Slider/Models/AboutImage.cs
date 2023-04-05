namespace EntityFramework_Slider.Models
{
    public class AboutImage:BaseEntity
    {
        public string? Image { get; set; }
        public bool IsMain { get; set; } = false;
        public int AboutId { get; set; }
        public About About { get; set; }
    }
}
