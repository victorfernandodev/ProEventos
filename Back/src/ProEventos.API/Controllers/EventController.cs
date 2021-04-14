using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        private readonly DataContext _context;

        public EventController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _context.Events;
        }
        [HttpGet("{id}")]
        public Event Get(int id)
        {
            return _context.Events.FirstOrDefault(x => x.Id == id);
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
