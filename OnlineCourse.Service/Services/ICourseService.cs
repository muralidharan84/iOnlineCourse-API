using OnlineCourse.Core.Models;

namespace OnlineCourse.Service.Services
{
    public interface ICourseService
    {
        public Task<List<CourseModel>> GetAllCoursesAsync(int? categoryId = null);
        public Task<CourseDetailModel> GetCourseDetailAsync(int courseId);
        //Task AddCourseAsync(CourseDetailModel courseModel);
        //Task UpdateCourseAsync(CourseDetailModel courseModel);
        //Task DeleteCourseAsync(int courseId);
        //Task<List<InstructorModel>> GetAllInstructorsAsync();
        //Task<bool> UpdateCourseThumbnail(string courseThumbnailUrl, int courseId);
    }
}
