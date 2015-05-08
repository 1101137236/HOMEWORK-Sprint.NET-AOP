using KuasCore.Models;
using KuasCore.Services;
using KuasCore.Services.Impl;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;


namespace KuasWebApp.Controllers
{
    public class KuasCoreController : ApiController
    {
        public IKuasCoreService KuasCoreService { get; set; }

        [HttpGet]
        public IList<MyCore> GetAllCores()
        {
            var cores = KuasCoreService.GetAllCores();
            return cores;
        }

        [HttpGet]
        [ActionName("byName")]
        public MyCore GetCoreById(string name)
        {
            var cores = KuasCoreService.GetCoreByName(name);

            if (cores == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return cores;
        }
    }
}