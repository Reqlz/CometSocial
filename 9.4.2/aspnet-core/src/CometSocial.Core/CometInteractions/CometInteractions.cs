using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CometSocial.CometInteractions
{
    [Table("CometInteractions")]
    public class CometInteraction : Entity
    {
        public int InteractionId { get; set; }
    }
}
