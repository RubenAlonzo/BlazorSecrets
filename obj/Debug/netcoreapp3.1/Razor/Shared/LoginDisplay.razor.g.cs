#pragma checksum "C:\Users\Ruben\source\repos\Session5\Session5\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eefe2f7aefedf835f30de3044bbc7d472ec9c03b"
// <auto-generated/>
#pragma warning disable 1591
namespace Session5.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Ruben\source\repos\Session5\Session5\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ruben\source\repos\Session5\Session5\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ruben\source\repos\Session5\Session5\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ruben\source\repos\Session5\Session5\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ruben\source\repos\Session5\Session5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ruben\source\repos\Session5\Session5\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ruben\source\repos\Session5\Session5\_Imports.razor"
using Session5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ruben\source\repos\Session5\Session5\_Imports.razor"
using Session5.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Ruben\source\repos\Session5\Session5\Shared\LoginDisplay.razor"
using Session5.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ruben\source\repos\Session5\Session5\Shared\LoginDisplay.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ruben\source\repos\Session5\Session5\Shared\LoginDisplay.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ruben\source\repos\Session5\Session5\Shared\LoginDisplay.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.OpenElement(3, "img");
                __builder2.AddAttribute(4, "src", 
#nullable restore
#line 65 "C:\Users\Ruben\source\repos\Session5\Session5\Shared\LoginDisplay.razor"
                   usr.Foto

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(5, "alt", "Pic");
                __builder2.AddAttribute(6, "height", "50px");
                __builder2.AddAttribute(7, "width", "50px");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenElement(9, "a");
                __builder2.AddAttribute(10, "href", "Identity/Account/Manage");
                __builder2.AddContent(11, "Bienvenido, ");
                __builder2.AddContent(12, 
#nullable restore
#line 66 "C:\Users\Ruben\source\repos\Session5\Session5\Shared\LoginDisplay.razor"
                                                       nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(13, "!");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.AddMarkupContent(15, "<form method=\"post\" action=\"Identity/Account/LogOut\">\r\n            <button type=\"submit\" class=\"nav-link btn btn-link\">Cerrar sesion</button>\r\n        </form>\r\n    ");
            }
            ));
            __builder.AddAttribute(16, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.AddMarkupContent(18, "<a href=\"Identity/Account/Register\">Registrarse</a>\r\n        ");
                __builder2.AddMarkupContent(19, "<a href=\"Identity/Account/Login\">Iniciar sesion</a>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\Ruben\source\repos\Session5\Session5\Shared\LoginDisplay.razor"
      

    Usuario usr;
    string nombre;

    protected override async Task OnInitializedAsync()
    {
        await GetClaimsPrincipalData();
        
    }

    private string UppercaseWords(string value)
    {
        char[] array = value.ToCharArray();
        // Handle the first letter in the string.
        if (array.Length >= 1)
        {
            if (char.IsLower(array[0]))
            {
                array[0] = char.ToUpper(array[0]);
            }
        }
        // Scan through the letters, checking for spaces.
        // ... Uppercase the lowercase letters following spaces.
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] == ' ')
            {
                if (char.IsLower(array[i]))
                {
                    array[i] = char.ToUpper(array[i]);
                }
            }
        }
        return new string(array);
    }

    async Task GetClaimsPrincipalData()
    {
        usr = new Usuario();

        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;

        if (user.Identity.IsAuthenticated)
        {
           
            usr = (from c in context.Users
                   where c.UserName == user.Identity.Name
                   select c).FirstOrDefault();
            nombre = UppercaseWords(@usr.Nombre.ToLower());
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationDbContext context { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
