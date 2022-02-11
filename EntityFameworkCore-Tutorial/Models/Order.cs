using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFameworkCore_Tutorial.Models {
    public class Order {
        public int Id { get; set; }
        [Required]
        [StringLength(80)]
        public string Description { get; set; }
        [Column(TypeName ="decimal(11,2)")]
        public decimal Total { get; set; }
        public int? CustomerId { get; set; }                // FOREIGN ID,  EF recognizes automatically since the Property has Id in it
                                                            // the '?' says that this cannot be null, this means the Customer mus have an Id
        public virtual Customer Customer { get; set; }     // This will not be in the TABLE only in the CLASS


    }
}
