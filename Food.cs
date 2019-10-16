using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace D.I_Tech_Nigh_School.Data
{
    public class Food
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FID { get; set; }
        public string FName { get; set; }
        public int Fprice { get; set; }
        public int Ftype { get; set; }


        // foreign key connects Manufacturer table
        public int DID { get; set; }
        [ForeignKey("DID")]
        public Drinks drinks { get; set; }


    }
}
