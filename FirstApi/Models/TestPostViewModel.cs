using System.ComponentModel.DataAnnotations;

namespace FirstApi.Models;

public class TestPostViewModel
{
    [Required]
    public int I {get; set;}
    [MaxLength(6)]
    public string? Name {get; set;}
}
