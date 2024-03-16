using System;
using System.Collections.Generic;

namespace Ef_DbFirst_NorthwindProduct.Models;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
