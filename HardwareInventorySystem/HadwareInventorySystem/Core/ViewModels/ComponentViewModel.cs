using HadwareInventorySystem.Core.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace HadwareInventorySystem.Core.ViewModels
{
    public class ComponentViewModel
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [StringLength(150), Required(ErrorMessage = "Enter the component description")]
        public string Description { get; set; }

        [Display(Name = "Serial Number")]
        [StringLength(50), Required(ErrorMessage = "Enter the serial number")]
        public string SerialNumber { get; set; }

        [ScaffoldColumn(false)]
        public byte[] Photo { get; set; }
        [ScaffoldColumn(false)]
        public int ComponentTypeId { get; set; }
        [ScaffoldColumn(false)]
        public ComponentTypeViewModel ComponentType { get; set; }

        public IEnumerable<ComponentType> ComponentTypes { get; set; }

        [Required]
        [DataType(DataType.Upload)]
        [Display(Name = "Choose File")]
        public HttpPostedFileBase Image { get; set; }
    }
}