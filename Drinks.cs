using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace D.I_Tech_Nigh_School.Data
{
    public class Drinks
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DID { get; set; }
        public string DName { get; set; }
        public int Dflavor { get; set; }
        public int Dsize { get; set; }
    }
}
