using CV.API.ViewModel.Project;
using FluentValidation;

namespace CV.API.Validator.Project
{
    public class ProjectValidator : AbstractValidator<AddProjectViewModel>
    {
        public ProjectValidator()
        {
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.Environment).NotEmpty();
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.EndProject).NotEmpty();
            RuleFor(x => x.StartProject).NotEmpty();
        }
    }
}
