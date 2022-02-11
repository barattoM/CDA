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
    public class ArticlesController : ControllerBase
    {

        private readonly ArticlesServices _service;
        private readonly IMapper _mapper;

        public ArticlesController(ArticlesServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Articles
        [HttpGet]
        public ActionResult<IEnumerable<ArticlesDTO>> GetAllArticles()
        {
            IEnumerable<Article> listeArticles = _service.GetAllArticles();
            return Ok(_mapper.Map<IEnumerable<ArticlesDTO>>(listeArticles));
        }

        //GET api/Articles/{i}
        [HttpGet("{id}", Name = "GetArticleById")]
        public ActionResult<ArticlesDTO> GetArticleById(int id)
        {
            Article commandItem = _service.GetArticleById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<ArticlesDTO>(commandItem));
            }
            return NotFound();
        }

        //POST api/Articles
        [HttpPost]
        public ActionResult<ArticlesDTO> CreateArticle(ArticlesDTO objIn)
        {
            Article obj = _mapper.Map<Article>(objIn);
            _service.AddArticle(obj);
            return CreatedAtRoute(nameof(GetArticleById), new { Id = obj.IdArticle }, obj);
        }

        //POST api/Articles/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateArticle(int id, ArticlesDTO obj)
        {
            Article objFromRepo = _service.GetArticleById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateArticle(objFromRepo);
            return NoContent();
        }


        //DELETE api/Articles/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteArticle(int id)
        {
            Article obj = _service.GetArticleById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteArticle(obj);
            return NoContent();
        }


    }
}
