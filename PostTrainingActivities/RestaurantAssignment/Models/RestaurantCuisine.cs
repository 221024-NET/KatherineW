using System;
using System.Collections.Generic;

namespace RestaurantAssignment.Models;

public partial class RestaurantCuisine
{
    public int RcId { get; set; }

    public int? RcRestaurantId { get; set; }

    public int? RcCuisineId { get; set; }

    public virtual Cuisine? RcCuisine { get; set; }

    public virtual Restaurant? RcRestaurant { get; set; }
}
