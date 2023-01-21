using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanEF.Database
{
    [Table("Customer",Schema = "dbo")]
    public class Customer
    {
        [Key]
        [Display(Name ="CostumerId")]
        public int CostumerId { get; set; }
        
        [Display(Name ="Costumer Name")]
        [Column(TypeName ="NVarchar(50)")]
        [Required]
        public string CustomerName { get; set; }

        [Display(Name ="Mobile Number")]
        [Column(TypeName ="Nvarchar(13)")]
        public string? MobileNumber { get; set; }
    }
}
