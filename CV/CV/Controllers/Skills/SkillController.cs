using AutoMapper;
using CV.API.ViewModel.SkillViewModels.Skill;
using CV.BLL.Interfaces;
using CV.BLL.Models.Skill;
using Microsoft.AspNetCore.Mvc;

namespace CV.API.Controllers.Skills
{
    [Route("[controller]")]
    [ApiController]
    public class SkillController : GenericController<SkillViewModel, ShortSkillViewModel, AddSkillViewModel, SkillModel, UpdateSkillViewModel>
    {
        public SkillController(IGenericServices<SkillModel> genericService, IMapper mapper) : base(genericService, mapper)
        {
        }
    }
}
