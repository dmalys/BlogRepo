namespace ApplicationLayer.Common.Interfaces
{
    public interface IJwtTokenGenerator
    {
        string GenerateJwtToken(Guid userId, string firstName, string lastName);
    }
}
