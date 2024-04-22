namespace club_dna_challenge.Models;

public class GetTokenResponse
{
    public TokenData Data { get; set; }
    public List<string> Messages { get; set; }
    public bool Succeeded { get; set; }
}