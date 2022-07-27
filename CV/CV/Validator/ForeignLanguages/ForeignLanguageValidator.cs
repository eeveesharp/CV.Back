using CV.API.ViewModel.ForeignLanguages.ForeignLanguage;
using FluentValidation;

namespace CV.API.Validator.ForeignLanguages
{
    public class ForeignLanguageValidator : AbstractValidator<AddForeignLanguageViewModel>
    {
        public ForeignLanguageValidator()
        {
            RuleFor(x => x.Name).MaximumLength(20).MinimumLength(3);
        }
    }
}
