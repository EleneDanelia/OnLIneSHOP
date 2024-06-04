using OnLIneSHOP.Models.Base;

namespace OnLIneSHOP.Models.Base
{
    public class Item : BaseClass
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Brand Brand { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
    
