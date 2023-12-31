﻿using HSPAuthTentativeIII.DTO;

namespace HSPAuthTentativeIII.Repositories
{
    public interface IUserAuthenticationService
    {
        Task<Status> LoginAsync(LoginModel model);
        Task LogoutAsync();
        Task<Status> RegisterAsync(RegistrationModel model);
    }
}
