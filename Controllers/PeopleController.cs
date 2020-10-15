

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudWithReactAspNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrudWithReactAspNetCore.Controllers
{

    public class PeopleController : Controller
    {
        PeopleDAL obj = new PeopleDAL();

        [HttpGet]
        [Route("api/People/Index")]
        public IEnumerable<Peoples> Index()
        {
            return obj.GetAllPeoples();
        }
        
    }
}