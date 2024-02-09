using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigitalPortfolio.Models;

public class Resume
{
    [Key]
    public int ResumeId { get; set; }

    [Required]
    public int Id { get; set; }

    [Required]
    public string? AboutMe { get; set; }

    [Required]
    public string? Education { get; set; }

    [Required]
    public string? Skill { get; set; }

    public User User { get; set; } = new User();
}