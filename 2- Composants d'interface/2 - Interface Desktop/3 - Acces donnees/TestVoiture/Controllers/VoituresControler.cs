using AutoMapper;
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
    public class VoituresControler
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
        public ActionResult<IEnumerable<VoituresDTO>> getAllVoitures()
        {
            IEnumerable<Voiture> listeVoitures = _service.GetAllVoitures();
            return Ok(_mapper.Map<IEnumerable<VoituresDTO>>(listeVoitures));
        }
    }
}
