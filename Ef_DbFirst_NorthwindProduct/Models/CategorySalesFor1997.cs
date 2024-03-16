using System;
using System.Collections.Generic;

namespace Ef_DbFirst_NorthwindProduct.Models;

public partial class CategorySalesFor1997
{
    public string CategoryName { get; set; } = null!;

    public decimal? CategorySales { get; set; }
}
