using Abp.AutoMapper;
using CometSocial.CometUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CometSocial.CometPosts.Dtos
{
	[AutoMapFrom(typeof(CometPost))]
	[AutoMapTo(typeof(CometPost))]
	public class CometPostDto
	{
		public CometUser User { get; set; }
		public int UserId { get; set; }

		public DateTime DateCreated { get; set; }
		public DateTime DateUpdated { get; set; }
	}
}
