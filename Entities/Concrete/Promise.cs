using Entities.Concrete;

public class Promise
{
    public int PromiseID { get; set; }
    public int CandidateID { get; set; }
    public int PartyId { get; set; }
    public string PromiseText { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public bool Status { get; set; }
    public int Count { get; set; }
   
}
