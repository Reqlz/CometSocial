using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CometSocial.CometUsers.Dtos
{
	[AutoMapFrom(typeof(CometUser))]
	[AutoMapTo(typeof(CometUser))]
	public class CometUserDto: EntityDto
	{
		public string Username { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
	}
}
