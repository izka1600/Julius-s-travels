using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebJourneys.Models;

namespace WebJourneys.ViewModels
{
	public class IndexViewModel
	{
		public IEnumerable<Point> Points { get; set; }
	}
}
