// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BookStore.UI.Pages.Users
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Udemy_MS\BookStore.UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Udemy_MS\BookStore.UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Udemy_MS\BookStore.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Udemy_MS\BookStore.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Udemy_MS\BookStore.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Udemy_MS\BookStore.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Udemy_MS\BookStore.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Udemy_MS\BookStore.UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Udemy_MS\BookStore.UI\_Imports.razor"
using BookStore.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Udemy_MS\BookStore.UI\_Imports.razor"
using BookStore.UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Udemy_MS\BookStore.UI\Pages\Users\Login.razor"
using BookStore.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Udemy_MS\BookStore.UI\Pages\Users\Login.razor"
using BookStore.UI.Contracts;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "D:\Udemy_MS\BookStore.UI\Pages\Users\Login.razor"
       
    private LoginModel Model = new LoginModel();
    private bool response = true;

    private async Task HandleLogin()
    {
        response = await _authRepo.Login(Model);

        if (response)
        {
            _navManager.NavigateTo("/");
        }
        
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthenticationRepository _authRepo { get; set; }
    }
}
#pragma warning restore 1591
