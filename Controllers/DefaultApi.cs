using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using ContactList.Models;

using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;

namespace ContactList.Controllers
{
    [ApiController]
    public sealed class DefaultApiController : ControllerBase
    {
        [HttpPost]
        [Route("/api/contacts")]
        public IActionResult AddPerson([FromBody]Person body)
        {
            string exampleJson = "{\"empty\": false}";
            
            var example = JsonConvert.DeserializeObject<Person>(exampleJson);
            return new ObjectResult(example);
        }
        
        [HttpDelete]
        [Route("/api/contacts/{personId}")]
        public IActionResult DeletePerson([FromRoute][Required]int? personId)
        {
            throw new NotImplementedException();
        }
        
        [HttpGet]
        [Route("/api/contacts")]
        public IActionResult GetAllPersons()
        {
            var exampleJson = "{}";
            
            var example = JsonConvert.DeserializeObject<List<Person>>(exampleJson);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
