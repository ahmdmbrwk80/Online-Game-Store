namespace EcommerceGame.BLL.Interfaces
{
    internal interface IHttpContextAccessor
    {
        object HttpContext { get; }
    }
}