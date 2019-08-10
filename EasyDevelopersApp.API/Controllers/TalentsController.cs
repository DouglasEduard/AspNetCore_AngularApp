using System.Threading.Tasks;
using AutoMapper;
using EasyDevelopersApp.API.Data;
using EasyDevelopersApp.API.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EasyDevelopersApp.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TalentsController : ControllerBase
    {
        private readonly ITalentsRepository _repo;
        public IMapper _mapper { get; }

        public TalentsController(ITalentsRepository repo, IMapper mapper)
        {
            this._mapper = mapper;
            this._repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult> GetTalents()
        {
            var talents = await _repo.GetTalents();

            var talentsToReturn = _mapper.Map<IEnumerable<TalentsListDto>>(talents);

            return Ok(talentsToReturn);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetTalent(int id)
        {
            var talent = await _repo.GetTalent(id);

            var talentToReturn = _mapper.Map<TalentDetailDto>(talent);

            return Ok(talentToReturn);
        }
    }
}