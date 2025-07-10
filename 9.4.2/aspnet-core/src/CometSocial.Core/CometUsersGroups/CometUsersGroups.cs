using Abp.Domain.Entities;
using CometSocial.CometGroups;
using CometSocial.CometUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CometSocial.CometUsersGroups
{
    [Table("CometUsersGroups")]
    public class CometUsersGroup : Entity
    {
        [ForeignKey("UserId")]
        public CometUser User { get; set; }
        public int UserId { get; set; }

        [ForeignKey("GroupId")]
        public CometGroup Group { get; set; }
        public int GroupId { get; set; }
    }
}
