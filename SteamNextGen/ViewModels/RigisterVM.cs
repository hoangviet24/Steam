using System.ComponentModel.DataAnnotations;

namespace SteamNextGen.ViewModels
{
    public class RigisterVM
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Cannot Emtype")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Cannot Emtype")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Cannot Emtype")]
        [EmailAddress(ErrorMessage ="Invalid Email")]
        public string Password {  get; set; }
        [Required(ErrorMessage = "Cannot Emtype")]
        [Compare("Password",ErrorMessage ="Password and Confirm Password is wrong")]
        public StreamReader ConfirmPassword { get; set; }
    }
}
