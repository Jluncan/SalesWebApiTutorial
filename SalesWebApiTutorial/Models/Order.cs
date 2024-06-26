﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesWebApiTutorial.Models {
    public class Order {

        public int Id { get; set; }
        [StringLength(80)]
        public string Description { get; set; } = string.Empty;
        //NEW,SHIPPED
        [StringLength(80)]
        public string Status { get; set; } = string.Empty;
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; } // this tells EF that customerId is a foreign key
        [Column(TypeName = "DateTime")]
        public DateTime Date { get; set; }
        [Column(TypeName ="decimal(11,2)")]
        public decimal Total { get; set; } 
    }
}
