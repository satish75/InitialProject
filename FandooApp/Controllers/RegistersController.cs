﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FandooApp.CommonLayer;
using FandooApp.RepositoryLayer;

namespace FandooApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistersController : ControllerBase
    {
        private readonly UserContext _context;

        public RegistersController(UserContext context)
        {
            _context = context;
        }

        // GET: api/Registers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Register>>> GetRegister()
        {
            return await _context.Register.ToListAsync();
        }

        // GET: api/Registers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Register>> GetRegister(int id)
        {
            var register = await _context.Register.FindAsync(id);

            if (register == null)
            {
                return NotFound();
            }

            return register;
        }

        // PUT: api/Registers/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRegister(int id, Register register)
        {
            if (id != register.Id)
            {
                return BadRequest();
            }

            _context.Entry(register).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RegisterExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Registers
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Register>> PostRegister(Register register)
        {
            _context.Register.Add(register);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRegister", new { id = register.Id }, register);
        }

        // DELETE: api/Registers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Register>> DeleteRegister(int id)
        {
            var register = await _context.Register.FindAsync(id);
            if (register == null)
            {
                return NotFound();
            }

            _context.Register.Remove(register);
            await _context.SaveChangesAsync();

            return register;
        }

        private bool RegisterExists(int id)
        {
            return _context.Register.Any(e => e.Id == id);
        }
    }
}
