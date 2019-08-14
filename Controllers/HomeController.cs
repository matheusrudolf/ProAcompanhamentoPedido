﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using ProAcompanhamentoPedido.Models;
using ProAcompanhamentoPedido.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcControllersActions.Controllers
{
    public class HomeController : Controller
    {
        private readonly AcompanhamentoContexto _context;

        public HomeController(AcompanhamentoContexto context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Pedido> pedidos = await _context.Pedidos.Include(p => p.Cliente).ToListAsync();
            return View(pedidos);
        }
    }
}