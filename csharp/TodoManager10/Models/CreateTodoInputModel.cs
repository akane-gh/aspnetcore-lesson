using System.ComponentModel.DataAnnotations;

namespace TodoManager10.Models;

public class CreateTodoInputModel
{
    [Required(ErrorMessage = "TODO 名を入力してください")]
    [StringLength(100, ErrorMessage = "TODO 名は100文字以内で入力してください")]
    public string Title { get; set; } = "";
}
