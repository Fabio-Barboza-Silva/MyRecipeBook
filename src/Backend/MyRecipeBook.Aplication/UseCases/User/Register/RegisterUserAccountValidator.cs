using FluentValidation;
using MyRecipeBook.Communication.Requests;

namespace MyRecipeBook.Aplication.UseCases.User.Register;

public class RegisterUserAccountValidator : AbstractValidator<RequestRegisterUserAccountJson>
{
    public RegisterUserAccountValidator()
    {
        RuleFor(user => user.Name).NotEmpty().WithMessage("O nome nao pode ser vazio");
        RuleFor(user => user.Email).NotEmpty().WithMessage("o email nao pode ser vazio");
        RuleFor(user => user.Password).NotEmpty().WithMessage("A senha nao pode ser vazia");
        When(user => string.IsNullOrWhiteSpace(user.Email) == false, () =>
        {
            RuleFor(user => user.Email).EmailAddress().WithMessage("o email nao pode ser valido");
        });
    }
}
 