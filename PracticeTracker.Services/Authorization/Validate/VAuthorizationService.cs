using PracticeTracker.Tools.Types;

namespace PracticeTracker.Services.Authorization.Validate;

public abstract class VAuthorizationService
{
    public List<Error> ValidateLoginAndPassword(string login, string password)
    {
        List<Error> errors = new List<Error>();

        if (String.IsNullOrWhiteSpace(login))
        {
            errors.Add(new Error("Введите логин"));
        }
        if (String.IsNullOrWhiteSpace(password))
        {
            errors.Add(new Error("Введите пароль"));
        }

        return errors;
    }
}