using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public interface ICategoryDal : IRepository<Category>
    {
    }
}