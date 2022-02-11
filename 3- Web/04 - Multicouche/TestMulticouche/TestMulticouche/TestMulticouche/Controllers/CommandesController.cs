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
    public class CommandesController: ControllerBase
    {

        private readonly CommandesServices _service;
        private readonly IMapper _mapper;

        public CommandesController(CommandesServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Commandes
        [HttpGet]
        public ActionResult<IEnumerable<CommandesDTO>> GetAllCommandes()
        {
            IEnumerable<Commande> listeCommandes = _service.GetAllCommandes();
            return Ok(_mapper.Map<IEnumerable<CommandesDTO>>(listeCommandes));
        }

        //GET api/Commandes/{i}
        [HttpGet("{id}", Name = "GetCommandeById")]
        public ActionResult<CommandesDTO> GetCommandeById(int id)
        {
            Commande commandItem = _service.GetCommandeById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<CommandesDTO>(commandItem));
            }
            return NotFound();
        }

        //POST api/Commandes
        [HttpPost]
        public ActionResult<CommandesDTO> CreateCommande(CommandesDTO objIn)
        {
            Commande obj = _mapper.Map<Commande>(objIn);
            _service.AddCommande(obj);
            return CreatedAtRoute(nameof(GetCommandeById), new { Id = obj.IdCommande }, obj);
        }

        //POST api/Commandes/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateCommande(int id, CommandesDTO obj)
        {
            Commande objFromRepo = _service.GetCommandeById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateCommande(objFromRepo);
            return NoContent();
        }

        //DELETE api/Commandes/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteCommande(int id)
        {
            Commande obj = _service.GetCommandeById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteCommande(obj);
            return NoContent();
        }


    }
}
