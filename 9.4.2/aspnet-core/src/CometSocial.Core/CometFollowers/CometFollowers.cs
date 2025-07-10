using Abp.Domain.Entities;
using CometSocial.CometUsers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CometSocial.CometFollowers
{
    [Table("CometFollowers")]
    public class CometFollower : Entity
    {
        [ForeignKey("UserFollowToId")]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public CometUser UserFollowTo { get; set; }
        public int UserFollowToId { get; set; }

        [ForeignKey("UserFollowFromId")]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public CometUser UserFollowFrom { get; set; }
        public int UserFollowFromId { get; set; }
    }
}
