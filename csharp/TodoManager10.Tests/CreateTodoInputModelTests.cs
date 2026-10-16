using System.ComponentModel.DataAnnotations;
using TodoManager10.Models;

namespace TodoManager10.Tests;

public class CreateTodoInputModelTests
{
    [Fact]
    public void Titleが空なら検証エラーになる()
    {
        var input = new CreateTodoInputModel { Title = "" };
        var results = new List<ValidationResult>();

        var isValid = Validator.TryValidateObject(
            input,
            new ValidationContext(input),
            results,
            validateAllProperties: true);

        Assert.False(isValid);
        Assert.Contains(results, result =>
            result.MemberNames.Contains(nameof(CreateTodoInputModel.Title)));
    }
}
