using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.Models {

    public class ProductViewModel {
        [Required]
        public int Id { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public int InventoryValue { get; set; }
        [Required]
        public string Name { get; set; }




    }
}
