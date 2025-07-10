using Abp.Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CometSocial.CometGroups
{
    [Table("CometGroups")]
    public class CometGroup : Entity
    {
        public string Name { get; set; }
    }
}
