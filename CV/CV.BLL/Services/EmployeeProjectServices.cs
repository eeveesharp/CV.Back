using AutoMapper;
using CV.BLL.Interfaces;
using CV.BLL.Models;
using CV.DAL.Entities;
using CV.DAL.Interfaces;

namespace CV.BLL.Services
{
    public class EmployeeProjectServices : GenericServices<EmployeeProjectModel, EmployeeProjectEntity>, IEmployeeProjectServices
    {
        public EmployeeProjectServices(IGenericRepository<EmployeeProjectEntity> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}
