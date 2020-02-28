using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gorev_Yoneticisi.API.Data;
using Gorev_Yoneticisi.API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gorev_Yoneticisi.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Works")]
    [ApiController]
    public class WorksController : ControllerBase
    {
        private IAppRepository _appRepository;

        public WorksController(IAppRepository appRepository)
        {
            _appRepository = appRepository;
        }

        
        public ActionResult GetWorksByUser(int userId)
        {
            var works = _appRepository.GetWorksByUser(userId);
            return Ok(works);
        }

        [HttpPost]
        [Route("add")]
        public ActionResult Add([FromBody] Work work)
        {
            _appRepository.Add(work);
            _appRepository.SaveAll();
            return Ok(work);
        }
        [HttpGet]
        [Route("detail")]
        public ActionResult GetWorkById(int id)
        {
            var work = _appRepository.GetWork(id);
            return Ok(work);
        }
    }
}