#pragma checksum "C:\Aplicaciones\Blazor_Simple_Signal\Blazor_Simple_Signal\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dfdee77b37995b028bf77dd1ca04bff1de8a250"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor_Simple_Signal.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Aplicaciones\Blazor_Simple_Signal\Blazor_Simple_Signal\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Aplicaciones\Blazor_Simple_Signal\Blazor_Simple_Signal\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Aplicaciones\Blazor_Simple_Signal\Blazor_Simple_Signal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Aplicaciones\Blazor_Simple_Signal\Blazor_Simple_Signal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Aplicaciones\Blazor_Simple_Signal\Blazor_Simple_Signal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Aplicaciones\Blazor_Simple_Signal\Blazor_Simple_Signal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Aplicaciones\Blazor_Simple_Signal\Blazor_Simple_Signal\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Aplicaciones\Blazor_Simple_Signal\Blazor_Simple_Signal\Client\_Imports.razor"
using Blazor_Simple_Signal.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Aplicaciones\Blazor_Simple_Signal\Blazor_Simple_Signal\Client\_Imports.razor"
using Blazor_Simple_Signal.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : IndexBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row" + " d-flex" + " justify-content-around" + " pt-3" + " " + (
#nullable restore
#line 4 "C:\Aplicaciones\Blazor_Simple_Signal\Blazor_Simple_Signal\Client\Pages\Index.razor"
                                                    bg

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(2, "h4");
            __builder.AddAttribute(3, "class", "col-12 mb-5");
            __builder.AddMarkupContent(4, "\r\n        Chat Application : You are\r\n");
#nullable restore
#line 7 "C:\Aplicaciones\Blazor_Simple_Signal\Blazor_Simple_Signal\Client\Pages\Index.razor"
         if (IsConnected)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<span class=\"badge-success p-2 rounded\">Online</span>");
#nullable restore
#line 10 "C:\Aplicaciones\Blazor_Simple_Signal\Blazor_Simple_Signal\Client\Pages\Index.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<span class=\"badge-danger p-2 rounded\">Offline</span>");
#nullable restore
#line 14 "C:\Aplicaciones\Blazor_Simple_Signal\Blazor_Simple_Signal\Client\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 17 "C:\Aplicaciones\Blazor_Simple_Signal\Blazor_Simple_Signal\Client\Pages\Index.razor"
     if (newUserMessage)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "role", "alert");
            __builder.AddAttribute(9, "aria-live", "assertive");
            __builder.AddAttribute(10, "aria-atomic", "true");
            __builder.AddAttribute(11, "class", "toast fade show");
            __builder.AddAttribute(12, "data-autohide", "false");
            __builder.AddAttribute(13, "style", "position: absolute; right: 10px; z-index:100");
            __builder.AddMarkupContent(14, @"<div class=""toast-header""><svg class=""bd-placeholder-img rounded mr-2"" width=""20"" height=""20"" xmlns=""http://www.w3.org/2000/svg"" preserveAspectRatio=""xMidYMid slice"" focusable=""false"" role=""img""><rect width=""100%"" height=""100%"" fill=""#007aff""></rect></svg>
                <strong class=""mr-auto""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">Chat Application</font></font></strong>
                <small><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">Justo ahora</font></font></small>
                <button type=""button"" class=""ml-2 mb-1 close"" data-dismiss=""toast"" aria-label=""Cerca""><span aria-hidden=""true""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">×</font></font></span></button></div>
            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "toast-body");
            __builder.OpenElement(17, "font");
            __builder.AddAttribute(18, "style", "vertical-align: inherit;");
            __builder.OpenElement(19, "font");
            __builder.AddAttribute(20, "style", "vertical-align: inherit;");
            __builder.AddMarkupContent(21, "\r\n                        El usuario ");
            __builder.OpenElement(22, "b");
            __builder.AddContent(23, 
#nullable restore
#line 31 "C:\Aplicaciones\Blazor_Simple_Signal\Blazor_Simple_Signal\Client\Pages\Index.razor"
                                       newUsuario

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, " ha iniciado session\r\n                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "C:\Aplicaciones\Blazor_Simple_Signal\Blazor_Simple_Signal\Client\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "col-md-5 border rounded row py-3");
#nullable restore
#line 40 "C:\Aplicaciones\Blazor_Simple_Signal\Blazor_Simple_Signal\Client\Pages\Index.razor"
         if (IsConnected)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col-12");
            __builder.AddMarkupContent(29, "\r\n                Bienvenido ");
            __builder.OpenElement(30, "b");
            __builder.AddContent(31, 
#nullable restore
#line 43 "C:\Aplicaciones\Blazor_Simple_Signal\Blazor_Simple_Signal\Client\Pages\Index.razor"
                               UserChat.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Aplicaciones\Blazor_Simple_Signal\Blazor_Simple_Signal\Client\Pages\Index.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "form-group col-12");
            __builder.AddMarkupContent(34, "<label>Usuario</label>\r\n                ");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "type", "text");
            __builder.AddAttribute(37, "class", "form-control");
            __builder.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 50 "C:\Aplicaciones\Blazor_Simple_Signal\Blazor_Simple_Signal\Client\Pages\Index.razor"
                                                               UserChat.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => UserChat.Name = __value, UserChat.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "col-12 d-flex justify-content-around");
            __builder.OpenElement(43, "button");
            __builder.AddAttribute(44, "class", "btn btn-primary");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Aplicaciones\Blazor_Simple_Signal\Blazor_Simple_Signal\Client\Pages\Index.razor"
                                                          SendLogIn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(46, "Log In");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 55 "C:\Aplicaciones\Blazor_Simple_Signal\Blazor_Simple_Signal\Client\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\r\n    ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "row col-md-5 col-lg-4 border rounded d-flex align-content-start mx-0 px-0");
            __builder.AddMarkupContent(50, "<h5 class=\"col-12 bg-primary px-2 mx-0 py-2 text-white font-weight-bold rounded-top\">Lista de usuarios</h5>");
