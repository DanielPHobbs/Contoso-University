using ContosoUniversity.Api.DTO;

namespace ContosoUniversity.Api
{
    public class ApiProfile : Profile
    {
        public ApiProfile()
        {
            CreateMap<DepartmentDTO, Department>().ReverseMap();
            CreateMap<CreateDepartmentDTO, Department>().ReverseMap();
        }
    }
}
