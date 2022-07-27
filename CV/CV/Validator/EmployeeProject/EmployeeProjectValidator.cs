using CV.API.ViewModel.EmployeeProject;
using FluentValidation;

namespace CV.API.Validator.EmployeeProject
{
    public class EmployeeProjectValidator : AbstractValidator<AddEmployeeProjectViewModel>
    {
        public EmployeeProjectValidator()
        {
            RuleFor(x => x.Position).MaximumLength(50).MinimumLength(3);
        }
    }
}
