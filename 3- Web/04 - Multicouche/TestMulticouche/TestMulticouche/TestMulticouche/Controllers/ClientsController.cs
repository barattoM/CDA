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
    public class ClientsController:ControllerBase
    {

        private readonly ClientsServices _service;
        private readonly IMapper _mapper;

        public ClientsController(ClientsServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Clients
        [HttpGet]
        public ActionResult<IEnumerable<ClientsDTO>> GetAllClients()
        {
            IEnumerable<Client> listeClients = _service.GetAllClients();
            return Ok(_mapper.Map<IEnumerable<ClientsDTO>>(listeClients));
        }

        //GET api/Clients/{i}
        [HttpGet("{id}", Name = "GetClientById")]
        public ActionResult<ClientsDTO> GetClientById(int id)
        {
            Client commandItem = _service.GetClientById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<ClientsDTO>(commandItem));
            }
            return NotFound();
        }

        //POST api/Clients
        [HttpPost]
        public ActionResult<ClientsDTO> CreateClient(ClientsDTO objIn)
        {
            Client obj = _mapper.Map<Client>(objIn);
            _service.AddClient(obj);
            return CreatedAtRoute(nameof(GetClientById), new { Id = obj.IdClient }, obj);
        }

        //POST api/Clients/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateClient(int id, ClientsDTO obj)
        {
            Client objFromRepo = _service.GetClientById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateClient(objFromRepo);
            return NoContent();
        }


        //DELETE api/Clients/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteClient(int id)
        {
            Client obj = _service.GetClientById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteClient(obj);
            return NoContent();
        }


    }
}
