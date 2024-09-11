namespace Admin.Models
{
    public class EditUserViewModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CurrentPassword { get; set; }  // Để xác thực mật khẩu hiện tại
        public string NewPassword { get; set; }
    }
}
