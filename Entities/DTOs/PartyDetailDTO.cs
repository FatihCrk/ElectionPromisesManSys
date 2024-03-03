public class PartyDetailDTO
{
    public int PartyID { get; set; }
    public string PartyName { get; set; }
    public List<CandidateDetailDTO> Candidates { get; set; }
}
