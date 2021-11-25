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
    [Route("api/Voitures")]
    [ApiController]
    public class VoituresControler : ControllerBase
    {
        private readonly VoituresServices _service;
        private readonly IMapper _mapper;

        public VoituresControler(VoituresServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Voitures
        [HttpGet]
        public ActionResult<IEnumerable<VoituresDTO>> GetAllVoitures()
        {
            IEnumerable<Voiture> listeVoitures = _service.GetAllVoitures();
            return Ok(_mapper.Map<IEnumerable<VoituresDTO>>(listeVoitures));
        }

        //GET api/Voitures/{i}
        [HttpGet("{id}", Name = "GetVoitureById")]
        public ActionResult<VoituresDTO> GetVoitureById(int id)
        {
            Voiture commandItem = _service.GetVoitureById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<VoituresDTO>(commandItem));
            }
            return NotFound();
        }

        //POST api/voitures
        [HttpPost]
        public ActionResult<VoituresDTO> CreateVoiture(Voiture voiture)
        {
            _service.AddVoiture(voiture);
            return CreatedAtRoute(nameof(GetVoitureById), new { Id = voiture.IdVoiture }, voiture);
        }

        //POST api/Voitures/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateVoiture(int id, VoituresDTO voiture)
        {
            Voiture voitureFromRepo = _service.GetVoitureById(id);
            if (voitureFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(voiture, voitureFromRepo);
            _service.UpdateVoiture(voitureFromRepo);
            return NoContent();
        }
        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"marque",
        // "value":"test"
        // }]
        //PATCH api/Voitures/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialVoitureUpdate(int id, JsonPatchDocument<Voiture> patchDoc)
        {
            Voiture voitureFromRepo = _service.GetVoitureById(id);
            if (voitureFromRepo == null)
            {
                return NotFound();
            }
            Voiture voitureToPatch = _mapper.Map<Voiture>(voitureFromRepo);
            patchDoc.ApplyTo(voitureToPatch, ModelState);
            if (!TryValidateModel(voitureToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(voitureToPatch, voitureFromRepo);
            _service.UpdateVoiture(voitureFromRepo);
            return NoContent();
        }

        //DELETE api/Voitures/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteVoiture(int id)
        {
            Voiture voiture = _service.GetVoitureById(id);
            if (voiture == null)
            {
                return NotFound();
            }
            _service.DeleteVoiture(voiture);
            return NoContent();
        }


    }
}




