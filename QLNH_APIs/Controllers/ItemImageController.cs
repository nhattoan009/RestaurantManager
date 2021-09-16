using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using QLNH_APIs.Data;
using QLNH_APIs.Models;

namespace QLNH_APIs.Controllers{
    
    [ApiController][Route("[controller]")]
    public class ItemImageController : ControllerBase{

        private readonly ApplicationDbContext _context;
        public ItemImageController(ApplicationDbContext context){
            _context = context;
        }
        [HttpGet]
        public IEnumerable<ItemImage> Get()
        {
           return _context.ItemImage.ToList();
        }
    }
}