using AutoMapper;
using CV.API.ViewModel.SkillViewModels.SkillGroup;
using CV.BLL.Interfaces;
using CV.BLL.Models.Skill;
using Microsoft.AspNetCore.Mvc;

namespace CV.API.Controllers.Skills
{
    [Route("[controller]")]
    [ApiController]
    public class SkillGroupController : GenericController<SkillGroupViewModel, ShortSkillGroupViewModel, AddSkillGroupViewModel, SkillGroupModel, UpdateSkillGroupViewModel>
    {
        public SkillGroupController(IGenericServices<SkillGroupModel> genericService, IMapper mapper) : base(genericService, mapper)
        {
        }
    }
}
