using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services.Authentication
{
    public record AuthentictationResult
    (
        Guid Id,
        string FirstName,
        string LastName,
        string Email,
        string Token
        );
}
