using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        public IEnumerable<Event> _events = new Event[]{
                new Event(){
                    Id = 1,
                    Theme = "Angular 11 e .NET Core 5",
                    Locale = "Recife",
                    Lot = "1º Lote",
                    AmountPeople = 250,
                    EventDate = DateTime.Now.ToString("dd/MM/yyyy"),
                    ImageUrl = "imageurl"
                },
                new Event(){
                    Id = 2,
                    Theme = "Angular 12 e .NET Core 3.1",
                    Locale = "Janga",
                    Lot = "1º Lote",
                    AmountPeople = 250,
                    EventDate = DateTime.Now.ToString("dd/MM/yyyy"),
                    ImageUrl = "foto1.png"
                }
            };
        public EventController()
        {
        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _events;
        }
        [HttpGet("{id}")]
        public IEnumerable<Event> Get(int id)
        {
            return _events.Where(x => x.Id == id);
        }

        [HttpPost]
        public string Post()
        {
            return "method post";
        }
        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de put {id}";
        }
        [HttpDelete("{id}")]
        public string Post(int id)
        {
            return $"method delete {id}";
        }
    }
}
