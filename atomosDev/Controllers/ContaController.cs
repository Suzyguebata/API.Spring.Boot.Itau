using System;
using System.Net.Http;
using System.Collections;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using atomosDev.Models;
using System.Text.Json;
using System.Collections.Generic;

namespace atomosDev.Controllers
{
    public class ContaController : Controller
    {
        public async Task<IActionResult> AllContas()
        {
            // Definir meu cliente HTTP
            HttpClient clienteHTTP = new HttpClient();
            // Ler os dados da minha API e guardar em uma string
            string result = await clienteHTTP.GetStringAsync("http://localhost:8080/conta/all");
            // Converter de JSON para uma lista do meu modelo/Objeto
            IEnumerable<Conta> contas = JsonSerializer.Deserialize<IEnumerable<Conta>>(result);
            // Retorno para minha VIEW os resultados obtidos, a lista de contas.
            return View(contas);
        }
    }
}