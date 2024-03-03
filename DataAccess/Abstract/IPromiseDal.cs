

using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IPromiseDal
    {
        List<PromiseDTO> GetPromiseDetails(Expression<Func<Promise, bool>> filter = null);
    }
}
