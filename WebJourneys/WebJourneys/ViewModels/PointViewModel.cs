using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebJourneys.ViewModels
{
	public class PointViewModel
	{
		public decimal? Longtitude { get; set; }
		public decimal? Latitude { get; set; }
		public string Popup { get; set; }
		public int? PostId { get; set; }
	}
}
