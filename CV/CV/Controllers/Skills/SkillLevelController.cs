using AutoMapper;
using CV.API.ViewModel.SkillViewModels.SkillLevel;
using CV.BLL.Interfaces;
using CV.BLL.Models.Skill;
using Microsoft.AspNetCore.Mvc;

namespace CV.API.Controllers.Skills
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillLevelController : GenericController<SkillLevelViewModel, ShortSkillLevelViewModel, AddSkillLevelViewModel, SkillLevelModel, UpdateSkillLevelViewModel>
    {
        public SkillLevelController(IGenericServices<SkillLevelModel> genericService, IMapper mapper) : base(genericService, mapper)
        {
        }
    }
}
