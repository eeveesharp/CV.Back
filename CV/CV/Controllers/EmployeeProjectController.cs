using AutoMapper;
using CV.API.ViewModel.EmployeeProject;
using CV.BLL.Interfaces;
using CV.BLL.Models;
using Microsoft.AspNetCore.Mvc;

namespace CV.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeProjectController : GenericController<EmployeeProjectViewModel, ShortEmployeeProjectViewModel, AddEmployeeProjectViewModel, EmployeeProjectModel, UpdateEmployeeProjectViewModel>
    {
        public EmployeeProjectController(IEmployeeProjectServices employeeProjectServices, IMapper mapper) : base(employeeProjectServices, mapper)
        {
        }
    }
}
