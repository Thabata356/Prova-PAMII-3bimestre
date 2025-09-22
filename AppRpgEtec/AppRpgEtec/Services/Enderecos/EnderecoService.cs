using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppRpgEtec.Models;

namespace AppRpgEtec.Services.Enderecos
{
    public class EnderecoService : Request
    {
        //Endereco endereco = new Endereco();
        EnderecoService enderecoService = new EnderecoService();
        private readonly Request _request;
        private const string apiUrlBase = "https://rpgapi3ai2025.azurewebsites.net/Enderecos";
        //Azure: https://rpgapi3ai2025.azurewebsites.net/Enderecos
        //Somee: http://luizfernando.somee.com/RpgApi/Enderecos

        public EnderecoService()
        {
            _request = new Request();
        }

        public async Task<Endereco> GetCepAsync(int cepId)
        {
            string urlComplementar = string.Format("/{0}", cepId);
            string cep = await _request.GetAsync<Models.Endereco>(apiUrlBase + urlComplementar);
            return cep;
        }
    }
}
