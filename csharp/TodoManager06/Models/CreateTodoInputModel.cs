using System.ComponentModel.DataAnnotations;

namespace TodoManager06.Models;

public class CreateTodoInputModel
{
    [Required(ErrorMessage = "TODO 名を入力してください")]
    [StringLength(100, ErrorMessage = "TODO 名は100文字以内で入力してください")]
    [Display(Name = "TODO 名")]
    public string Title { get; set; } = "";

    [StringLength(500, ErrorMessage = "説明は500文字以内で入力してください")]
    [Display(Name = "説明")]
    public string? Description { get; set; }
}
