using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entidades;
using Infraestructura.Datos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LugaresController : ControllerBase
    {
        public ApplicationDbContext Db { get; set; }
        public LugaresController(ApplicationDbContext db)
        {
            Db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<Lugar>>> GetLugares()
        {
            var lugares = await Db.Lugar.ToListAsync();

            return Ok(lugares);
        }
        [HttpGet("ïd")]
        public async Task<ActionResult<Lugar>> GetLugar(int id)
        {
            return await Db.Lugar.FindAsync(id);
        }
    }
}