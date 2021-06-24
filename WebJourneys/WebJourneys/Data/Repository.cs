using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebJourneys.Models;
using WebJourneys.ViewModels;

namespace WebJourneys.Data
{
	public class Repository:IRepository
	{
		private JuliusContext _ctx;

		public Repository(JuliusContext ctx)
		{
			_ctx = ctx;
		}

		public void AddPost(Post post)
		{
			_ctx.Posts.Add(post);
		}

		public List<Post> GetAllPosts()
		{
			return _ctx.Posts.ToList();
		}

		//public List<Point> GetAllPoints()
		//{
		//	return _ctx.Points.ToList();
		//}

		public IndexViewModel GetAllPoints()
		{
			return new IndexViewModel
			{
				Points = _ctx.Points.ToList()
			};
		}

		public void UpdatePost(Post post)
		{
			_ctx.Posts.Update(post);
		}

		public async Task<bool> SaveChangesAsync()
		{
			if (await _ctx.SaveChangesAsync() > 0)
			{
				return true;
			}
			return false;
		}
	}
}
