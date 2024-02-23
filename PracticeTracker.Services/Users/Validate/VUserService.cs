using PracticeTracker.Tools.Types;

namespace PracticeTracker.Services.Users.Validate;

public class VUserService
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