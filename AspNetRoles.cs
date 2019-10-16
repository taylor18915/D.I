using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace D.I_Tech_Nigh_School.Data
{
    public class AspNetRoles
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string  Name { get; set; }
        public string NormalizedName { get; set; }
        public int Concurrencystamp { get; set; }
        


    }
}
