using Abp.Domain.Repositories;
using CometSocial.CometUsers.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CometSocial.CometUsers
{
	public class CometUserService : CometSocialAppServiceBase, ICometUserService
	{

		private readonly IRepository<CometUser> _cometUserRepo;

		public CometUserService(
			IRepository<CometUser> cometUserRepo
		)
		{
			_cometUserRepo = cometUserRepo;
		}


		public async Task<GetAllCometUsersOutput> GetAllCometUsers()
		{
			var output = new GetAllCometUsersOutput();

			var cometUsers = await _cometUserRepo.GetAll().ToListAsync();

			output.CometUsers = ObjectMapper.Map<List<CometUserDto>>(cometUsers);

			return output;
		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public GetUserByIdOutput GetUserById(GetUserByIdInput input)
		{
			var output = new GetUserByIdOutput();

			var cometUser = _cometUserRepo.GetAll().Where(u => u.Id == input.UserId).ToList().FirstOrDefault();

			output.CometUser = ObjectMapper.Map<CometUserDto>(cometUser);

			return output;
		}


	}
}
