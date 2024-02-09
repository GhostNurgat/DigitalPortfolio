using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigitalPortfolio.Models;

public class Portfolio
{
    [Key]
    public int PortfolioId { get; set; }

    [Required]
    public int Id { get; set; }

    [Required, StringLength(100)]
    public string? Title { get; set; }

    [StringLength(100)]
    public string? MainScreen { get; set; }

    public string? Description { get; set; }

    [Required]
    public string? Repository { get; set; }

    public User User { get; set; } = new User();
}