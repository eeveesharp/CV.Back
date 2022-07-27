using CV.API.ViewModel.Employee;
using FluentValidation;

namespace CV.API.Validator.Employee
{
    public class EmployeeValidator : AbstractValidator<AddEmployeeViewModel>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Patronymic).NotEmpty();
            RuleFor(x => x.Surname).NotEmpty();
        }
    }
}
