using CV.API.ViewModel.SkillViewModels.SkillLevel;
using FluentValidation;

namespace CV.API.Validator.Skills
{
    public class SkillLevelValidator : AbstractValidator<AddSkillLevelViewModel>
    {
        public SkillLevelValidator()
        {
            RuleFor(x => x.Name).MaximumLength(50).MinimumLength(3);
        }
    }
}
