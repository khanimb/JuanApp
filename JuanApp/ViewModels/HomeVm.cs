using JuanApp.Models;

namespace JuanApp.ViewModels
{
    public class HomeVm
    {
        public List<Slider> Sliders { get; set; }
        public List<Product> OurProduct { get; set; }
        public List<Product> NewProducts { get; set; }
        public List<Category> Categories { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}