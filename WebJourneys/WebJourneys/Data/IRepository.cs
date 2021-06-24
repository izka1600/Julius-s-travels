using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebJourneys.Models;
using WebJourneys.ViewModels;

namespace WebJourneys.Data
{
	public interface IRepository
	{
		List<Post> GetAllPosts();
		IndexViewModel GetAllPoints();
		void AddPost(Post post);
		void UpdatePost(Post post);

		Task<bool> SaveChangesAsync();
	}
}
