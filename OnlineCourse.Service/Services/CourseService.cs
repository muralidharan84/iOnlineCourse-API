using OnlineCourse.Core.Models;
using OnlineCourse.Data.IRepository;

namespace OnlineCourse.Service.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository courseRepository;
        public CourseService( ICourseRepository courseRepository)
        {
            this.courseRepository = courseRepository;
           
        }

        public Task<List<CourseModel>> GetAllCoursesAsync(int? categoryId = null)
        {
            return courseRepository.GetAllCoursesAsync(categoryId);
        }

        public Task<CourseDetailModel> GetCourseDetailAsync(int courseId)
        {
            return courseRepository.GetCourseDetailAsync(courseId);
        }
    }
}