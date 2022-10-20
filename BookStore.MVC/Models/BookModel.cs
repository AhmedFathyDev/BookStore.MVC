using System.ComponentModel.DataAnnotations;

namespace BookStore.MVC.Models;

public class BookModel
{
    [Key] public int Id { get; init; }

    public string Title { get; set; } = null!;
    public string Author { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Category { get; set; } = null!;
    public int TotalPages { get; set; }
    
    public Uri CoverImageUri { get; set; } = null!;
    public Uri BookPdfUri { get; set; } = null!;
    
    public DateTime? CreatedOn { get; set; } = null!;
    public DateTime? UpdatedOn { get; set; } = null!;
}