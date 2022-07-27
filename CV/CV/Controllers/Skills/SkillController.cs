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
        public SkillController(ISkillServices skillServices, IMapper mapper) : base(skillServices, mapper)
        {
        }
    }
}
