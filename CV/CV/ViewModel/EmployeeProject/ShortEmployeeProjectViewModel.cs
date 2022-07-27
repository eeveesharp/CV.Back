using CV.API.ViewModel.Employee;
using CV.API.ViewModel.Project;

namespace CV.API.ViewModel.EmployeeProject
{
    public class ShortEmployeeProjectViewModel
    {
#nullable disable
        public List<ShortEmployeeViewModel> Employee { get; set; }

        public List<ShortProjectViewModel> Project { get; set; }

        public string Position { get; set; }
#nullable enable
    }
}
