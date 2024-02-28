using Entities.Concrete;

public class Promise
{
    public int PromiseID { get; set; }
    public string PromiseText { get; set; }
    public int CandidateID { get; set; }
    public Candidate Candidate { get; set; }
}
