using Login_e_Registro_Sistema.Models;

namespace Login_e_Registro_Sistema.Services.Interfaces;

public interface IRequestServices
{
    Task<DefaultResponse<T>> GetAsync<T>(string endpoint);
    Task<DefaultResponse<T>> PostAsync<T>(string endpoint, object value);
}
