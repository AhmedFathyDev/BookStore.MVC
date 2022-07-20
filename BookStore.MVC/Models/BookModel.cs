using System.ComponentModel.DataAnnotations;

namespace BookStore.MVC.Models;

public class BookModel
{
    [Key][Required] public int Id { get; set; }

    [Required] public string Title { get; set; } = null!;
    [Required] public string Author { get; set; } = null!;
}