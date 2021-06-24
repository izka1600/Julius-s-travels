using System;
using System.Collections.Generic;

#nullable disable

namespace WebJourneys.Models
{
    public partial class Point
    {
        public int PointId { get; set; }
        public decimal? Longtitude { get; set; }
        public decimal? Latitude { get; set; }
        public string Popup { get; set; }
        public int? PostId { get; set; }
    }
}
