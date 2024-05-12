using ContractsLayer.Authentication;

namespace ApplicationLayer.Services.Authentication
{
    public interface IAuthenticationService
    {
        Task<AuthentictationResult> Login(LoginRequest loginRequest);
        Task<AuthentictationResult> Register(RegisterRequest registerRequest);

    }
}