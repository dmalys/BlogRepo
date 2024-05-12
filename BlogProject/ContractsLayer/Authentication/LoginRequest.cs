namespace ContractsLayer.Authentication
{
    public record LoginRequest
    (
        string Email,
        string Password);
}