using Abp.Domain.Entities;
using CometSocial.CometInteractions;
using CometSocial.CometPosts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CometSocial.CometPostsInteractions
{
    [Table("CometPostsInteractions")]
    public class CometPostsInteraction : Entity
    {
        [ForeignKey("PostId")]
        public CometPost Post { get; set; }
        public int PostId { get; set; }

        [ForeignKey("InteractionId")]
        public CometInteraction Interaction { get; set; }
        public int InteractionId { get; set; }
        public DateTime Date { get; set; }
    }
}
