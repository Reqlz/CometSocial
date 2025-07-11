using CometSocial.CometUsers.Dtos;
using System.Threading.Tasks;

namespace CometSocial.CometUsers
{
	public interface ICometUserService
	{
		Task<GetAllCometUsersOutput> GetAllCometUsers();
		GetUserByIdOutput GetUserById(GetUserByIdInput input);
	}
}