using AutoMapper;
using CV.API.ViewModel.ForeignLanguages.LanguageLevel;
using CV.BLL.Interfaces.ForeignLanguage;
using CV.BLL.Models.ForeignLanguage;
using Microsoft.AspNetCore.Mvc;

namespace CV.API.Controllers.ForeingLanguages
{
    [Route("[controller]")]
    [ApiController]
    public class LanguageLevelController : GenericController<LanguageLevelViewModel, ShortLanguageLevelViewModel, AddLanguageLevelViewModel, LanguageLevelModel, UpdateLanguageLevelViewModel>
    {
        public LanguageLevelController(ILanguageLevelServices languageLevelServices, IMapper mapper) : base(languageLevelServices, mapper)
        {
        }
    }
}
