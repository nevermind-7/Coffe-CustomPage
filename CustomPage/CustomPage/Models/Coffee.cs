using System.ComponentModel.DataAnnotations;
using CustomPage.Repositories.Contacts.Commons;

namespace CustomPage.Models
{
    public class Coffee: IEntity
    {
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
