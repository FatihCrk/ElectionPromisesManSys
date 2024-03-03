using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryPromiseDal : IPromiseDal
    {
        List<IPromiseDal> _promises;

        public InMemoryPromiseDal()
        {
            _promises = new List<Promise>
            {
                new Promise{PromiseID=1, PromiseText="Vaat Edilen İçerik 1"},
                new Promise{PromiseID=2, PromiseText="Vaat Edilen İçerik 2"},
                new Promise{PromiseID=3, PromiseText="Vaat Edilen İçerik 3"}
            };
        }

        public List<PromiseDTO> GetPromiseDetails(Expression<Func<Promise, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
