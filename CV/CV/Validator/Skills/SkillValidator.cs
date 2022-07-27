using CV.API.ViewModel.SkillViewModels.Skill;
using FluentValidation;

namespace CV.API.Validator.Skills
{
    public class SkillValidator : AbstractValidator<AddSkillViewModel>
    {
        public SkillValidator()
        {
            RuleFor(x => x.Name).MaximumLength(50).MinimumLength(3);
            RuleFor(x => x.Experience).GreaterThan(0);
            RuleFor(x => x.LastUsing).NotNull();
        }
    }
}
