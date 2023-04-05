using EntityFramework_Slider.Models;

namespace EntityFramework_Slider.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public SliderInfo SliderInfo { get; set; }
        public IEnumerable<About> Abouts { get; set; }
        public IEnumerable<AboutImage> AboutImages { get; set; }
        public IEnumerable<Expert> Experts { get; set; }

    }
}
