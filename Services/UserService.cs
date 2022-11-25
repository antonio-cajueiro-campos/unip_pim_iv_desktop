
using Login_e_Registro_Sistema.Models;
using Login_e_Registro_Sistema.Services.Interfaces;

namespace Login_e_Registro_Sistema.Services;

public class UserService : IUserServices
{
    public IRequestServices _requestService;

    public UserService(IRequestServices requestService)
    {
        _requestService = requestService;
    }

    public async Task<DefaultResponse<Authenticate>> LoginUser(Credential credential) 
    {
        var response = await _requestService.PostAsync<Authenticate>("/authenticate/login", credential);

        //await GetUserInfos();

        return response;
    }

    public async Task<DefaultResponse<GetUserInfos>> GetUserInfos()
    {
        var response = await _requestService.GetAsync<GetUserInfos>("/user/infos");

        return  response;
    }

    public async Task<DefaultResponse<ClienteOutput>> GetAllClients()
    {
        var response = await _requestService.GetAsync<ClienteOutput>("/funcionario/getAllClients");

        return response;
    }

    public async Task<DefaultResponse<Authenticate>> RegisterUser(UserRegister userRegister)
    {

        userRegister.Role = "Funcionario";

        var output = await _requestService.PostAsync<Authenticate>("/user/register", userRegister);

        return output;
    }
}
