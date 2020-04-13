namespace Frisbee.Models

{
    public abstract class ApiAuthority
    {
        string redirectUrl;
        string authorizeUrl;
        string clientScope;
        string clientID;
    }
}
