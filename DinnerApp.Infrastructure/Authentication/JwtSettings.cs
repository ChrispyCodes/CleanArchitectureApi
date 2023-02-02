namespace DinnerApp.Infrastructure

{
    public class JwtSettings
    {
        public const string SectionName = "JwtSettings";
        public string Issuer { get; init; } = default!;
        public string Secret { get; init; } = default!;
        public int ExpiryMinutes { get; init; } = default!;
        public string Audience { get; init; } = default!;
    }
}