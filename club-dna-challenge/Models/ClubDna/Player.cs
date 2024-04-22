namespace club_dna_challenge.Models;

public class Player
{
    public string Id { get; set; }
    public string Forename { get; set; }
    public string Surname { get; set; }
    public DateTime DateOfBirth { get; set; }
    public List<Salary> MonthlySalary { get; set; }
    public string Club { get; set; }
    public string Squad { get; set; }
    public DateTime ContractEndDate { get; set; }
    public string Position { get; set; }
    public string PhotoUrl { get; set; }
    
}