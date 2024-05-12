using ApplicationLayer.Common.Interfaces;

namespace InfrastructureLayer.Authentication
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
