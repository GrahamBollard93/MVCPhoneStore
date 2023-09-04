using PhoneStore.Models;

namespace PhoneStore.Service;

public interface IPhonesApiService
{
    Task<IEnumerable<Product>?> GetProducts();
}