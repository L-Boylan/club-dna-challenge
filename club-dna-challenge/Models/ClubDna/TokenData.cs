namespace club_dna_challenge.Models;

public class TokenData
{
    public string Token { get; set; }
    public string RefreshToken { get; set; }
    public string? UserImageUrl { get; set; }
    public string RefreshTokenExpiryTime { get; set; }
    public string? LandingPageUrl { get; set; }
    public bool SignNowAccessRequired { get; set; }
    public bool TwoFactorEnabled { get; set; }
    public bool TwoFactorRequired { get; set; }
    public string? AuthenticatorUri { get; set; }
    public string? SharedKey { get; set; }
    public int TwoFactorMethod { get; set; }
    public int DefaultSquadId { get; set; }
    public string DefaultSquadName { get; set; }
    public string TenantLogoURL { get; set; }
}