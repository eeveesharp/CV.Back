using AutoMapper;
using CV.API.ViewModel.ForeignLanguages.LanguageProfessionalTopic;
using CV.BLL.Interfaces.ForeignLanguage;
using CV.BLL.Models.ForeignLanguage;
using Microsoft.AspNetCore.Mvc;

namespace CV.API.Controllers.ForeingLanguages
{
    [Route("[controller]")]
    [ApiController]
    public class LanguageProfessionalTopicController : GenericController<LanguageProfessionalTopicViewModel, ShortLanguageProfessionalTopicViewModel, AddLanguageProfessionalTopicViewModel, LanguageProfessionalTopicModel, UpdateLanguageProfessionalTopicViewModel>
    {
        public LanguageProfessionalTopicController(ILanguageProfessionalTopicServices languageProfessionalTopicServices, IMapper mapper) : base(languageProfessionalTopicServices, mapper)
        {
        }
    }
}
