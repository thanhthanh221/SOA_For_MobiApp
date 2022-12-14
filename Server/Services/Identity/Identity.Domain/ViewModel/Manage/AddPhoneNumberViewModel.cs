using System.ComponentModel.DataAnnotations;

namespace Identity.Domain.ViewModel.Manage
{
    public class AddPhoneNumberViewModel
    {
        [Required]
        public Guid UserId { get; set; }
        [Required]
        [Phone]
        [StringLength(11)]
        [MinLength(11)]
        public string PhoneNumber { get; set; }
    }
}