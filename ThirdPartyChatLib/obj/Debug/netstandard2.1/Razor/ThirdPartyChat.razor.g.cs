#pragma checksum "D:\MyProjects\BlazorChat\BlazorChat\ThirdPartyChatLib\ThirdPartyChat.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65f6d94a4189ab18e1b9964522cf5ee8b192c038"
// <auto-generated/>
#pragma warning disable 1591
namespace ThirdPartyChatLib
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\MyProjects\BlazorChat\BlazorChat\ThirdPartyChatLib\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\MyProjects\BlazorChat\BlazorChat\ThirdPartyChatLib\ThirdPartyChat.razor"
using BlazorChat.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/chat")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/chat/{ToUserId:int}")]
    public partial class ThirdPartyChat : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"col-12\">\r\n    <p></p>\r\n</div>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "border:0px;height:90vh;");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "panel panel-primary");
            __builder.AddAttribute(6, "style", "height: 100%;");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "panel-heading top-bar");
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-md-8 col-xs-8");
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "h3");
            __builder.AddAttribute(15, "class", "panel-title");
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 15 "D:\MyProjects\BlazorChat\BlazorChat\ThirdPartyChatLib\ThirdPartyChat.razor"
                 if(ToUser != null && (ToUser.FirstName != null || ToUser.LastName != null))
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "                    ");
            __builder.OpenElement(18, "b");
            __builder.AddContent(19, 
#nullable restore
#line 17 "D:\MyProjects\BlazorChat\BlazorChat\ThirdPartyChatLib\ThirdPartyChat.razor"
                        ToUser.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(20, "<span> </span>");
            __builder.AddContent(21, 
#nullable restore
#line 17 "D:\MyProjects\BlazorChat\BlazorChat\ThirdPartyChatLib\ThirdPartyChat.razor"
                                                       ToUser.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 18 "D:\MyProjects\BlazorChat\BlazorChat\ThirdPartyChatLib\ThirdPartyChat.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n        ");
            __builder.AddMarkupContent(27, "<div id=\"divMessageContainerBase\" class=\"panel-body msg_container_base\">\r\n\r\n        </div>\r\n\r\n        \r\n        ");
            __builder.AddMarkupContent(28, @"<div class=""panel-footer"">
            <div class=""input-group"" id=""myForm"">
                <input id=""txtMessageInput"" type=""text"" class=""form-control input-sm chat_input"" placeholder=""Write your message here..."">
            </div>
        </div>
    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "D:\MyProjects\BlazorChat\BlazorChat\ThirdPartyChatLib\ThirdPartyChat.razor"
       
    [Parameter]
    public int ToUserId { get; set; } = 1;
    private List<Contact> ContactList { get; set; } = new List<Contact>();
    public Contact ToUser { get; set; } = new Contact();

    protected override void OnInitialized()
    {
        ContactList.Add(new Contact(1, "Julius", "Caesar"));
        ContactList.Add(new Contact(2, "Daniel", "Tonini"));
        ContactList.Add(new Contact(3, "Gary", "Thomas"));
        ContactList.Add(new Contact(4, "Martin", "Sommer"));
        ContactList.Add(new Contact(5, "Howard", "Snyder"));

        ToUser = ContactList.Where(con => con.ContactId == ToUserId).FirstOrDefault();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
