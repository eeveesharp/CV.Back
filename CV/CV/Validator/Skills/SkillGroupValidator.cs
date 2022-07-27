using CV.API.ViewModel.SkillViewModels.SkillGroup;
using FluentValidation;

namespace CV.API.Validator.Skills
{
    public class SkillGroupValidator : AbstractValidator<AddSkillGroupViewModel>
    {
        public SkillGroupValidator()
        {
            RuleFor(x => x.Name).MaximumLength(50).MinimumLength(3);
        }
    }
}
