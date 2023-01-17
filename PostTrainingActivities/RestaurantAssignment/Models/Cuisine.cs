using System;
using System.Collections.Generic;

namespace RestaurantAssignment.Models;

public partial class Cuisine
{
    public int CuisineId { get; set; }

    public string? CuisineName { get; set; }

    public virtual ICollection<MenuItem> MenuItems { get; } = new List<MenuItem>();

    public virtual ICollection<RestaurantCuisine> RestaurantCuisines { get; } = new List<RestaurantCuisine>();
}
