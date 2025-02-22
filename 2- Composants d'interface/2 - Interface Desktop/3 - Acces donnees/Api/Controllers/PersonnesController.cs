﻿using Api.Data.Dtos;
using Api.Data.Models;
using Api.Data.Services;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/Personnes")]
    [ApiController]
    public class PersonnesController : ControllerBase
    {
        private readonly PersonnesServices _service;
        private readonly IMapper _mapper;

        public PersonnesController(PersonnesServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/personnes
        [HttpGet]
        public ActionResult<IEnumerable<PersonnesDTO>> getAllPersonnes()
        {
            IEnumerable<Personne> listePersonnes = _service.GetAllPersonnes();
            return Ok(_mapper.Map<IEnumerable<PersonnesDTO>>(listePersonnes)); 
        }

        //GET api/personnes/{id}
        [HttpGet("{id}",Name ="GetPersonneById")]
        public ActionResult<PersonnesDTO> GetPersonneById(int id)
        {
            Personne commandItem = _service.GetPersonneById(id);
            if (commandItem !=null)
            {
                return Ok(_mapper.Map<PersonnesDTO>(commandItem));
            }
            return NotFound();
        }

        //POST api/personnes
        [HttpPost]
        public ActionResult<PersonnesDTO> CreatePersonne(Personne personne)
        {
            _service.AddPersonnes(personne);
            return CreatedAtRoute(nameof(GetPersonneById),new { Id= personne.Id},personne);
        }


        //PUT api/personnes/{id}
        [HttpPut("{id}")]
        public ActionResult UpdatePersonne(int id, PersonnesDTO personne)
        {
            var personneFromRepo = _service.GetPersonneById(id);
            if (personneFromRepo == null) 
            {
                return NotFound();
            }
            personneFromRepo.Dump();
            _mapper.Map(personne, personneFromRepo);
            personneFromRepo.Dump();
            personne.Dump();
            // inutile puisque la fonction ne fait rien, mais garde la cohérence
            _service.UpdatePersonne(personneFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"prenom",
        // "value":"test"
        // }]
        //PATCH api/personnes/{id}

        [HttpPatch("{id}")]
        public ActionResult PartialPersonneUpdate(int id, JsonPatchDocument<Personne> patchDoc)
        {
            var personneFromRepo = _service.GetPersonneById(id);
            if (personneFromRepo == null)
            {
                return NotFound();
            }
            var personneToPatch = _mapper.Map<Personne>(personneFromRepo);
            patchDoc.ApplyTo(personneToPatch, ModelState);
            if (!TryValidateModel(personneToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(personneToPatch, personneFromRepo);
            _service.UpdatePersonne(personneFromRepo);
            return NoContent();
        }

        //DELETE api/personnes/{id}
        [HttpDelete("{id}")] 
        public ActionResult DeletePersonne(int id) 
        { 
            var personneModelFromRepo = _service.GetPersonneById(id);
            if (personneModelFromRepo == null)
            {
                return NotFound();
            } 
            _service.DeletePersonne(personneModelFromRepo);
            return NoContent(); }
    }


}
