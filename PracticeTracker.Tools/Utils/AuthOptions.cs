using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace PracticeTracker.Tools.Utils;

public class AuthOptions
{
    public const string ISSUER = "PracticeTracker.WebAPI"; // издатель токена
    public const string AUDIENCE = "PracticeTracker.Client"; // потребитель токена
    const string KEY = "vi!i0Vot8t-Bos3nwk*.X1xQOCB-EB.7^+_XR)q"; // ключ для шифрации
    public static SymmetricSecurityKey GetSymmetricSecurityKey() => 
        new SymmetricSecurityKey(Encoding.UTF8.GetBytes(KEY));
}