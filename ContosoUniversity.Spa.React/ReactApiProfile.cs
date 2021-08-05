namespace ContosoUniversity.Spa.React
{
    public class ReactApiProfile : Profile
    {
        public ReactApiProfile()
        {
            CreateMap<DepartmentDTO, Department>().ReverseMap();
        }
    }
}
