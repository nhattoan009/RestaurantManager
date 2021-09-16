using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using QLNH_APIs.Data;
using QLNH_APIs.Models;

namespace QLNH_APIs.Controllers{
    
    [ApiController][Route("[controller]")]
    public class RoleController : ControllerBase{

        private readonly ApplicationDbContext _context;
        public RoleController(ApplicationDbContext context){
            _context = context;
        }

        ///select all role
        [HttpGet]
        public IEnumerable<Role> Get()
        {
           return _context.Role.ToList();
        }

        ///<summary>
        ///select role by id
        ///</summary>
        [HttpGet("{id}")]
        public Role Get([FromQuery] int id)
        {
           return _context.Role.Where(role => role.id == id).FirstOrDefault();
        }

        ///Add new role
        [HttpPost]
        public Role Post([FromQuery] Role role)
        {
            _context.Role.Add(role);
            _context.SaveChanges();
           return role;
        }
    }
}