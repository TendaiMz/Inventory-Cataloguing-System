using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HadwareInventorySystem.Core.Models
{
    public class Component
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(150), Required]
        public string Description { get; set; }
        [StringLength(50), Required]
        public string SerialNumber { get; set; }
        public byte[] Photo { get; set; }
        public int ComponentTypeId { get; set; }
        public ComponentType ComponentType { get; set; }
    }

}