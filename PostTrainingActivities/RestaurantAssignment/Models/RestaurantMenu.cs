using System;
using System.Collections.Generic;

namespace RestaurantAssignment.Models;

public partial class RestaurantMenu
{
    public int RmId { get; set; }

    public int? RmRestaurantId { get; set; }

    public int? RmMenuItemId { get; set; }

    public virtual MenuItem? RmMenuItem { get; set; }

    public virtual Restaurant? RmRestaurant { get; set; }
}
