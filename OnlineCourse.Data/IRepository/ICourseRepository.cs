using OnlineCourse.Core.Models;

namespace OnlineCourse.Data.IRepository
{
    public interface ICourseRepository
    {
        public Task<List<CourseModel>> GetAllCoursesAsync(int? categoryId = null);
        public Task<CourseDetailModel> GetCourseDetailAsync(int courseId);
    }
}
