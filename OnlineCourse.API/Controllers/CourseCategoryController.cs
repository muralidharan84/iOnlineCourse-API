using Microsoft.AspNetCore.Mvc;
using OnlineCourse.Service.Services;

namespace OnlineCourse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseCategoryController : ControllerBase
    {

        private readonly ILogger<CourseCategoryController> _logger;
        private readonly ICourseCategoryService _categoryCourseService;
        public CourseCategoryController(ILogger<CourseCategoryController> _logger, ICourseCategoryService _categoryCourseService)
        {
            this._logger = _logger;
            this._categoryCourseService = _categoryCourseService;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCoursesCategoriesByIdAsync(int id)
        {
            try
            {
                var data = await _categoryCourseService.GetByIdAsync(id);
                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving course categories.");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error.");
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetCoursesCategoriesAsync() { 
            try
            {
                var data = await _categoryCourseService.GetCoursesCategoriesAsync();
                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving course categories.");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error.");
            }

        }
    }
}
