using System.Threading.Tasks;

namespace ThreeAmigosWebApp.Services{
    public interface IProductService{
    Task<List<ProductDto>> GetProductDataAsync();
    }
}
