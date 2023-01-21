using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreEnigma.Database
{
    [Table("Parents", Schema = "dbo")]
    public class Parents
    {
        [Key]
        public Guid ParentId { get; set; }
        
        [Required]
        [Column(TypeName = "NVarchar(200)")]
        [Display(Name = "Parent Name")]
        public string ParentName { get; set; }

        public string Address { get; set; }
    }
}
