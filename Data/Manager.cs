using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Session5.Data
{
    public class Manager
    {
        public string _authMessage;
        AuthenticationStateProvider provider;

        private IEnumerable<Claim> _claims = Enumerable.Empty<Claim>();

        public async Task<string> UsuarioActual()
        {
            var authState = await provider.GetAuthenticationStateAsync();
            var user = authState.User;

            if (user.Identity.IsAuthenticated)
            {
                _authMessage = $"{user.Identity.Name} is authenticated.";
                return user.Identity.Name.ToString();
            }
            else
            {
                _authMessage = "The user is NOT authenticated.";
                return null;
            }
        }


    }
}
