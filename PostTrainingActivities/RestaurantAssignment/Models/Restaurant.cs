using System;
using System.Collections.Generic;

namespace RestaurantAssignment.Models;

public partial class Restaurant
{
    public int RestaurantId { get; set; }

    public string? RestaurantName { get; set; }

    public string? Grade { get; set; }

    public string? Street { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public virtual ICollection<RestaurantCuisine> RestaurantCuisines { get; } = new List<RestaurantCuisine>();

    public virtual ICollection<RestaurantMenu> RestaurantMenus { get; } = new List<RestaurantMenu>();

    public virtual ICollection<Score> Scores { get; } = new List<Score>();
}
