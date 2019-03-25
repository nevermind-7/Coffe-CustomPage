using System.ComponentModel.DataAnnotations;
using CustomPage.App_LocalResources;
using CustomPage.Repositories.Contacts.Commons;

namespace CustomPage.Models
{
    public class Contact: IEntity
    {
        public long Id { get; set; }
        
        [Display(Name = "contact_name_attr", ResourceType = typeof(GlobalRes))]
        [Required(ErrorMessageResourceType = typeof(GlobalRes), ErrorMessageResourceName = "contact_form_name_error")]
        [MaxLength(50, ErrorMessageResourceType = typeof(GlobalRes), ErrorMessageResourceName = "contact_form_name_error_length")]
        public string Name { get; set; }

        [Display(Name = "contact_lastname_attr", ResourceType = typeof(GlobalRes))]
        [Required (ErrorMessageResourceType = typeof(GlobalRes), ErrorMessageResourceName = "contact_form_lastname_error")]
        [MaxLength(50, ErrorMessageResourceType = typeof(GlobalRes), ErrorMessageResourceName = "contact_form_name_error_length")]
        public string Lastname { get; set; }

        [Display(Name = "contact_email_attr", ResourceType = typeof(GlobalRes))]
        [Required(ErrorMessageResourceType = typeof(GlobalRes), ErrorMessageResourceName = "contact_form_email_error")]
        [EmailAddress(ErrorMessageResourceType = typeof(GlobalRes), ErrorMessageResourceName = "contact_form_email_error_type")]
        public string Email { get; set; }

        [Display(Name = "contact_comment_attr", ResourceType = typeof(GlobalRes))]
        [Required (ErrorMessageResourceType = typeof(GlobalRes), ErrorMessageResourceName = "contact_form_comment_error")]
        [MaxLength(400, ErrorMessageResourceType = typeof(GlobalRes), ErrorMessageResourceName = "contact_form_name_error_length")]
        public string Comment { get; set; }
    }
}