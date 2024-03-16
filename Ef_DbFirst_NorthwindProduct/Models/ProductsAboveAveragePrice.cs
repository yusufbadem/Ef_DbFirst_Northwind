using System;
using System.Collections.Generic;

namespace Ef_DbFirst_NorthwindProduct.Models;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
