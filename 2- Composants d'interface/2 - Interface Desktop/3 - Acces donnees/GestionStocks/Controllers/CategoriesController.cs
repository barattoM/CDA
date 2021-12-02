using AutoMapper;
using GestionStocks.Data.Dtos;
using GestionStocks.Data.Models;
using GestionStocks.Data.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStocks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    class CategoriesController:ControllerBase
    {

        private readonly CategoriesServices _service;
        private readonly IMapper _mapper;

        public CategoriesController(CategoriesServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Categories
        [HttpGet]
        public ActionResult<IEnumerable<CategoriesDTO>> GetAllCategories()
        {
            IEnumerable<Categorie> listeCategories = _service.GetAllCategories();
            return Ok(_mapper.Map<IEnumerable<CategoriesDTO>>(listeCategories));
        }

        //GET api/Categories/{i}
        [HttpGet("{id}", Name = "GetCategorieById")]
        public ActionResult<CategoriesDTO> GetCategorieById(int id)
        {
            Categorie commandItem = _service.GetCategorieById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<CategoriesDTO>(commandItem));
            }
            return NotFound();
        }

        //POST api/Categories
        [HttpPost]
        public ActionResult<CategoriesDTO> CreateCategorie(CategoriesDTOIn objIn)
        {
            Categorie obj = _mapper.Map<Categorie>(objIn);
            _service.AddCategorie(obj);
            return CreatedAtRoute(nameof(GetCategorieById), new { Id = obj.IdCategorie }, obj);
        }

        //POST api/Categories/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateCategorie(int id, CategoriesDTOIn obj)
        {
            Categorie objFromRepo = _service.GetCategorieById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateCategorie(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Categories/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialCategorieUpdate(int id, JsonPatchDocument<Categorie> patchDoc)
        {
            Categorie objFromRepo = _service.GetCategorieById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Categorie objToPatch = _mapper.Map<Categorie>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateCategorie(objFromRepo);
            return NoContent();
        }

        //DELETE api/Categories/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteCategorie(int id)
        {
            Categorie obj = _service.GetCategorieById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteCategorie(obj);
            return NoContent();
        }


    }
}
