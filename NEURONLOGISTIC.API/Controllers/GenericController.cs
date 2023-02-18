using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NEURONLOGISTIC.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NEURONLOGISTIC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class GenericController<T> : ControllerBase where T : class 
    {
        private readonly IGenericService<T> _genericRepository;

        public GenericController(IGenericService<T> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var t_List = _genericRepository.GetAllList();
            return Ok(t_List);
        }

        [HttpPost]
        public IActionResult Post([FromBody]T t)
        {
            var added_T = _genericRepository.Insert(t);
            return Ok(added_T);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var get_T = _genericRepository.GetById(id);

            if (get_T == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(get_T);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleted_T = _genericRepository.GetById(id);

            if (deleted_T == null)
            {
                return NotFound();
            }
            else
            {
                _genericRepository.Delete(deleted_T);

                return Ok();
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody]T t)
        {
            _genericRepository.Update(t);

            return Ok(t);
        }
    }
}
