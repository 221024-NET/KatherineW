using System;
using System.Collections.Generic;

namespace RestaurantAssignment.Models;

public partial class MenuItem
{
    public int MenuItemId { get; set; }

    public string? ItemName { get; set; }

    public decimal? Price { get; set; }

    public int? MenuCuisine { get; set; }

    public virtual Cuisine? MenuCuisineNavigation { get; set; }

    public virtual ICollection<RestaurantMenu> RestaurantMenus { get; } = new List<RestaurantMenu>();
}
