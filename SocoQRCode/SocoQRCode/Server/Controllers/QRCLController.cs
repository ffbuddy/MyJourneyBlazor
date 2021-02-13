using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocoQRCode.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocoQRCode.Server.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

    public class QRCLController: ControllerBase
    {
        private readonly ApplicationDbContext context;
        public QRCLController(ApplicationDbContext context )
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<QRCL>>>Get()
        {
            return await context.QRCL.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<QRCL>> Get(int id)
        {
            var qrcl = await context.QRCL.FirstOrDefaultAsync(x => x.QRCodeID == id);
            if (qrcl == null) { return NotFound(); }
            return qrcl;
        }
        

        [HttpPost]
        public async Task<ActionResult<int>>Post(QRCL qrcl)
        {
            context.Add(qrcl);
            await context.SaveChangesAsync();
            return qrcl.QRCodeID;
        }

        [HttpPut]
        public async Task<ActionResult> Put(QRCL qrcl)
        {
            context.Attach(qrcl).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var qrcl = await context.QRCL.FirstOrDefaultAsync(x => x.QRCodeID == id);
            if (qrcl == null)
            {
                return NotFound();
            }

            context.Remove(qrcl);
            await context.SaveChangesAsync();
            return NoContent();

        }

    }
}
