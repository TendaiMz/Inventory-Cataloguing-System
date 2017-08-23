using System.ComponentModel.DataAnnotations;

namespace HadwareInventorySystem.Core.ViewModels
{
    public class ComponentTypeViewModel
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Display(Name = "Type Name")]
        [StringLength(150), Required(ErrorMessage = "Enter the component type name")]
        public string Name { get; set; }
    }
}