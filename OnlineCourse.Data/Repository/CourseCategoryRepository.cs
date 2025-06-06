using OnlineCourse.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace OnlineCourse.Data.Repository
{
    public class CourseCategoryRepository : ICourseCategoryRepository 
    {
        private readonly OnlineCourseDbContext dbContext;

        public CourseCategoryRepository(OnlineCourseDbContext _dbContext)
        {
            this.dbContext = _dbContext;
        }

        public Task<CourseCategory?> GetByIdAsync(int id)
        {
            var data = this.dbContext.CourseCategories.FirstOrDefaultAsync(x => x.CategoryId == id);
            return data;
        }

        public Task<List<CourseCategory?>> GetAllAsync()
        {
            var data = this.dbContext.CourseCategories.ToListAsync();
            return data;
        }

        //Task<Core.Entities.CourseCategory?> ICourseCategoryRepository.GetByIdAsync(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //Task<List<Core.Entities.CourseCategory?>> ICourseCategoryRepository.GetAllAsync()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
