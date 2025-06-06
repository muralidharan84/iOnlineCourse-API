using OnlineCourse.Core.Entities;

namespace OnlineCourse.Data.Repository
{
    /*
    public interface IRepository<T>
    {
        T? GetById(int id);
        IEnumerable<T?> GetAll();

    }
    */

    /*
    public interface IRepository<T>
    {
        Task<T?> GetByIdAsync(int id);
        Task<List<T?>> GetAllAsync();

    }
    */

    public interface ICourseCategoryRepository
    {
      public Task<CourseCategory?> GetByIdAsync(int id);
       public Task<List<CourseCategory?>> GetAllAsync();

    }

}
