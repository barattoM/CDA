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
    public class UtilisateursController:ControllerBase
    {

        private readonly UtilisateursServices _service;
        private readonly IMapper _mapper;

        public UtilisateursController(UtilisateursServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Utilisateurs
        [HttpGet]
        public ActionResult<IEnumerable<UtilisateursDTO>> GetAllUtilisateurs()
        {
            IEnumerable<Utilisateur> listeUtilisateurs = _service.GetAllUtilisateurs();
            return Ok(_mapper.Map<IEnumerable<UtilisateursDTO>>(listeUtilisateurs));
        }

        //GET api/Utilisateurs/{i}
        [HttpGet("{id}", Name = "GetUtilisateurById")]
        public ActionResult<UtilisateursDTO> GetUtilisateurById(int id)
        {
            Utilisateur commandItem = _service.GetUtilisateurById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<UtilisateursDTO>(commandItem));
            }
            return NotFound();
        }

        //POST api/Utilisateurs
        [HttpPost]
        public ActionResult<UtilisateursDTO> CreateUtilisateur(UtilisateursDTO objIn)
        {
            Utilisateur obj = _mapper.Map<Utilisateur>(objIn);
            _service.AddUtilisateur(obj);
            return CreatedAtRoute(nameof(GetUtilisateurById), new { Id = obj.IdUtilisateur }, obj);
        }

        //POST api/Utilisateurs/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateUtilisateur(int id, UtilisateursDTO obj)
        {
            Utilisateur objFromRepo = _service.GetUtilisateurById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateUtilisateur(objFromRepo);
            return NoContent();
        }

        //DELETE api/Utilisateurs/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteUtilisateur(int id)
        {
            Utilisateur obj = _service.GetUtilisateurById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteUtilisateur(obj);
            return NoContent();
        }


    }
}
