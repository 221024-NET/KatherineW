using System;
using System.Collections.Generic;

namespace RestaurantAssignment.Models;

public partial class Score
{
    public int ScoreId { get; set; }

    public int? Score1 { get; set; }

    public DateTime? Date { get; set; }

    public int? ScoredRestaurantId { get; set; }

    public virtual Restaurant? ScoredRestaurant { get; set; }
}
