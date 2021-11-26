using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestVoiture.Data.Dtos;
using TestVoiture.Data.Models;
using TestVoiture.Data.Services;

namespace TestVoiture.Controllers
{
    [Route("api/Personnes")]
    [ApiController]
    public class PersonnesController:ControllerBase
    {
        
        private readonly PersonnesServices _service;
        private readonly AutoMapper.IMapper _mapper;

        public PersonnesController(PersonnesServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Personnes
        [HttpGet]
        public ActionResult<IEnumerable<PersonnesDTO>> GetAllPersonnes()
        {
            IEnumerable < Personne > listePersonnes = _service.GetAllPersonnes();
            return Ok(_mapper.Map<IEnumerable<PersonnesDTO>>(listePersonnes));
        }

        //GET api/Personnes/{i}
        [HttpGet("{id}", Name = "GetPersonneById")]
        public ActionResult<PersonnesDTO> GetPersonneById(int id)
        {
            Personne commandItem = _service.GetPersonneById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<PersonnesDTO>(commandItem));
            }
            return NotFound();
        }

        //POST api/Personnes
        [HttpPost]
        public ActionResult CreatePersonne(PersonnesDTOIn obj)
        {
            _service.AddPersonne(obj);
            return NoContent();
        }

        //POST api/Personnes/{id}
        [HttpPut("{id}")]
        public ActionResult UpdatePersonne(int id, Personne obj)
        {
            Personne objFromRepo = _service.GetPersonneById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdatePersonne(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Personnes/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialPersonneUpdate(int id, JsonPatchDocument<PersonnesDTO> patchDoc)
        {
            Personne objFromRepo = _service.GetPersonneById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            PersonnesDTO objToPatch = _mapper.Map < PersonnesDTO > (objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdatePersonne(objFromRepo);
            return NoContent();
        }

        //DELETE api/Personnes/{id}
        [HttpDelete("{id}")]
        public ActionResult DeletePersonne(int id)
        {
            Personne obj = _service.GetPersonneById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeletePersonne(obj);
            return NoContent();
        }


    }
}
