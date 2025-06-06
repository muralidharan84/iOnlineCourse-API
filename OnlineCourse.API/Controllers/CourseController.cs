using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineCourse.Core.Models;
using OnlineCourse.Service.Services;

namespace OnlineCourse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class CourseController : ControllerBase
    {
        private readonly ILogger<CourseController> _logger;
        private readonly ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
           // this._logger = _logger;
            this._courseService = courseService;
        }

        //These 3 get methods are publicly available from our UI, no need to authenticate!
        // GET: api/Course
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<CourseModel>>> GetAllCoursesAsync()
        {
            var courses = await _courseService.GetAllCoursesAsync();
            return Ok(courses);
        }

        // GET: api/Course/ByCategory?categoryId=1
        [HttpGet("Category/{categoryId}")]
        [AllowAnonymous]
        public async Task<ActionResult<List<CourseModel>>> GetAllCoursesByCategoryIdAsync([FromRoute] int categoryId)
        {
            var courses = await _courseService.GetAllCoursesAsync(categoryId);
            return Ok(courses);
        }

        // GET: api/Course/Detail/5
        [HttpGet("Detail/{courseId}")]
        [AllowAnonymous]
        public async Task<ActionResult<CourseDetailModel>> GetCourseDetailAsync(int courseId)
        {
            var courseDetail = await _courseService.GetCourseDetailAsync(courseId);
            if (courseDetail == null)
            {
                return NotFound();
            }
            return Ok(courseDetail);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCourseById(int id)
        {
            var course = await _courseService.GetCourseDetailAsync(id);
            if (course == null)
            {
                return NotFound();
            }
            return Ok(course);
        }
       
    }
}
