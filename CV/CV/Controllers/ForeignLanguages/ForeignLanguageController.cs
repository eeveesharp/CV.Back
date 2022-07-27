using AutoMapper;
using CV.API.ViewModel.ForeignLanguages.ForeignLanguage;
using CV.BLL.Interfaces;
using CV.BLL.Interfaces.ForeignLanguage;
using CV.BLL.Models.ForeignLanguage;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CV.API.Controllers.ForeingLanguages
{
    [Route("[controller]")]
    [ApiController]
    public class ForeignLanguageController : GenericController<ForeignLanguageViewModel, ShortForeignLanguageViewModel, AddForeignLanguageViewModel, ForeignLanguageModel, UpdateForeignLanguageViewModel>
    {
        public ForeignLanguageController(IForeignLanguageServices foreignLanguageServices, IMapper mapper) : base(foreignLanguageServices, mapper)
        {
        }
    }
}
