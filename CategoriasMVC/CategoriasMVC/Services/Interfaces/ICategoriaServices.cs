using CategoriasMVC.Models;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace CategoriasMVC.Services.Interfaces
{
    public interface ICategoriaServices
    {
        Task<IEnumerable<CategoriaViewModel>> GetCategorias();
        Task<CategoriaViewModel> GetCategoriaPorId(int id);
        Task<CategoriaViewModel> CriarCategoria(CategoriaViewModel categoriaVM);
        Task<bool> AtualizarCategoria(int id, CategoriaViewModel categoriaVM);
        Task<bool> DeletarCategoria(int id);
    }
}
