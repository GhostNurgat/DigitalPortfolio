using System.ComponentModel.DataAnnotations;

namespace DigitalPortfolio.ViewModels;

public class RegisterViewModel
{
    [Required(ErrorMessage = "Имя пользователя обязательно")]
    [Display(Name = "Имя пользователя")]
    public string? UserName { get; set; }

    [Required(ErrorMessage = "Email обязательно")]
    [DataType(DataType.EmailAddress, ErrorMessage = "Не соотвествует адресу электронной почты")]
    [Display(Name = "Email")]
    public string? EmailAddress { get; set; }

    [Required(ErrorMessage = "Номер телефона обязательно")]
    [DataType(DataType.PhoneNumber, ErrorMessage = "Не соотвуствует номеру телефона")]
    [Display(Name = "Номер телефона")]
    public string? PhoneNumber { get; set; }

    [Required(ErrorMessage = "Пароль обязательно")]
    [DataType(DataType.Password)]
    [MinLength(5, ErrorMessage = "Пароль не содержит меньше 5 символов")]
    [Display(Name = "Пароль")]
    public string? Password { get; set; }

    [Required(ErrorMessage = "Подтвердите пароль")]
    [Compare("Password", ErrorMessage = "Пароли не совпадают")]
    [DataType(DataType.Password)]
    [Display(Name = "Подтвердите пароль")]
    public string? PasswordConfirm { get; set; }
}