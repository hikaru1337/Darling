#pragma checksum "C:\Users\Lil' KlowN\source\repos\DarlingNet\DarlingWeb\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d4b8b52c197a4cd7182e37214d6e841c5cee495"
// <auto-generated/>
#pragma warning disable 1591
namespace DarlingWeb.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lil' KlowN\source\repos\DarlingNet\DarlingWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lil' KlowN\source\repos\DarlingNet\DarlingWeb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lil' KlowN\source\repos\DarlingNet\DarlingWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lil' KlowN\source\repos\DarlingNet\DarlingWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lil' KlowN\source\repos\DarlingNet\DarlingWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lil' KlowN\source\repos\DarlingNet\DarlingWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lil' KlowN\source\repos\DarlingNet\DarlingWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lil' KlowN\source\repos\DarlingNet\DarlingWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lil' KlowN\source\repos\DarlingNet\DarlingWeb\_Imports.razor"
using DarlingWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lil' KlowN\source\repos\DarlingNet\DarlingWeb\_Imports.razor"
using DarlingWeb.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.OpenComponent<DarlingWeb.Shared.NavMenu>(2);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\n\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "main");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "top-row px-4");
            __builder.AddAttribute(8, "style", "color:white");
            __builder.AddMarkupContent(9, "<a href=\"https://docs.darlingbot.ru\" target=\"_blank\">Инструкция</a>\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(10);
            __builder.AddAttribute(11, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(12, "a");
                __builder2.AddAttribute(13, "style", "color:white");
                __builder2.AddMarkupContent(14, "Привет, ");
#nullable restore
#line 11 "C:\Users\Lil' KlowN\source\repos\DarlingNet\DarlingWeb\Shared\MainLayout.razor"
__builder2.AddContent(15, context.User.Identity.Name);

#line default
#line hidden
#nullable disable
                __builder2.AddContent(16, "!");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\n                ");
                __builder2.AddMarkupContent(18, "<button type=\"button\" class=\"btn btn-danger\" onClick=\'location.href=\"Account/LogOut\"\'>Выйти</button>");
            }
            ));
            __builder.AddAttribute(19, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(20, "<button type=\"button\" class=\"btn btn-success\" onClick=\'location.href=\"Account/Login\"\'>Войти</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n    ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "content px-4");
#nullable restore
#line 22 "C:\Users\Lil' KlowN\source\repos\DarlingNet\DarlingWeb\Shared\MainLayout.razor"
__builder.AddContent(24, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
