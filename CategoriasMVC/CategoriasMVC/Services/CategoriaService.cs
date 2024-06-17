using CategoriasMVC.Models;
using CategoriasMVC.Services.Interfaces;
using System.Text.Json;

namespace CategoriasMVC.Services
{
    public class CategoriaService : ICategoriaServices
    {
        private const string apiEndpoint = "/api/1/categorias";

        private readonly JsonSerializerOptions _options;
        private readonly IHttpClientFactory _clientFactory;

        private CategoriaViewModel categoriaVM;
        private IEnumerable<CategoriaViewModel> categoriasVM;

        public CategoriaService(IHttpClientFactory clientFactory)
        {
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true};
            _clientFactory = clientFactory;
        }

        public Task<bool> AtualizarCategoria(int id, CategoriaViewModel categoriaVM)
        {
            throw new NotImplementedException();
        }

        public Task<CategoriaViewModel> CriarCategoria(CategoriaViewModel categoriaVM)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletarCategoria()
        {
            throw new NotImplementedException();
        }

        public Task<CategoriaViewModel> GetCategoriaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoriaViewModel>> GetCategorias()
        {
            throw new NotImplementedException();
        }
    }
}
