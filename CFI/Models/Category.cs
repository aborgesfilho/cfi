using CFI.DB;
using CFI.Interfaces;

namespace CFI.Models
{
    public class Category : ICategory
    {
        public Category()
        {
            
        }
        public int CategoryId { get; set; }
        public double MinimumValue { get; set; }
        public double MaximumValue { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public double MarketValue { get; set; }
    }
}
