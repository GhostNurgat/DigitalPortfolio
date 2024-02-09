using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DigitalPortfolio.Models;

public class User : IdentityUser<int>
{
    public string? Surname { get; set; }

    public string? Name { get; set; }

    public string? Patronymic { get; set; }

    [DataType(DataType.Date)]
    public DateTime BirthDate { get; set; }

    public string? Contacts { get; set; }
}