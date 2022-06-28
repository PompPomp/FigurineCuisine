﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FigurineCuisine.Data;
using FigurineCuisine.Models;

namespace FigurineCuisine.Pages.Figurines
{
    public class IndexModel : PageModel
    {
        private readonly FigurineCuisine.Data.FigurineCuisineContext _context;

        public IndexModel(FigurineCuisine.Data.FigurineCuisineContext context)
        {
            _context = context;
        }

        public IList<Figurine> Figurine { get;set; }

        public async Task OnGetAsync()
        {
            Figurine = await _context.Figurine.ToListAsync();
        }
    }
}
