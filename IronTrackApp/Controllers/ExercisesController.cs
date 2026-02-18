using IronTrackApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IronTrackApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExercisesController : ControllerBase
    {
        private readonly IronTrackDbContext _context;

        public ExercisesController(IronTrackDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetExercises()
        {
            var workouts = await _context.Exercises.ToListAsync();
            return Ok(workouts);
        }
    }
}
