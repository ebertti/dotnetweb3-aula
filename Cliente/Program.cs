using Cliente.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    // Instalar Nuget Microsoft.AspNet.WebApi.Client
    class Program
    {
        public static HttpClient cliente = new HttpClient();

        static void Main(string[] args)
        {
            principal().Wait();
        }

        static async Task principal() {
            Usuario usuario = null;
            cliente.BaseAddress = new Uri("https://api.github.com/");
            cliente.DefaultRequestHeaders.Accept.Clear();
            cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            cliente.DefaultRequestHeaders.Add("User-Agent", "Anything");

            Console.WriteLine("Informe o nome do usuário:");
            var usuario_nome = Console.ReadLine();

            while (usuario_nome != "")
            {
                var caminho = $"users/{usuario_nome}";

                var response =  await cliente.GetAsync(caminho);
                if (response.IsSuccessStatusCode)
                {
                    usuario = await response.Content.ReadAsAsync<Usuario>();
                }

                Console.WriteLine($"Nome: {usuario.name}\tSeguidores: {usuario.followers}");

                response = await cliente.GetAsync(usuario.repos_url);
                if (response.IsSuccessStatusCode)
                {
                    var repositorios = await response.Content.ReadAsAsync<List<Repositorio>>();

                    Parallel.ForEach(repositorios, (repositorio) =>
                    {
                        Console.WriteLine($"Repositorio: {repositorio.name}\tStars: {repositorio.stargazers_count}");
                    });
                }

                Console.WriteLine("Informe o nome do usuário:");
                usuario_nome = Console.ReadLine();
            }
        }
    }
}
