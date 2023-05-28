using System.ComponentModel.DataAnnotations;

namespace LearnMVCwithFigma.ViewModels
{
    public class AddAccountViewModel
    {
        [Required(ErrorMessage = "Tên đầy đủ không được để trống")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email không được để trống")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        public string PassWord { get; set; }
    }
}
