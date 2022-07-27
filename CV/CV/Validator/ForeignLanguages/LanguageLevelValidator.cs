using CV.API.ViewModel.ForeignLanguages.LanguageLevel;
using FluentValidation;

namespace CV.API.Validator.ForeignLanguages
{
    public class LanguageLevelValidator : AbstractValidator<AddLanguageLevelViewModel>
    {
        public LanguageLevelValidator()
        {
            RuleFor(x => x.Name).MaximumLength(20).MinimumLength(3);
        }
    }
}
