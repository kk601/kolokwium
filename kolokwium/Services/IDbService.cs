using kolokwium.DTOs;

namespace kolokwium.Services;

public interface IDbService
{
    Task<CustomerDto> GetCustomerById(int orderId);
}