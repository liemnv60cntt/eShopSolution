using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.System
{
    public interface IUserService
    {
        Task<string> Authenticate(LoginRequest request);
        Task<bool> Register(RegisterRequest request);
        Task<PagedResult<UserVm>> GetUsersPaging(GetUserPagingRequest request);
    }
}
