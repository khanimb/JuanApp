using JuanApp.Models;

namespace JuanApp.ViewModels
{
    public class ShopVm
    {
        public List<Product> Products { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

    }
}
