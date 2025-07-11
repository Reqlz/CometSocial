using Abp.Domain.Repositories;
using AutoMapper.Internal.Mappers;
using Castle.Core.Logging;
using CometSocial.CometPosts.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CometSocial.CometPosts
{
	public class CometPostService : CometSocialAppServiceBase
	{

		private readonly IRepository<CometPost> _cometPostRepo;
		private readonly ILogger _logger;

		public CometPostService(
			IRepository<CometPost> cometPostRepo,
			ILogger logger
		)
		{
			_cometPostRepo = cometPostRepo;
			_logger = logger;
		}


		public async Task<GetAllCometPostsOutput> GetAllCometPosts()
		{

			var output = new GetAllCometPostsOutput();

			var posts = await _cometPostRepo.GetAll().ToListAsync();

			output.Posts = ObjectMapper.Map<List<CometPostDto>>(posts);

			return output;

		}


		/// <summary>
		/// Create a new post
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public async Task<CreateNewPostOutput> CreateNewPost(CreateNewPostInput input)
		{
			var output = new CreateNewPostOutput();

			try
			{
				var newPost = new CometPost()
				{
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					UserId = input.UserId,
				};
				var result = _cometPostRepo.Insert(newPost);

				output.PostId = result.Id;
			}
			catch (Exception ex)
			{

				_logger.Error("Error creating a new post.", ex);

			}

			return output;

		}

	}


	

	
}
