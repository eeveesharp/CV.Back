using AutoMapper;
using CV.API.ViewModel.ForeignLanguages.LanguageEveryDayTopic;
using CV.BLL.Interfaces;
using CV.BLL.Interfaces.ForeignLanguage;
using CV.BLL.Models.ForeignLanguage;
using Microsoft.AspNetCore.Mvc;

namespace CV.API.Controllers.ForeingLanguages
{
    [Route("[controller]")]
    [ApiController]
    public class LanguageEveryDayTopicController : GenericController<LanguageEveryDayTopicViewModel, ShortLanguageEveryDayTopicViewModel, AddLanguageEveryDayTopicViewModel, LanguageEverydayTopicModel, UpdateLanguageEveryDayTopicViewModel>
    {
        public LanguageEveryDayTopicController(ILanguageEverydayTopicServices languageEverydayTopicServices, IMapper mapper) : base(languageEverydayTopicServices, mapper)
        {
        }
    }
}
