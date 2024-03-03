using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;


namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Candidate>> GetAll();
        IDataResult<Candidate> GetById(int id);



        IResult Add(Candidate candidate);
        IResult Update(Candidate candidate);
        IResult Delete(Candidate candidate);

        IDataResult<List<CandidateDetailDTO>> GetCandidateDetails();


        IResult AddTransactionalTest(Candidate candidate);

    }
}
