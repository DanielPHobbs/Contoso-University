namespace ContosoUniversity_Spa_React.Controllers
{
    [Route("api/[controller]")]
    public class CoursesController : Controller
    {
        private readonly IRepository<Course> _coursesRepo;
        private readonly IMapper _mapper;

        public CoursesController(UnitOfWork<ApiContext> unitOfWork, IMapper mapper)
        {
            _coursesRepo = unitOfWork.CourseRepository;
            _mapper = mapper;
        }

        public IEnumerable<Course> Get()
        {
            return _coursesRepo.GetAll().ToArray();
        }
    }
}