#nullable restore
#line 62 "C:\Aplicaciones\Blazor_Simple_Signal\Blazor_Simple_Signal\Client\Pages\Index.razor"
         foreach (var usuarios in ListUsuario.Where(x=>x.Name != UserChat.Name).ToList())
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "col-12 d-flex align-items-center mt-1");
            __builder.OpenElement(53, "b");
            __builder.AddAttribute(54, "class", "mr-2");
            __builder.AddContent(55, 
#nullable restore
#line 64 "C:\Aplicaciones\Blazor_Simple_Signal\Blazor_Simple_Signal\Client\Pages\Index.razor"
                                                                                usuarios.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(56, " ha iniciado session  ");
            __builder.OpenElement(57, "button");
            __builder.AddAttribute(58, "class", "btn btn-outline-primary btn-sm ml-2");
            __builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "C:\Aplicaciones\Blazor_Simple_Signal\Blazor_Simple_Signal\Client\Pages\Index.razor"
                                                                                                                                                                                     (()=>CreateChatUser(usuarios))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(60, "Chatear");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 65 "C:\Aplicaciones\Blazor_Simple_Signal\Blazor_Simple_Signal\Client\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n\r\n");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "row col-6 mx-0 px-0");
#nullable restore
#line 72 "C:\Aplicaciones\Blazor_Simple_Signal\Blazor_Simple_Signal\Client\Pages\Index.razor"
     foreach (var _message in messages)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "col-12 d-flex align-items-center");
            __builder.AddContent(66, 
#nullable restore
#line 74 "C:\Aplicaciones\Blazor_Simple_Signal\Blazor_Simple_Signal\Client\Pages\Index.razor"
                                                        (MarkupString)_message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 75 "C:\Aplicaciones\Blazor_Simple_Signal\Blazor_Simple_Signal\Client\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "col-12 px-0 mt-5 pt-5 d-flex justify-content-around");
#nullable restore
#line 79 "C:\Aplicaciones\Blazor_Simple_Signal\Blazor_Simple_Signal\Client\Pages\Index.razor"
     foreach (var messagesUser in ListMessagesUsers.List_MenssagesUsers)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Blazor_Simple_Signal.Client.Shared.ChatUserPrivate>(70);
            __builder.AddAttribute(71, "MessagesUser", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazor_Simple_Signal.Shared.MessagesUser>(
#nullable restore
#line 81 "C:\Aplicaciones\Blazor_Simple_Signal\Blazor_Simple_Signal\Client\Pages\Index.razor"
                                       messagesUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "SendMessagePrivate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Blazor_Simple_Signal.Shared.UserMessage>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Blazor_Simple_Signal.Shared.UserMessage>(this, 
#nullable restore
#line 81 "C:\Aplicaciones\Blazor_Simple_Signal\Blazor_Simple_Signal\Client\Pages\Index.razor"
                                                                         SendPrivateMessage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 82 "C:\Aplicaciones\Blazor_Simple_Signal\Blazor_Simple_Signal\Client\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
