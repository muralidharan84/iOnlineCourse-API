using OnlineCourse.Core.Models;

namespace OnlineCourse.Service.Services
{
    public interface ICourseCategoryService
    {

        /// <summary>
        /// Retrieves a list of courses associated with a specific category.
        /// </summary>
        /// <param name="categoryId">The ID of the category for which to retrieve courses.</param>
        /// <returns>A list of courses belonging to the specified category.</returns>
        Task<CourseCategoryModel?> GetByIdAsync(int categoryId);
        /// <summary>
        /// Retrieves a list of all course categories.
        /// </summary>
        /// <returns>A list of all course categories.</returns>
        Task<List<CourseCategoryModel?>> GetCoursesCategoriesAsync();

    }
}
