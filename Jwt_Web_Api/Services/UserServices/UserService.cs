using System.Security.Claims;

namespace Jwt_Web_Api.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public string GetMyName()
        {
            var results = string.Empty;
            if(_httpContextAccessor.HttpContext != null)
            {
                results = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
            }
            return results;

        }
    }
}
