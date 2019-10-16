using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace D.I_Tech_Nigh_School.Data
{
    public class AspNetUserroles
    {
       [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}
