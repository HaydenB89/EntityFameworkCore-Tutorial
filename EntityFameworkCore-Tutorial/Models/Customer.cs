using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFameworkCore_Tutorial.Models {
    public class Customer {
        public int Id { get; set; }                 // EntitiyFramework(EF) will assume 'Id' is the primary key
        public string Name { get; set; }
        public bool Active { get; set; } //= true;
        public decimal Sales { get; set; }
        public DateTime Updated { get; set; }
    }
}
