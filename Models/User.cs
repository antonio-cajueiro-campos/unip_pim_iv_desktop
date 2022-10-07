namespace unip_pim_iv_desktop.Models;

internal class User
{
    public long Id { get; set; }    
    public string? Name { get; set; }
    public string? Document { get; set; }
    public Credential? Credential { get; set; }
    public DateTime RegistrationDate { get; set; }
}
