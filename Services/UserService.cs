using unip_pim_iv_desktop.Models;
using Model = unip_pim_iv_desktop.Models;

namespace unip_pim_iv_desktop.Services;

internal class UserService
{
    public Model.User user = null;
    public RequestService _requestService;

    public UserService(RequestService requestService)
    {
        _requestService = requestService;
    }

    public async Task<bool> LoginUser(Credential credential) {
        var response = await _requestService.PostAsync("/authenticate/login", credential);

        //this.dataManager.setData(StorageKeys.JWT, response.data.jwt);
        await GetUserInfos();

        return true;
    }

    public async Task<bool> GetUserInfos()
    {
        var response = await _requestService.GetAsync("/user/infos");
        

        return true;
    }
}
