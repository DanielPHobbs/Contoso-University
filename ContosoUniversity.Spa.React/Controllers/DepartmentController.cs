namespace ContosoUniversity_Spa_React.Controllers
{
    [Route("api/[controller]")]
    public class DepartmentController : Controller
    {
        private readonly IRepository<Department> _departmentRepo;
        private readonly IMapper _mapper;

        public DepartmentController(UnitOfWork<ApiContext> unitOfWork, IMapper mapper)
        {
            _departmentRepo = unitOfWork.DepartmentRepository;
            _mapper = mapper;
        }

        public IEnumerable<string> Get()
        {
            return _departmentRepo.GetAll().Select(d => d.Name).ToArray();
        }

        [HttpGet("[action]")]
        public IEnumerable<DepartmentDTO> Details()
        {
            return _departmentRepo.GetAll().Select(d => _mapper.Map<DepartmentDTO>(d)).ToArray();
        }
    }
}