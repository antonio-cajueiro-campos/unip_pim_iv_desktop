using Login_e_Registro_Sistema.Models;

namespace Login_e_Registro_Sistema.Services.Interfaces
{
    public interface IUserServices
    {
        Task<DefaultResponse<Authenticate>> LoginUser(Credential credential);
        Task<DefaultResponse<GetUserInfos>> GetUserInfos();
        Task<DefaultResponse<Authenticate>> RegisterUser(UserRegister userRegister);
        Task<DefaultResponse<ClienteOutput>> GetAllClients();
        Task<DefaultResponse<ApoliceCliente>> GetApoliceById(string id);
        Task<DefaultResponse<string>> ActiveInsurance(long id, string tipo);
    }
}
