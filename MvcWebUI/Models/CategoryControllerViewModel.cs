using Entity.Concrete;

namespace MvcWebUI.Models
{
    public class CategoryControllerViewModel
    {
        public List<Category> Categories { get; set; }
        public int CurrentCategory { get; set; }
    }
}
