namespace club_dna_challenge.Models;

public class GetPlayerDataClubDnaResponse
{
    public int TotalRecords { get; set; }
    public int CurrentPage { get; set; }
    public int TotalPages { get; set; }
    public List<Player> Players { get; set; }
}