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
            string result = await clienteHTTP.GetStringAsync("http://localhost:8080/cliente/all");
            // Converter de JSON para uma lista do meu modelo/Objeto
            List<Cliente> clientes = JsonSerializer.Deserialize<List<Cliente>>(result);
            // Retorno para minha VIEW os resultados obtidos, a lista de contas.
            return View(clientes);
        }

        // Fazer o get pelo ID Conta
        [HttpGet]
        public IActionResult GetContaPorID()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetContaPorID(int id)
        {
        HttpClient clienteHTTP = new HttpClient();

            // Guardar o resultado do JSON em uma string
            string resultado = await clienteHTTP.GetStringAsync($"http://localhost:8080/conta/id/{id}");

            Conta contas = JsonSerializer.Deserialize<Conta>(resultado);

            return View(contas);
        }
    }
}