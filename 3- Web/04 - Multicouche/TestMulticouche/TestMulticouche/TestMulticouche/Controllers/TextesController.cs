using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMulticouche.Data.Dtos;
using TestMulticouche.Data.Models;
using TestMulticouche.Data.Services;

namespace TestMulticouche.Controllers
{
    [EnableCors("myPolicy")]
    [Route("api/[Controller]")]
    [ApiController]
    public class TextesController:ControllerBase
    {

        private readonly TextesServices _service;
        private readonly IMapper _mapper;

        public TextesController(TextesServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Textes
        [HttpGet]
        public ActionResult<IEnumerable<TextesDTO>> GetAllTextes()
        {
            IEnumerable<Texte> listeTextes = _service.GetAllTextes();
            return Ok(_mapper.Map<IEnumerable<TextesDTO>>(listeTextes));
        }

        //GET api/Textes/{i}
        [HttpGet("{id}", Name = "GetTexteById")]
        public ActionResult<TextesDTO> GetTexteById(int id)
        {
            Texte commandItem = _service.GetTexteById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<TextesDTO>(commandItem));
            }
            return NotFound();
        }

        //POST api/Textes
        [HttpPost]
        public ActionResult<TextesDTO> CreateTexte(TextesDTO objIn)
        {
            Texte obj = _mapper.Map<Texte>(objIn);
            _service.AddTexte(obj);
            return CreatedAtRoute(nameof(GetTexteById), new { Id = obj.IdTexte }, obj);
        }

        //POST api/Textes/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateTexte(int id, TextesDTO obj)
        {
            Texte objFromRepo = _service.GetTexteById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateTexte(objFromRepo);
            return NoContent();
        }

        //DELETE api/Textes/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteTexte(int id)
        {
            Texte obj = _service.GetTexteById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteTexte(obj);
            return NoContent();
        }


    }
}
