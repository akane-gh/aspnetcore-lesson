using System.ComponentModel.DataAnnotations;

namespace TodoManager09.Models;

public class LoginInputModel
{
    [Required]
    [EmailAddress]
    [Display(Name = "メールアドレス")]
    public string Email { get; set; } = "";

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "パスワード")]
    public string Password { get; set; } = "";
}
