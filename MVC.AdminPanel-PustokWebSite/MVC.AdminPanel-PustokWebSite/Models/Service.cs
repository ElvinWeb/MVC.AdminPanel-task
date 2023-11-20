using System.ComponentModel.DataAnnotations;

namespace MVC.AdminPanel_PustokWebSite.Models
{
    public class Service
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:30)]
        public string Title { get; set; }
        [Required]
        [StringLength(maximumLength:50)]
        public string Desc { get; set; }
        [Required]
        public string Icon { get; set; }
    }
}
