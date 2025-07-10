using Abp.Domain.Entities;
using CometSocial.CometUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CometSocial.CometPosts
{
    [Table("CometPosts")]
    public class CometPost : Entity
    {
        [ForeignKey("UserId")]
        public CometUser User { get; set; }
        public int UserId { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
