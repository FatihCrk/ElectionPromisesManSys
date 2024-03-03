using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPartyService
    {

        IDataResult<List<Party>> GetAll();

        IDataResult<List<Party>> GetById(int id);

        IResult Add(Party party);
        IResult Update(Party party);
        IResult Delete(Party party);


        IDataResult<List<PartyDetailDTO>> GetPartyDetailId(int id);


    
    }
}
