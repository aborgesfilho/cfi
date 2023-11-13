using System;

namespace CFI.Interfaces
{
    interface ICategory
    {
        int CategoryId { get; set; }
        double MinimumValue { get; set; }
        double MaximumValue { get; set; }
        string Code { get; set; }
        string Description { get; set; }

    }
}
