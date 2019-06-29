using SmartTechTask.Data.Entities;
using SmartTechTask.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SmartTechTask.API.Controllers
{
    [RoutePrefix("api/Product")]
    [EnableCors("https://localhost:44394/", "*", "*", SupportsCredentials = true)]
    public class ProductController : ApiController
    {
        private IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        [Route("GellAll")]
        public IHttpActionResult GatAll()
        {
            return Json(_repository.GetAll());
        }

        [HttpPost]
        [Route("Add")]
        public IHttpActionResult Add(Product product)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            product = _repository.Add(product);
            return Ok(product);
        }

        [HttpPost]
        [Route("Eidt")]
        public IHttpActionResult Edit(Product product)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            _repository.Edit(product);
            return Ok();
        }

        [HttpPost]
        [Route("Remove/{id}")]
        public IHttpActionResult Remove(int id)
        {
            _repository.Remove(id);
            return Ok();
        }
    }
}
