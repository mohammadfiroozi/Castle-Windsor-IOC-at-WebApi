using DependencyInjectionWithCastle.Models;
using DependencyInjectionWithCastle.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DependencyInjectionWithCastle.Controllers
{
    public class IranGravityController : ApiController
    {
        private readonly IGravityServices _gravityService;
        public IranGravityController(IGravityServices gravityService)
        {
            _gravityService = gravityService;

        }

        public List<IranGravity> GetAllIranGravity()
        {
            
            return _gravityService.GetAll();
        }
        public IranGravity GetById( int? Id)
        {

            return _gravityService.GetById(Id);
        }
        public string PostIranGravity(IranGravity iranGravity)
        {
            string returnGravity;
            try
            {
                returnGravity = _gravityService.Add(iranGravity);
            }
            catch (ApplicationException ex)
            {
                throw new HttpResponseException(new HttpResponseMessage { StatusCode = HttpStatusCode.BadRequest, ReasonPhrase = ex.Message });
            }
         

            return returnGravity;
        }

        public string PutIranGravity(IranGravity iranGravity)
        {
            string returnGravity;
            try
            {
                returnGravity = _gravityService.Update(iranGravity);
            }
            catch (ApplicationException ex)
            {
                throw new HttpResponseException(new HttpResponseMessage { StatusCode = HttpStatusCode.BadRequest, ReasonPhrase = ex.Message });
            }
          

            return returnGravity;
        }

        public string DeleteIranGravity(int? id)
        {
            string returnGravity;
            try
            {
                returnGravity = _gravityService.Remove(id);
            }
            catch (ApplicationException ex)
            {
                throw new HttpResponseException(new HttpResponseMessage { StatusCode = HttpStatusCode.BadRequest, ReasonPhrase = ex.Message });
            }
           

            return returnGravity;
        }


    }
}
