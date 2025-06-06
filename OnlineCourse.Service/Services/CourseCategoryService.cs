using OnlineCourse.Core.Models;
using OnlineCourse.Data.Repository;

namespace OnlineCourse.Service.Services
{
    public class CourseCategoryService : ICourseCategoryService
    {
        private readonly ICourseCategoryRepository _ICourseCategoryRepository;
        public CourseCategoryService(ICourseCategoryRepository ICourseCategoryRepository)
        {
            this._ICourseCategoryRepository = ICourseCategoryRepository;
                
        }

        public async Task<CourseCategoryModel?> GetByIdAsync(int categoryId)
        {
             var data = await _ICourseCategoryRepository.GetByIdAsync(categoryId);
            return new CourseCategoryModel
             {
                 CategoryId = data.CategoryId,
                 CategoryName = data.CategoryName,
                 Description = data.Description
             };
          
        }

        public async Task<List<CourseCategoryModel?>> GetCoursesCategoriesAsync()
        {
            var data = await _ICourseCategoryRepository.GetAllAsync();
            var dataModel =  data.Select(c=> new CourseCategoryModel
            {
                CategoryId = c.CategoryId,
                CategoryName = c.CategoryName,
                Description = c.Description
            }).ToList();

            return dataModel;
        }
    }
}
